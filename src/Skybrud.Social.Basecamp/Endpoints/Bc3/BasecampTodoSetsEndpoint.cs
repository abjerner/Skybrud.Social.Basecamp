using Skybrud.Social.Basecamp.Options.Bc3.TodoSets;
using Skybrud.Social.Basecamp.Responses.Bc3.TodoSets;

namespace Skybrud.Social.Basecamp.Endpoints.Bc3 {

    /// <summary>
    /// Class representing the <strong>To-do sets</strong> endpoint.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todosets.md</cref>
    /// </see>
    public class BasecampTodoSetsEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the parent service.
        /// </summary>
        public BasecampHttpService Service { get; }

        /// <summary>
        /// Gets a reference to the raw <strong>To-do sets</strong> endpoint.
        /// </summary>
        public BasecampTodoSetsRawEndpoint Raw => Service.Client.Bc3.TodoSets;

        #endregion

        #region Constructors

        internal BasecampTodoSetsEndpoint(BasecampHttpService service) {
            Service = service;
        }

        #endregion

        #region Member methods
        
        /// <summary>
        /// Returns information about the of the to-do set matching the specified <paramref name="accountId"/>, <paramref name="projectId"/> and <paramref name="todoSetId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the account.</param>
        /// <param name="projectId">The ID of the project.</param>
        /// <param name="todoSetId">The ID of the to-do set.</param>
        /// <returns>An instance of <see cref="BasecampTodoSetResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todosets.md#get-to-do-set</cref>
        /// </see>
        public BasecampTodoSetResponse GetTodoSet(long accountId, long projectId, long todoSetId) {
            return new BasecampTodoSetResponse(Raw.GetTodoSet(accountId, projectId, todoSetId));
        }

        /// <summary>
        /// Returns information about the of the to-do matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="BasecampTodoSetResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todosets.md#get-to-do-set</cref>
        /// </see>
        public BasecampTodoSetResponse GetTodoSet(BasecampGetTodoSetOptions options) {
            return new BasecampTodoSetResponse(Raw.GetTodoSet(options));
        }

        #endregion

    }

}