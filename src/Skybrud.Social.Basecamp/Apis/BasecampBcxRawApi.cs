using Skybrud.Social.Basecamp.Endpoints.Bcx;
using Skybrud.Social.Basecamp.OAuth;

namespace Skybrud.Social.Basecamp.Apis {
   
    /// <summary>
    /// Class representing the raw implementation of the Basecamp 2 API.
    /// </summary>
    public class BasecampBcxRawApi {

        /// <summary>
        /// Gets a reference to the raw <strong>People</strong> endpoint.
        /// </summary>
        public BcxPeopleRawEndpoint People { get; }

        /// <summary>
        /// Gets a reference to the raw <strong>Projects</strong> endpoint.
        /// </summary>
        public BcxProjectsRawEndpoint Projects { get; }

        /// <summary>
        /// Gets a reference to the raw <strong>Todolists</strong> endpoint.
        /// </summary>
        public BcxTodolistsRawEndpoint Todolists { get; }

        internal BasecampBcxRawApi(BasecampOAuthClient client) {
            People = new BcxPeopleRawEndpoint(client);
            Projects = new BcxProjectsRawEndpoint(client);
            Todolists = new BcxTodolistsRawEndpoint(client);
        }

    }

}