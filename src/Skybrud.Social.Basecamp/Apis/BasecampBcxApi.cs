using Skybrud.Social.Basecamp.Endpoints.Bcx;

namespace Skybrud.Social.Basecamp.Apis {

    public class BasecampBcxApi {

        /// <summary>
        /// Gets a reference to the <strong>People</strong> endpoint.
        /// </summary>
        public BcxPeopleEndpoint People { get; }

        internal BasecampBcxApi(BasecampService service) {
            People = new BcxPeopleEndpoint(service);
        }

    }

}