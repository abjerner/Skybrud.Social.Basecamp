using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.OAuth;
using Skybrud.Social.Basecamp.Options.Bcx.Todolists;

namespace Skybrud.Social.Basecamp.Endpoints.Bcx {

    /// <summary>
    /// Class representing the raw <strong>Todolists</strong> endpoint.
    /// </summary>
    public class BcxTodolistsRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the parent OAuth client.
        /// </summary>
        public BasecampOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal BcxTodolistsRawEndpoint(BasecampOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Returns information about the todolist matching the specified <paramref name="accountId"/>, <paramref name="projectId"/> and <paramref name="todolistId"/>.
        /// </summary>
        /// <param name="accountId">The Id of the Basecamp 2 account.</param>
        /// <param name="projectId">The ID of the project.</param>
        /// <param name="todolistId">The ID of the todolist.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/todolists.md#get-to-do-lists</cref>
        /// </see>
        public IHttpResponse GetTodolist(long accountId, long projectId, long todolistId) {
            return Client.GetResponse(new BcxGetTodolistOptions(accountId, projectId, todolistId));
        }

        #endregion

    }

}