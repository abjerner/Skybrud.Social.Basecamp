using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.OAuth;
using Skybrud.Social.Basecamp.Options.Bcx.People;

namespace Skybrud.Social.Basecamp.Endpoints.Bcx {

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
        /// Returns information about the authenticated user.
        /// </summary>
        /// <param name="accountId">The ID of the Basecamp 2 account.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/people.md#get-person</cref>
        /// </see>
        public IHttpResponse GetProfile(long accountId) {
            return Client.GetResponse(new BasecampGetProfileOptions(accountId));
        }

        /// <summary>
        /// Returns information about the person with the specified <paramref name="personId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the Basecamp 2 account.</param>
        /// <param name="personId">The ID of the person.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/people.md#get-person</cref>
        /// </see>
        public IHttpResponse GetPerson(long accountId, long personId) {
            return Client.GetResponse(new BasecampGetPersonOptions(accountId, personId));
        }
        
        /// <summary>
        /// Returns a list of all people on the account.
        /// </summary>
        /// <param name="accountId">The ID of the Basecamp 2 account.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/people.md#get-people</cref>
        /// </see>
        public IHttpResponse GetAll(long accountId) {
            return Client.GetResponse(new BasecampGetPeopleOptions(accountId));
        }

        #endregion

    }

}