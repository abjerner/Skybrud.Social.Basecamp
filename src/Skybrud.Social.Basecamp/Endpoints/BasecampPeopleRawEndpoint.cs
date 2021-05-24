using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Collections;
using Skybrud.Social.Basecamp.OAuth;

namespace Skybrud.Social.Basecamp.Endpoints {

    /// <summary>
    /// Class representing the raw <strong>People</strong> endpoint.
    /// </summary>
    public class BasecampPeopleRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the parent OAuth client.
        /// </summary>
        public BasecampOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal BasecampPeopleRawEndpoint(BasecampOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Member methods

        public IHttpResponse GetPerson(int accountId, int personId) {
            return Client.Get($"/{accountId}/people/{personId}.json");
        }

        public IHttpResponse GetProfile(int accountId) {
            return Client.Get($"/{accountId}/my/profile.json");
        }

        public IHttpResponse GetAll(int accountId) {
            return Client.Get($"/{accountId}/people.json");
        }

        public IHttpResponse GetAll(int accountId, int page) {
            return Client.Get($"/{accountId}/people.json", new HttpQueryString {{"page", page}});
        }

        #endregion

    }

}