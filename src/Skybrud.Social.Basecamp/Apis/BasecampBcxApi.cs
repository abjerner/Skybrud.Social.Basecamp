using Skybrud.Social.Basecamp.Endpoints.Bcx;

namespace Skybrud.Social.Basecamp.Apis {

    public class BasecampBcxApi {

        /// <summary>
        /// Gets a reference to the <strong>People</strong> endpoint.
        /// </summary>
        public BcxPeopleEndpoint People { get; }

        /// <summary>
        /// Gets a reference to the <strong>Projects</strong> endpoint.
        /// </summary>
        public BcxProjectsEndpoint Projects { get; }

        /// <summary>
        /// Gets a reference to the <strong>Todolists</strong> endpoint.
        /// </summary>
        public BcxTodolistsEndpoint Todolists { get; }

        internal BasecampBcxApi(BasecampHttpService service) {
            People = new BcxPeopleEndpoint(service);
            Projects = new BcxProjectsEndpoint(service);
            Todolists = new BcxTodolistsEndpoint(service);
        }

    }

}