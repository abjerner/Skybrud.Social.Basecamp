using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.Models.Bcx.Projects;

namespace Skybrud.Social.Basecamp.Responses.Bcx.Projects {
    
    /// <summary>
    /// Class representing a response with profile information about a single project.
    /// </summary>
    public class BcxProjectResponse : BcxResponse<BcxProject> {

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The raw response the instance should be based on.</param>
        public BcxProjectResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonObject(response.Body, BcxProject.Parse);
        }

    }

}