using System;
using Skybrud.Social.Basecamp.Apis;
using Skybrud.Social.Basecamp.OAuth;

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

        #endregion

    }

}