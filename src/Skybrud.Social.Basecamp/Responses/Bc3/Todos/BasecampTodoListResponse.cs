using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.Models.Bc3.Todos;

namespace Skybrud.Social.Basecamp.Responses.Bc3.Todos {
    
    /// <summary>
    /// Class representing a response with a list of Basecamp to-dos.
    /// </summary>
    public class BasecampTodoListResponse : BasecampListResponse<BasecampTodo> {

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The raw response the instance should be based on.</param>
        public BasecampTodoListResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonArray(response.Body, BasecampTodo.Parse);
        }

    }

}