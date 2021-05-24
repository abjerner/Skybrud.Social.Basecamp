using Skybrud.Social.Basecamp.Responses.People;

namespace Skybrud.Social.Basecamp.Endpoints {

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
        public BasecampPeopleRawEndpoint Raw => Service.Client.People;

        #endregion

        #region Constructors

        internal BasecampPeopleEndpoint(BasecampService service) {
            Service = service;
        }

        #endregion

        #region Member methods

        public BasecampPersonResponse GetPerson(int accountId, int personId) {
            return new BasecampPersonResponse(Raw.GetPerson(accountId, personId));
        }

        public BasecampPersonResponse GetProfile(int accountId) {
            return new BasecampPersonResponse(Raw.GetProfile(accountId));
        }

        public BasecampPersonListResponse GetAll(int accountId) {
            return new BasecampPersonListResponse(Raw.GetAll(accountId));
        }

        public BasecampPersonListResponse GetAll(int accountId, int page) {
            return new BasecampPersonListResponse(Raw.GetAll(accountId, page));
        }

        #endregion

    }

}