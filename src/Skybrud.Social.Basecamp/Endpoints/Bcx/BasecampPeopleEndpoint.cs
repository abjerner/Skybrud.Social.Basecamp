using Skybrud.Social.Basecamp.Responses.Bcx.People;

namespace Skybrud.Social.Basecamp.Endpoints.Bcx {

    /// <summary>
    /// Class representing the <strong>People</strong> endpoint.
    /// </summary>
    public class BasecampPeopleEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the parent service.
        /// </summary>
        public BasecampService Service { get; }

        /// <summary>
        /// Gets a reference to the raw <strong>People</strong> endpoint.
        /// </summary>
        public BasecampPeopleRawEndpoint Raw => Service.Client.Bcx.People;

        #endregion

        #region Constructors

        internal BasecampPeopleEndpoint(BasecampService service) {
            Service = service;
        }

        #endregion

        #region Member methods
        
        /// <summary>
        /// Returns information about the authenticated user.
        /// </summary>
        /// <param name="accountId">The ID of the Basecamp 2 account.</param>
        /// <returns>An instance of <see cref="BasecampPersonResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/people.md#get-person</cref>
        /// </see>
        public BasecampPersonResponse GetProfile(long accountId) {
            return new BasecampPersonResponse(Raw.GetProfile(accountId));
        }

        /// <summary>
        /// Returns information about the person with the specified <paramref name="personId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the Basecamp 2 account.</param>
        /// <param name="personId">The ID of the person.</param>
        /// <returns>An instance of <see cref="BasecampPersonResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/people.md#get-person</cref>
        /// </see>
        public BasecampPersonResponse GetPerson(long accountId, long personId) {
            return new BasecampPersonResponse(Raw.GetPerson(accountId, personId));
        }
        
        /// <summary>
        /// Returns a list of all people on the account.
        /// </summary>
        /// <param name="accountId">The ID of the Basecamp 2 account.</param>
        /// <returns>An instance of <see cref="BasecampPersonListResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/people.md#get-people</cref>
        /// </see>
        public BasecampPersonListResponse GetAll(int accountId) {
            return new BasecampPersonListResponse(Raw.GetAll(accountId));
        }

        #endregion

    }

}