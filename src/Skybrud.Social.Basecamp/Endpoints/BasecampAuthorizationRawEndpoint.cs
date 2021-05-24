using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.OAuth;

namespace Skybrud.Social.Basecamp.Endpoints {
    
    public class BasecampAuthorizationRawEndpoint {
        
        public BasecampOAuthClient Client { get; }

        public BasecampAuthorizationRawEndpoint(BasecampOAuthClient client) {
            Client = client;
        }

        public IHttpResponse GetAuthorization() {
            return Client.Get("https://launchpad.37signals.com/authorization.json");
        }
             
    }

}