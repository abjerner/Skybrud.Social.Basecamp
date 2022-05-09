using Skybrud.Social.Basecamp.Responses.Bc3.People;

namespace Skybrud.Social.Basecamp.Endpoints.Bc3 {

    /// <summary>
    /// Class representing the <strong>People</strong> endpoint.
    /// </summary>
    public class BasecampPeopleEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the parent service.
        /// </summary>
        public BasecampHttpService Service { get; }

        /// <summary>
        /// Gets a reference to the raw <strong>People</strong> endpoint.
        /// </summary>
        public BasecampPeopleRawEndpoint Raw => Service.Client.Bc3.People;

        #endregion

        #region Constructors

        internal BasecampPeopleEndpoint(BasecampHttpService service) {
            Service = service;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Returns the profile for the user with the specified <paramref name="personId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the Basecamp account.</param>
        /// <param name="personId">The ID of the person.</param>
        /// <returns>An instance of <see cref="BasecampPersonResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/people.md#get-person</cref>
        /// </see>
        public BasecampPersonResponse GetPerson(long accountId, int personId) {
            return new BasecampPersonResponse(Raw.GetPerson(accountId, personId));
        }

        /// <summary>
        /// Returns the profile of the current user.
        /// </summary>
        /// <param name="accountId">The ID of the Basecamp account.</param>
        /// <returns>An instance of <see cref="BasecampPersonResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/people.md#get-my-personal-info</cref>
        /// </see>
        public BasecampPersonResponse GetProfile(long accountId) {
            return new BasecampPersonResponse(Raw.GetProfile(accountId));
        }

        /// <summary>
        /// Returns a paginated list of all people visible to the current user.
        /// </summary>
        /// <param name="accountId">The ID of the Basecamp account.</param>
        /// <returns>An instance of <see cref="BasecampPersonListResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/people.md#get-all-people</cref>
        /// </see>
        public BasecampPersonListResponse GetAll(long accountId) {
            return new BasecampPersonListResponse(Raw.GetAll(accountId));
        }

        /// <summary>
        /// Returns a paginated list of all people visible to the current user.
        /// </summary>
        /// <param name="accountId">The ID of the Basecamp account.</param>
        /// <param name="page">The page of the page that should be returned by the API.</param>
        /// <returns>An instance of <see cref="BasecampPersonListResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/people.md#get-all-people</cref>
        /// </see>
        public BasecampPersonListResponse GetAll(long accountId, int page) {
            return new BasecampPersonListResponse(Raw.GetAll(accountId, page));
        }

        #endregion

    }

}