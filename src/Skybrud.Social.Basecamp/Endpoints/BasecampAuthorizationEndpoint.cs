using Skybrud.Social.Basecamp.Responses.Authentication;

namespace Skybrud.Social.Basecamp.Endpoints {

    /// <summary>
    /// Class representing the <strong>Authorization</strong> endpoint.
    /// </summary>
    public class BasecampAuthorizationEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the parent HTTP service.
        /// </summary>
        public BasecampHttpService Service { get; }

        /// <summary>
        /// Gets a reference to the raw <strong>Authorization</strong> endpoint.
        /// </summary>
        public BasecampAuthorizationRawEndpoint Raw => Service.Client.Authorization;

        #endregion

        #region Constructors

        internal BasecampAuthorizationEndpoint(BasecampHttpService service) {
            Service = service;
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
        /// <returns>An instance of <see cref="BasecampAuthorizationResponse"/> representing the response.</returns>
        public BasecampAuthorizationResponse GetAuthorization() {
            return new BasecampAuthorizationResponse(Raw.GetAuthorization());
        }

        #endregion

    }

}