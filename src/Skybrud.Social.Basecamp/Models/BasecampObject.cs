using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json;

namespace Skybrud.Social.Basecamp.Models {
    
    public class BasecampObject : JsonObjectBase  {
        
        protected BasecampObject(JObject obj) : base(obj) { }

        protected static bool TryParseJson(string json, out JObject result) {

            json = json.Trim();

            if (json[0] == '{' && json[json.Length - 1] == '}') {
                result = JsonUtils.ParseJsonObject(json);
                return true;
            }

            result = null;
            return false;

        }

    }

}