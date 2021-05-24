using System;
using Skybrud.Social.Basecamp.Endpoints;
using Skybrud.Social.Basecamp.OAuth;

namespace Skybrud.Social.Basecamp {

    /// <summary>
    /// Class representing the object oriented implementation of the Basecamp API.
    /// </summary>
    public class BasecampService {

        #region Properties

        /// <summary>
        /// Gets a reference to the Basecamp OAuth client.
        /// </summary>
        public BasecampOAuthClient Client { get; }

        /// <summary>
        /// Gets a reference to the <strong>People</strong> endpoint.
        /// </summary>
        public BasecampPeopleEndpoint People { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new service instance with default settings.
        /// </summary>
        public BasecampService() : this(new BasecampOAuthClient()) { }

        /// <summary>
        /// Initializes a new service based on the specified <paramref name="client"/>.
        /// </summary>
        /// <param name="client">The OAuth client that this service instance should wrap.</param>
        public BasecampService(BasecampOAuthClient client) {
            Client = client ?? throw new ArgumentNullException(nameof(client));
            People = new BasecampPeopleEndpoint(this);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Initialize a new service instance from the specified OAuth <paramref name="client"/>.
        /// </summary>
        /// <param name="client">The OAuth client.</param>
        public static BasecampService CreateFromOAuthClient(BasecampOAuthClient client) {
            if (client == null) throw new ArgumentNullException(nameof(client));
            return new BasecampService(client);
        }

        /// <summary>
        /// Initializes a new service instance from the specified OAuth 2 <paramref name="accessToken"/>.
        /// </summary>
        /// <param name="accessToken">The access token.</param>
        public static BasecampService CreateFromAccessToken(string accessToken) {
            if (string.IsNullOrWhiteSpace(accessToken)) throw new ArgumentNullException(nameof(accessToken));
            return new BasecampService(new BasecampOAuthClient {AccessToken = accessToken});
        }

        #endregion

    }

}