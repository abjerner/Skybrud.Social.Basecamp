using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.Models.Bc3.TodoLists;

namespace Skybrud.Social.Basecamp.Responses.Bc3.TodoLists {
    
    /// <summary>
    /// Class representing a response with information about a Basecamp to-do list.
    /// </summary>
    public class BasecampTodoListResponse : BasecampResponse<BasecampTodoList> {

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The raw response the instance should be based on.</param>
        public BasecampTodoListResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonObject(response.Body, BasecampTodoList.Parse);
        }

    }

}