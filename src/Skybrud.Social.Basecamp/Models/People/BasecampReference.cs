using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Basecamp.Models.People {
    
    public class BasecampReference : JsonObjectBase {

        public int Id { get; }

        public string Name { get; }

        private BasecampReference(JObject json) : base(json)  {
            Id = json.GetInt32("id");
            Name = json.GetString("name");
        }

        public static BasecampReference Parse(JObject json) {
            return json == null ? null : new BasecampReference(json);
        }

    }

}