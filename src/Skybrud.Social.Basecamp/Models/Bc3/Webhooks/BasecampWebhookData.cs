using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Enums;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;
using Skybrud.Social.Basecamp.Models.Bc3.People;

namespace Skybrud.Social.Basecamp.Models.Bc3.Webhooks {

    public abstract class BasecampWebhookData : BasecampObject {
            
        public long Id { get; }

        public BasecampWebhookKind Kind { get; set; }

        public BasecampWebhookDetails Details { get; protected set; }

        public EssentialsTime CreatedAt { get; }

        public BasecampObject Recording { get; protected set; }

        public BasecampPerson Creator { get; }

        protected BasecampWebhookData(JObject json) : base(json) {
            Id = json.GetInt64("id");
            Kind = json.GetEnum("kind", BasecampWebhookKind.Unknown);
            Details = json.GetObject("details", BasecampWebhookDetails.Parse);
            CreatedAt = json.GetString("created_at", EssentialsTime.Parse);
            Creator = json.GetObject("creator", BasecampPerson.Parse);
        }

        public static BasecampWebhookData Parse(JObject json) {

            if (json == null) return null;

            string kind = json.GetString("kind");

            BasecampWebhookKind kindEnum = EnumUtils.ParseEnum(kind, BasecampWebhookKind.Unknown);

            switch (kindEnum) {

                case BasecampWebhookKind.TodoCreated:
                    return new BasecampWebhookTodoCreatedData(json);

                //case BasecampWebhookKind.TodoAssignmentCreated:
                //    return new BasecampWebhookData(json);

                default:
                    throw new Exception("Unsupported kind " + kind);
                    
            }

        }

    }
}