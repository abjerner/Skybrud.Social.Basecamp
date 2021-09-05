using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.OAuth;
using Skybrud.Social.Basecamp.Options.Bc3.People;

namespace Skybrud.Social.Basecamp.Endpoints.Bc3 {

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
        public IHttpResponse GetPerson(long accountId, long personId) {
            return Client.GetResponse(new BasecampGetPersonOptions(accountId, personId));
        }

        /// <summary>
        /// Returns the profile of the current user.
        /// </summary>
        /// <param name="accountId">The ID of the Basecamp account.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/people.md#get-my-personal-info</cref>
        /// </see>
        public IHttpResponse GetProfile(long accountId) {
            return Client.GetResponse(new BasecampGetProfileOptions(accountId));
        }

        /// <summary>
        /// Returns a paginated list of all people visible to the current user.
        /// </summary>
        /// <param name="accountId">The ID of the Basecamp account.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/people.md#get-all-people</cref>
        /// </see>
        public IHttpResponse GetAll(long accountId) {
            return Client.GetResponse(new BasecampGetPeopleOptions(accountId));
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
        public IHttpResponse GetAll(long accountId, int page) {
            return Client.GetResponse(new BasecampGetPeopleOptions(accountId, page));
        }

        #endregion

    }

}