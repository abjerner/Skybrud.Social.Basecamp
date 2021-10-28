using System;
using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.OAuth;
using Skybrud.Social.Basecamp.Options.Bc3.TodoLists;

namespace Skybrud.Social.Basecamp.Endpoints.Bc3 {
    
    /// <summary>
    /// Class representing the raw <strong>To-do lists</strong> endpoint.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todolists.md</cref>
    /// </see>
    public class BasecampTodoListsRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the parent OAuth client.
        /// </summary>
        public BasecampOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal BasecampTodoListsRawEndpoint(BasecampOAuthClient client) {
            Client = client;
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
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todolists.md#get-a-to-do-list</cref>
        /// </see>
        public IHttpResponse GetTodoList(long accountId, long projectId, long todoListId) {
            return GetTodoList(new BasecampGetTodoListOptions(accountId, projectId, todoListId));
        }

        /// <summary>
        /// Returns information about the of the to-do list matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todolists.md#get-a-to-do-list</cref>
        /// </see>
        public IHttpResponse GetTodoList(BasecampGetTodoListOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.GetResponse(options);
        }

        /// <summary>
        /// Returns a list of to-do lists matching the specified <paramref name="accountId"/>,
        /// <paramref name="projectId"/> and <paramref name="todoSetId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the account.</param>
        /// <param name="projectId">The ID of the project.</param>
        /// <param name="todoSetId">The ID of the to-do set.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todolists.md#get-to-do-lists</cref>
        /// </see>
        public IHttpResponse GetTodoLists(long accountId, long projectId, long todoSetId) {
            return GetTodoLists(new BasecampGetTodoListsOptions(accountId, projectId, todoSetId));
        }

        /// <summary>
        /// Returns a list of to-do lists matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todolists.md#get-to-do-lists</cref>
        /// </see>
        public IHttpResponse GetTodoLists(BasecampGetTodoListsOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.GetResponse(options);
        }

        #endregion

    }

}