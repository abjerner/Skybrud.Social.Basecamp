using System;
using Skybrud.Social.Basecamp.Apis;
using Skybrud.Social.Basecamp.Endpoints;
using Skybrud.Social.Basecamp.OAuth;
using Skybrud.Social.Basecamp.Responses.Authentication;

namespace Skybrud.Social.Basecamp {

    /// <summary>
    /// Class representing the object oriented implementation of the Basecamp API.
    /// </summary>
    public class BasecampHttpService {

        #region Properties

        /// <summary>
        /// Gets a reference to the Basecamp OAuth client.
        /// </summary>
        public BasecampOAuthClient Client { get; }

        /// <summary>
        /// Gets a reference to the <strong>Authorization</strong> endpoint.
        /// </summary>
        public BasecampAuthorizationEndpoint Authorization { get; }

        /// <summary>
        /// Gets a reference to the <strong>Basecamp 2</strong> API implementation.
        /// </summary>
        public BasecampBcxApi Bcx { get; }

        /// <summary>
        /// Gets a reference to the <strong>Basecamp 3</strong> API implementation.
        /// </summary>
        public BasecampBc3Api Bc3 { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new service instance with default settings.
        /// </summary>
        public BasecampHttpService() : this(new BasecampOAuthClient()) { }

        /// <summary>
        /// Initializes a new service based on the specified <paramref name="client"/>.
        /// </summary>
        /// <param name="client">The OAuth client that this service instance should wrap.</param>
        public BasecampHttpService(BasecampOAuthClient client) {
            Client = client ?? throw new ArgumentNullException(nameof(client));
            Authorization = new BasecampAuthorizationEndpoint(this);
            Bcx = new BasecampBcxApi(this);
            Bc3 = new BasecampBc3Api(this);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Initialize a new service instance from the specified OAuth <paramref name="client"/>.
        /// </summary>
        /// <param name="client">The OAuth client.</param>
        public static BasecampHttpService CreateFromOAuthClient(BasecampOAuthClient client) {
            if (client == null) throw new ArgumentNullException(nameof(client));
            return new BasecampHttpService(client);
        }

        /// <summary>
        /// Initializes a new service instance from the specified OAuth 2 <paramref name="accessToken"/>.
        /// </summary>
        /// <param name="accessToken">The access token.</param>
        public static BasecampHttpService CreateFromAccessToken(string accessToken) {
            if (string.IsNullOrWhiteSpace(accessToken)) throw new ArgumentNullException(nameof(accessToken));
            return new BasecampHttpService(new BasecampOAuthClient {AccessToken = accessToken});
        }

        /// <summary>
        /// Initializes a new service instance from the specified OAuth 2 <paramref name="refreshToken"/>.
        /// </summary>
        /// <param name="clientId">The client ID.</param>
        /// <param name="clientSecret">The client Secret.</param>
        /// <param name="refreshToken">The refresh token.</param>
        /// <remarks>Calling this method will result in a request to the Basecamp API to exchange the refresh token for a new access token.</remarks>
        public static BasecampHttpService CreateFromRefreshToken(string clientId, string clientSecret, string refreshToken) {
            
            if (string.IsNullOrWhiteSpace(clientId)) throw new ArgumentNullException(nameof(clientId));
            if (string.IsNullOrWhiteSpace(clientSecret)) throw new ArgumentNullException(nameof(clientSecret));
            if (string.IsNullOrWhiteSpace(refreshToken)) throw new ArgumentNullException(nameof(refreshToken));

            // Initialize a new OAuth client
            BasecampOAuthClient client = new() {
                ClientId = clientId,
                ClientSecret = clientSecret
            };

            // Make the request to the Basecamp API
            BasecampTokenResponse response = client.GetAccessTokenFromRefreshToken(refreshToken);

            // Initialize a new HTTP service
            return CreateFromAccessToken(response.Body.AccessToken);

        }

        #endregion

    }

}