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

        /// <summary>
        /// Returns the profile for the user with the specified <paramref name="personId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the Basecamp account.</param>
        /// <param name="personId">The ID of the person.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/people.md#get-person</cref>
        /// </see>
        public IHttpResponse GetPerson(int accountId, int personId) {
            return Client.Get($"/{accountId}/people/{personId}.json");
        }

        /// <summary>
        /// Returns the profile of the current user.
        /// </summary>
        /// <param name="accountId">The ID of the Basecamp account.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/people.md#get-my-personal-info</cref>
        /// </see>
        public IHttpResponse GetProfile(int accountId) {
            return Client.Get($"/{accountId}/my/profile.json");
        }

        /// <summary>
        /// Returns a paginated list of all people visible to the current user.
        /// </summary>
        /// <param name="accountId">The ID of the Basecamp account.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/people.md#get-all-people</cref>
        /// </see>
        public IHttpResponse GetAll(int accountId) {
            return Client.Get($"/{accountId}/people.json");
        }

        /// <summary>
        /// Returns a paginated list of all people visible to the current user.
        /// </summary>
        /// <param name="accountId">The ID of the Basecamp account.</param>
        /// <param name="page">The page of the page that should be returned by the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/people.md#get-all-people</cref>
        /// </see>
        public IHttpResponse GetAll(int accountId, int page) {
            return Client.Get($"/{accountId}/people.json", new HttpQueryString {{"page", page}});
        }

        #endregion

    }

}