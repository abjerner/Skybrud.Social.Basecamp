using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.Models.Bc3.Todos;

namespace Skybrud.Social.Basecamp.Responses.Bc3.Todos {
    
    /// <summary>
    /// Class representing a response with information about a Basecamp to-do.
    /// </summary>
    public class BasecampTodoResponse : BasecampResponse<BasecampTodo> {

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The raw response the instance should be based on.</param>
        public BasecampTodoResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonObject(response.Body, BasecampTodo.Parse);
        }

    }

}