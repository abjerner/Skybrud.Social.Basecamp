using System;
using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.OAuth;
using Skybrud.Social.Basecamp.Options.Bc3.Todos;
using Skybrud.Social.Basecamp.Options.Bc3.TodoSets;

namespace Skybrud.Social.Basecamp.Endpoints.Bc3 {
    
    /// <summary>
    /// Class representing the raw <strong>To-dos</strong> endpoint.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todosets.md</cref>
    /// </see>
    public class BasecampTodoSetsRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the parent OAuth client.
        /// </summary>
        public BasecampOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal BasecampTodoSetsRawEndpoint(BasecampOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Returns information about the of the to-do set matching the specified <paramref name="accountId"/>, <paramref name="projectId"/> and <paramref name="todoSetId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the account.</param>
        /// <param name="projectId">The ID of the project.</param>
        /// <param name="todoSetId">The ID of the to-do set.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todosets.md#get-to-do-set</cref>
        /// </see>
        public IHttpResponse GetTodoSet(long accountId, long projectId, long todoSetId) {
            return GetTodoSet(new BasecampGetTodoSetOptions(accountId, projectId, todoSetId));
        }

        /// <summary>
        /// Returns information about the of the to-do matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todosets.md#get-to-do-set</cref>
        /// </see>
        public IHttpResponse GetTodoSet(BasecampGetTodoSetOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.GetResponse(options);
        }
        
        #endregion

    }

}