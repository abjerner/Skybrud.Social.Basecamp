using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.OAuth;

namespace Skybrud.Social.Basecamp.Endpoints {

    /// <summary>
    /// Class representing the raw <strong>Authorization</strong> endpoint.
    /// </summary>
    public class BasecampAuthorizationRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the parent OAuth client.
        /// </summary>
        public BasecampOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal BasecampAuthorizationRawEndpoint(BasecampOAuthClient client) {
            Client = client;
        }
        
        #endregion

        #region Member methods

        public IHttpResponse GetAuthorization() {
            return Client.Get("https://launchpad.37signals.com/authorization.json");
        }

        #endregion

    }

}