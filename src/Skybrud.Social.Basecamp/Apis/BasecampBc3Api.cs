using Skybrud.Social.Basecamp.Endpoints.Bc3;

namespace Skybrud.Social.Basecamp.Apis {
   
    public class BasecampBc3Api {

        /// <summary>
        /// Gets a reference to the <strong>People</strong> endpoint.
        /// </summary>
        public BasecampPeopleEndpoint People { get; }
        
        internal BasecampBc3Api(BasecampService service) {
            People = new BasecampPeopleEndpoint(service);
        }

    }
}