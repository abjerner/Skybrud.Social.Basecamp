using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.Models.Bcx.Projects;

namespace Skybrud.Social.Basecamp.Responses.Bcx.Projects {
    
    /// <summary>
    /// Class representing a response with a list of projects.
    /// </summary>
    public class BcxProjectListResponse : BcxListResponse<BcxProjectItem> {

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The raw response the instance should be based on.</param>
        public BcxProjectListResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonArray(response.Body, BcxProjectItem.Parse);
        }

    }

}