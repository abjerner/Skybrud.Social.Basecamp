using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.Models.Bcx.Todolists;

namespace Skybrud.Social.Basecamp.Responses.Bcx.Todolists {
    
    /// <summary>
    /// Class representing a response with information about a single todolist.
    /// </summary>
    public class BcxTodolistResponse : BcxResponse<BcxTodolist> {

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The raw response the instance should be based on.</param>
        public BcxTodolistResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonObject(response.Body, BcxTodolist.Parse);
        }

    }

}