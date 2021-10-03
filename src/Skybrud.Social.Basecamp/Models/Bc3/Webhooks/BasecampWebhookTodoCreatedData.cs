using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Basecamp.Models.Bc3.Todos;

namespace Skybrud.Social.Basecamp.Models.Bc3.Webhooks {
    
    public class BasecampWebhookTodoCreatedData : BasecampWebhookData {

        public new BasecampWebhookTodoCreatedDetails Details { get; }

        public new BasecampTodo Recording => base.Recording as BasecampTodo;
            
        internal BasecampWebhookTodoCreatedData(JObject json) : base(json) {
            Details = json.GetObject("details", BasecampWebhookTodoCreatedDetails.Parse);
            base.Recording = json.GetObject("recording", BasecampTodo.Parse);
        }

    }

}