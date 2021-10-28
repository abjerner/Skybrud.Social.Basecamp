using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.Models.Bc3.Projects;

namespace Skybrud.Social.Basecamp.Responses.Bc3.Projects {
    
    /// <summary>
    /// Class representing a response with a list of Basecamp projects.
    /// </summary>
    public class BasecampProjectListResponse : BasecampListResponse<BasecampProject> {

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The raw response the instance should be based on.</param>
        public BasecampProjectListResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonArray(response.Body, BasecampProject.Parse);
        }

    }

}