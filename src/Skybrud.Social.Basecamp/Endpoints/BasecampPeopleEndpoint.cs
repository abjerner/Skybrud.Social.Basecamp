using Skybrud.Social.Basecamp.Responses.People;

namespace Skybrud.Social.Basecamp.Endpoints {
    
    public class BasecampPeopleEndpoint {
        
        public BasecampService Service { get; }

        public BasecampPeopleRawEndpoint Raw => Service.Client.People;

        public BasecampPeopleEndpoint(BasecampService service) {
            Service = service;
        }

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

    }

}