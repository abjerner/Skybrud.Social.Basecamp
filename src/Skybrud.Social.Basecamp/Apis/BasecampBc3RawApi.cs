using Skybrud.Social.Basecamp.Endpoints.Bc3;
using Skybrud.Social.Basecamp.OAuth;

namespace Skybrud.Social.Basecamp.Apis {
    
    /// <summary>
    /// Class representing the raw implementation of the Basecamp 3 API.
    /// </summary>
    public class BasecampBc3RawApi {

        /// <summary>
        /// Gets a reference to the raw <strong>People</strong> endpoint.
        /// </summary>
        public BasecampPeopleRawEndpoint People { get; }

        internal BasecampBc3RawApi(BasecampOAuthClient client) {
            People = new BasecampPeopleRawEndpoint(client);
        }

    }

}