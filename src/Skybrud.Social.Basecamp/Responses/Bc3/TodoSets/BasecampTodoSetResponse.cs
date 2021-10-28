using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.Models.Bc3.TodoSets;

namespace Skybrud.Social.Basecamp.Responses.Bc3.TodoSets {
    
    /// <summary>
    /// Class representing a response with information about a Basecamp to-do set.
    /// </summary>
    public class BasecampTodoSetResponse : BasecampResponse<BasecampTodoSet> {

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The raw response the instance should be based on.</param>
        public BasecampTodoSetResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonObject(response.Body, BasecampTodoSet.Parse);
        }

    }

}