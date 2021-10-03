using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Basecamp.Models.Bc3.Comments;
using Skybrud.Social.Basecamp.Models.Bc3.Todos;

namespace Skybrud.Social.Basecamp.Models.Bc3.Webhooks {
    
    public class BasecampWebhookCommentCreatedData : BasecampWebhookData {

        /// <summary>
        /// Gets the details associated with the <see cref="Recording"/>.
        /// </summary>
        public new BasecampWebhookCommentCreatedDetails Details { get; }

        /// <summary>
        /// Gets a reference to the recording - eg. <see cref="BasecampTodo"/> or <see cref="BasecampComment"/>.
        /// </summary>
        public new BasecampComment Recording => base.Recording as BasecampComment;
            
        internal BasecampWebhookCommentCreatedData(JObject json) : base(json) {
            Details = json.GetObject("details", BasecampWebhookCommentCreatedDetails.Parse);
            base.Recording = json.GetObject("recording", BasecampTodo.Parse);
        }

    }

}