using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Basecamp.Models.Bc3.Webhooks
{
    public class BasecampWebhookTodoCreatedDetails : BasecampWebhookDetails {

        public long[] NotifiedRecipientIds { get; }
            
        protected BasecampWebhookTodoCreatedDetails(JObject json) : base(json) {
            NotifiedRecipientIds = json.GetInt64Array("notified_recipient_ids");
        }
            
        public new static BasecampWebhookTodoCreatedDetails Parse(JObject json) {
            return json == null ? null : new BasecampWebhookTodoCreatedDetails(json);
        }

    }
}