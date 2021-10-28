using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.Models.Bc3.TodoLists;

namespace Skybrud.Social.Basecamp.Responses.Bc3.TodoLists {
    
    /// <summary>
    /// Class representing a response with a list of Basecamp to-do lists.
    /// </summary>
    public class BasecampTodoListListResponse : BasecampListResponse<BasecampTodoList> {

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The raw response the instance should be based on.</param>
        public BasecampTodoListListResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonArray(response.Body, BasecampTodoList.Parse);
        }

    }

}