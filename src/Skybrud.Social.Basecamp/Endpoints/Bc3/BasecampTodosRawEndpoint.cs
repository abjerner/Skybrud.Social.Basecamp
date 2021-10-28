using System;
using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.OAuth;
using Skybrud.Social.Basecamp.Options.Bc3.Todos;

namespace Skybrud.Social.Basecamp.Endpoints.Bc3 {
    
    /// <summary>
    /// Class representing the raw <strong>To-dos</strong> endpoint.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todos.md</cref>
    /// </see>
    public class BasecampTodosRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the parent OAuth client.
        /// </summary>
        public BasecampOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal BasecampTodosRawEndpoint(BasecampOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Returns information about the of the to-do matching the specified <paramref name="accountId"/>, <paramref name="projectId"/> and <paramref name="todoId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the account.</param>
        /// <param name="projectId">The ID of the project.</param>
        /// <param name="todoId">The ID of the to-do.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todos.md#get-a-to-do</cref>
        /// </see>
        public IHttpResponse GetTodo(long accountId, long projectId, long todoId) {
            return GetTodo(new BasecampGetTodoOptions(accountId, projectId, todoId));
        }

        /// <summary>
        /// Returns information about the of the to-do matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todos.md#get-a-to-do</cref>
        /// </see>
        public IHttpResponse GetTodo(BasecampGetTodoOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.GetResponse(options);
        }

        /// <summary>
        /// Returns a list of projects of the account with the specified <paramref name="accountId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the account.</param>
        /// <param name="projectId">The ID of the project.</param>
        /// <param name="todoListId">The ID of the to-do list.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todos.md#get-to-dos</cref>
        /// </see>
        public IHttpResponse GetTodos(long accountId, long projectId, long todoListId) {
            return GetTodos(new BasecampGetTodosOptions(accountId, projectId, todoListId));
        }

        /// <summary>
        /// Returns a list of projects of the account matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todos.md#get-to-dos</cref>
        /// </see>
        public IHttpResponse GetTodos(BasecampGetTodosOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.GetResponse(options);
        }

        #endregion

    }

}