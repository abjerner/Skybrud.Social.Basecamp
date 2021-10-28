using Skybrud.Social.Basecamp.Endpoints.Bc3;

namespace Skybrud.Social.Basecamp.Apis {
   
    /// <summary>
    /// Class representing the implementation of the Basecamp 3 API.
    /// </summary>
    public class BasecampBc3Api {

        /// <summary>
        /// Gets a reference to the <strong>People</strong> endpoint.
        /// </summary>
        public BasecampPeopleEndpoint People { get; }

        /// <summary>
        /// Gets a reference to the <strong>Projects</strong> endpoint.
        /// </summary>
        public BasecampProjectsEndpoint Projects { get; }

        /// <summary>
        /// Gets a reference to the <strong>To-dos</strong> endpoint.
        /// </summary>
        public BasecampTodosEndpoint Todos { get; }

        /// <summary>
        /// Gets a reference to the <strong>To-do lists</strong> endpoint.
        /// </summary>
        public BasecampTodoListsEndpoint TodoLists { get; }

        /// <summary>
        /// Gets a reference to the <strong>To-do sets</strong> endpoint.
        /// </summary>
        public BasecampTodoSetsEndpoint TodoSets { get; }
        
        internal BasecampBc3Api(BasecampHttpService service) {
            People = new BasecampPeopleEndpoint(service);
            Projects = new BasecampProjectsEndpoint(service);
            Todos = new BasecampTodosEndpoint(service);
            TodoLists = new BasecampTodoListsEndpoint(service);
            TodoSets = new BasecampTodoSetsEndpoint(service);
        }

    }

}