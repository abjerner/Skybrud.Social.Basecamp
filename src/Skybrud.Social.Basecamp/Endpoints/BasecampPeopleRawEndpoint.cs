using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Collections;
using Skybrud.Social.Basecamp.OAuth;

namespace Skybrud.Social.Basecamp.Endpoints {
    
    public class BasecampPeopleRawEndpoint {
        
        public BasecampOAuthClient Client { get; }

        public BasecampPeopleRawEndpoint(BasecampOAuthClient client) {
            Client = client;
        }

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

    }

}