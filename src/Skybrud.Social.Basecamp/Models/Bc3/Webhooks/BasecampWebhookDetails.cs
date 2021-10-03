using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Basecamp.Models.Bc3.Webhooks
{
    public class BasecampWebhookDetails : BasecampObject {
        
        protected BasecampWebhookDetails(JObject json) : base(json) { }
        
        public static BasecampWebhookDetails Parse(JObject json) {
            return json == null ? null : new BasecampWebhookDetails(json);
        }

    }
}