using Skybrud.Social.Basecamp.Options.Bc3.Todos;
using Skybrud.Social.Basecamp.Responses.Bc3.Todos;

namespace Skybrud.Social.Basecamp.Endpoints.Bc3 {

    /// <summary>
    /// Class representing the <strong>To-dos</strong> endpoint.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todos.md</cref>
    /// </see>
    public class BasecampTodosEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the parent service.
        /// </summary>
        public BasecampHttpService Service { get; }

        /// <summary>
        /// Gets a reference to the raw <strong>To-dos</strong> endpoint.
        /// </summary>
        public BasecampTodosRawEndpoint Raw => Service.Client.Bc3.Todos;

        #endregion

        #region Constructors

        internal BasecampTodosEndpoint(BasecampHttpService service) {
            Service = service;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Returns information about the of the to-do matching the specified <paramref name="accountId"/>, <paramref name="projectId"/> and <paramref name="todoId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the account.</param>
        /// <param name="projectId">The ID of the project.</param>
        /// <param name="todoId">The ID of the to-do.</param>
        /// <returns>An instance of <see cref="BasecampTodoResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todos.md#get-a-to-do</cref>
        /// </see>
        public BasecampTodoResponse GetTodo(long accountId, long projectId, long todoId) {
            return new BasecampTodoResponse(Raw.GetTodo(accountId, projectId, todoId));
        }

        /// <summary>
        /// Returns information about the of the to-do matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="BasecampTodoResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todos.md#get-a-to-do</cref>
        /// </see>
        public BasecampTodoResponse GetTodo(BasecampGetTodoOptions options) {
            return new BasecampTodoResponse(Raw.GetTodo(options));
        }

        /// <summary>
        /// Returns a list of projects of the account with the specified <paramref name="accountId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the account.</param>
        /// <param name="projectId">The ID of the project.</param>
        /// <param name="todoListId">The ID of the to-do list.</param>
        /// <returns>An instance of <see cref="BasecampTodoListResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todos.md#get-to-dos</cref>
        /// </see>
        public BasecampTodoListResponse GetTodos(long accountId, long projectId, long todoListId) {
            return new BasecampTodoListResponse(Raw.GetTodos(accountId, projectId, todoListId));
        }

        /// <summary>
        /// Returns a list of projects of the account matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="BasecampTodoListResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todos.md#get-to-dos</cref>
        /// </see>
        public BasecampTodoListResponse GetTodos(BasecampGetTodosOptions options) {
            return new BasecampTodoListResponse(Raw.GetTodos(options));
        }

        #endregion

    }

}