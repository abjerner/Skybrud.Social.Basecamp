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

        /// <summary>
        /// Returns authorization information about the authenticated user.
        ///
        /// The authorization information will specify the expiration time of the used access token, the 37signals
        /// identity of the authenticated user, as well as a list of the Basecamp 2 and 3 accounts the authenticated
        /// user has access to.
        /// </summary>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetAuthorization() {
            return Client.Get("https://launchpad.37signals.com/authorization.json");
        }

        #endregion

    }

}