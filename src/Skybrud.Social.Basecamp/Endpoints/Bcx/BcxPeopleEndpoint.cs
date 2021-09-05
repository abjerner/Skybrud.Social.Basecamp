using Skybrud.Social.Basecamp.Responses.Bcx.People;

namespace Skybrud.Social.Basecamp.Endpoints.Bcx {

    /// <summary>
    /// Class representing the <strong>People</strong> endpoint.
    /// </summary>
    public class BcxPeopleEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the parent service.
        /// </summary>
        public BasecampService Service { get; }

        /// <summary>
        /// Gets a reference to the raw <strong>People</strong> endpoint.
        /// </summary>
        public BcxPeopleRawEndpoint Raw => Service.Client.Bcx.People;

        #endregion

        #region Constructors

        internal BcxPeopleEndpoint(BasecampService service) {
            Service = service;
        }

        #endregion

        #region Member methods
        
        /// <summary>
        /// Returns information about the authenticated user.
        /// </summary>
        /// <param name="accountId">The ID of the Basecamp 2 account.</param>
        /// <returns>An instance of <see cref="BcxPersonResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/people.md#get-person</cref>
        /// </see>
        public BcxPersonResponse GetProfile(long accountId) {
            return new BcxPersonResponse(Raw.GetProfile(accountId));
        }

        /// <summary>
        /// Returns information about the person with the specified <paramref name="personId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the Basecamp 2 account.</param>
        /// <param name="personId">The ID of the person.</param>
        /// <returns>An instance of <see cref="BcxPersonResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/people.md#get-person</cref>
        /// </see>
        public BcxPersonResponse GetPerson(long accountId, long personId) {
            return new BcxPersonResponse(Raw.GetPerson(accountId, personId));
        }
        
        /// <summary>
        /// Returns a list of all people on the account.
        /// </summary>
        /// <param name="accountId">The ID of the Basecamp 2 account.</param>
        /// <returns>An instance of <see cref="BcxPersonListResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/people.md#get-people</cref>
        /// </see>
        public BcxPersonListResponse GetAll(int accountId) {
            return new BcxPersonListResponse(Raw.GetAll(accountId));
        }

        #endregion

    }

}