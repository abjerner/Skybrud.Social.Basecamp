using Skybrud.Social.Basecamp.Endpoints.Bcx;
using Skybrud.Social.Basecamp.OAuth;

namespace Skybrud.Social.Basecamp.Apis {
   
    public class BasecampBcxRawApi {

        /// <summary>
        /// Gets a reference to the raw <strong>People</strong> endpoint.
        /// </summary>
        public BcxPeopleRawEndpoint People { get; }

        internal BasecampBcxRawApi(BasecampOAuthClient client) {
            People = new BcxPeopleRawEndpoint(client);
        }

    }

}