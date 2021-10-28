using Skybrud.Essentials.Http;
using Skybrud.Essentials.Json;
using Skybrud.Social.Basecamp.Models.Authentication;
using Skybrud.Social.Basecamp.Responses.Bc3;

namespace Skybrud.Social.Basecamp.Responses.Authentication {

    /// <summary>
    /// Class representing the response of a request to get information about the authenticated user.
    /// </summary>
    public class BasecampAuthorizationResponse : BasecampResponse<BasecampAuthorization> {

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The raw response the instance should be based on.</param>
        public BasecampAuthorizationResponse(IHttpResponse response) : base(response) {
            Body = JsonUtils.ParseJsonObject(response.Body, BasecampAuthorization.Parse);
        }

    }

}