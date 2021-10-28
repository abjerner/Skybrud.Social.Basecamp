using Skybrud.Social.Basecamp.Endpoints.Bc3;
using Skybrud.Social.Basecamp.OAuth;

namespace Skybrud.Social.Basecamp.Apis {
    
    /// <summary>
    /// Class representing the raw implementation of the Basecamp 3 API.
    /// </summary>
    public class BasecampBc3RawApi {

        /// <summary>
        /// Gets a reference to the raw <strong>People</strong> endpoint.
        /// </summary>
        public BasecampPeopleRawEndpoint People { get; }

        /// <summary>
        /// Gets a reference to the raw <strong>Projects</strong> endpoint.
        /// </summary>
        public BasecampProjectsRawEndpoint Projects { get; }

        /// <summary>
        /// Gets a reference to the raw <strong>To-dos</strong> endpoint.
        /// </summary>
        public BasecampTodosRawEndpoint Todos { get; }

        /// <summary>
        /// Gets a reference to the raw <strong>To-do lists</strong> endpoint.
        /// </summary>
        public BasecampTodoListsRawEndpoint TodoLists { get; }

        /// <summary>
        /// Gets a reference to the raw <strong>To-do sets</strong> endpoint.
        /// </summary>
        public BasecampTodoSetsRawEndpoint TodoSets { get; }

        internal BasecampBc3RawApi(BasecampOAuthClient client) {
            People = new BasecampPeopleRawEndpoint(client);
            Projects = new BasecampProjectsRawEndpoint(client);
            Todos = new BasecampTodosRawEndpoint(client);
            TodoLists = new BasecampTodoListsRawEndpoint(client);
            TodoSets = new BasecampTodoSetsRawEndpoint(client);
        }

    }

}