using Skybrud.Social.Basecamp.Options.Bc3.TodoLists;
using Skybrud.Social.Basecamp.Responses.Bc3.TodoLists;

namespace Skybrud.Social.Basecamp.Endpoints.Bc3 {

    /// <summary>
    /// Class representing the <strong>To-do lists</strong> endpoint.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todolists.md</cref>
    /// </see>
    public class BasecampTodoListsEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the parent service.
        /// </summary>
        public BasecampHttpService Service { get; }

        /// <summary>
        /// Gets a reference to the raw <strong>To-dos</strong> endpoint.
        /// </summary>
        public BasecampTodoListsRawEndpoint Raw => Service.Client.Bc3.TodoLists;

        #endregion

        #region Constructors

        internal BasecampTodoListsEndpoint(BasecampHttpService service) {
            Service = service;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Returns information about the of the to-do list matching the specified <paramref name="accountId"/>,
        /// <paramref name="projectId"/> and <paramref name="todoListId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the account.</param>
        /// <param name="projectId">The ID of the project.</param>
        /// <param name="todoListId">The ID of the to-do list.</param>
        /// <returns>An instance of <see cref="BasecampTodoListResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todolists.md#get-a-to-do-list</cref>
        /// </see>
        public BasecampTodoListResponse GetTodoList(long accountId, long projectId, long todoListId) {
            return new BasecampTodoListResponse(Raw.GetTodoList(accountId, projectId, todoListId));
        }

        /// <summary>
        /// Returns information about the of the to-do list matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="BasecampTodoListResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todolists.md#get-a-to-do-list</cref>
        /// </see>
        public BasecampTodoListResponse GetTodoList(BasecampGetTodoListOptions options) {
            return new BasecampTodoListResponse(Raw.GetTodoList(options));
        }

        /// <summary>
        /// Returns a list of to-do lists matching the specified <paramref name="accountId"/>,
        /// <paramref name="projectId"/> and <paramref name="todoSetId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the account.</param>
        /// <param name="projectId">The ID of the project.</param>
        /// <param name="todoSetId">The ID of the to-do set.</param>
        /// <returns>An instance of <see cref="BasecampTodoListListResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todolists.md#get-to-do-lists</cref>
        /// </see>
        public BasecampTodoListListResponse GetTodoLists(long accountId, long projectId, long todoSetId) {
            return new BasecampTodoListListResponse(Raw.GetTodoLists(accountId, projectId, todoSetId));
        }

        /// <summary>
        /// Returns a list of to-do lists matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="BasecampTodoListListResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todolists.md#get-to-do-lists</cref>
        /// </see>
        public BasecampTodoListListResponse GetTodoLists(BasecampGetTodoListsOptions options) {
            return new BasecampTodoListListResponse(Raw.GetTodoLists(options));
        }

        #endregion

    }

}