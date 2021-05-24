using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;

namespace Skybrud.Social.Basecamp.Models.People {
    
    public class BasecampPerson : JsonObjectBase {

        public int Id { get; }

        public string AttachableSgid { get; }

        public string Name { get; }

        public string EmailAddress { get; }

        public string PersonableType { get; }

        public string Title { get; }

        public string Bio { get; }

        public EssentialsTime CreatedAt { get; }

        public EssentialsTime UpdatedAt { get; }

        public bool IsAdmin { get; }

        public bool IsOwner { get; }

        public bool IsClient { get; }

        public string TimeZone { get; }

        public string AvatarUrl { get; }

        public BasecampReference Company { get; }

        private BasecampPerson(JObject json) : base(json)  {
            Id = json.GetInt32("id");
            AttachableSgid = json.GetString("attachable_sgid");
            Name = json.GetString("name");
            EmailAddress = json.GetString("email_address");
            PersonableType = json.GetString("personable_type");
            Title = json.GetString("title");
            Bio = json.GetString("bio");
            CreatedAt = json.GetString("created_at", EssentialsTime.Parse);
            UpdatedAt = json.GetString("updated_at", EssentialsTime.Parse);
            IsAdmin = json.GetBoolean("admin");
            IsOwner = json.GetBoolean("owner");
            IsClient = json.GetBoolean("client");
            TimeZone = json.GetString("time_zone");
            AvatarUrl = json.GetString("avatar_url");
            Company = json.GetObject("company", BasecampReference.Parse);
        }

        public static BasecampPerson Parse(JObject json) {
            return json == null ? null : new BasecampPerson(json);
        }

    }

}