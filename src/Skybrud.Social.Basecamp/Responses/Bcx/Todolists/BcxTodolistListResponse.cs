using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.Models.Bcx.Todolists;

namespace Skybrud.Social.Basecamp.Responses.Bcx.Todolists {
    
    /// <summary>
    /// Class representing a response with a list of todolists.
    /// </summary>
    public class BcxTodolistListResponse : BcxListResponse<BcxTodolistItem> {

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The raw response the instance should be based on.</param>
        public BcxTodolistListResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonArray(response.Body, BcxTodolistItem.Parse);
        }

    }

}