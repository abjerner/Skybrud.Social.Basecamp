using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.Models.Bc3.Projects;

namespace Skybrud.Social.Basecamp.Responses.Bc3.Projects {
    
    /// <summary>
    /// Class representing a response with information about a Basecamp project.
    /// </summary>
    public class BasecampProjectResponse : BasecampResponse<BasecampProject> {

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The raw response the instance should be based on.</param>
        public BasecampProjectResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonObject(response.Body, BasecampProject.Parse);
        }

    }

}