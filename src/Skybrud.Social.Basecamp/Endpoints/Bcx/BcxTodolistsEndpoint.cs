using Skybrud.Social.Basecamp.Responses.Bcx.Todolists;

namespace Skybrud.Social.Basecamp.Endpoints.Bcx {

    /// <summary>
    /// Class representing the <strong>Todolists</strong> endpoint.
    /// </summary>
    public class BcxTodolistsEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the parent service.
        /// </summary>
        public BasecampService Service { get; }

        /// <summary>
        /// Gets a reference to the raw <strong>Todolists</strong> endpoint.
        /// </summary>
        public BcxTodolistsRawEndpoint Raw => Service.Client.Bcx.Todolists;

        #endregion

        #region Constructors

        internal BcxTodolistsEndpoint(BasecampService service) {
            Service = service;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Returns information about the todolist matching the specified <paramref name="accountId"/>, <paramref name="projectId"/> and <paramref name="todolistId"/>.
        /// </summary>
        /// <param name="accountId">The Id of the Basecamp 2 account.</param>
        /// <param name="projectId">The ID of the project.</param>
        /// <param name="todolistId">The ID of the todolist.</param>
        /// <returns>An instance of <see cref="BcxTodolistListResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/todolists.md#get-to-do-lists</cref>
        /// </see>
        public BcxTodolistResponse GetTodolist(long accountId, long projectId, long todolistId) {
            return new BcxTodolistResponse(Raw.GetTodolist(accountId, projectId, todolistId));
        }
        
        #endregion

    }

}