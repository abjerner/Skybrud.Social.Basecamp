using System;
using Skybrud.Social.Basecamp.Endpoints;
using Skybrud.Social.Basecamp.OAuth;

namespace Skybrud.Social.Basecamp {
    
    public class BasecampService {

        #region Properties

        /// <summary>
        /// Gets a reference to the Basecamp OAuth client.
        /// </summary>
        public BasecampOAuthClient Client { get; }

        public BasecampPeopleEndpoint People { get; }

        #endregion

        #region Constructors

        public BasecampService(BasecampOAuthClient client) {
            Client = client;
            People = new BasecampPeopleEndpoint(this);
        }

        #endregion

        #region Static methods

        public static BasecampService CreateFromAccessToken(string accessToken) {
            if (string.IsNullOrWhiteSpace(accessToken)) throw new ArgumentNullException(nameof(accessToken));
            return new BasecampService(new BasecampOAuthClient {AccessToken = accessToken});
        }

        #endregion

    }

}