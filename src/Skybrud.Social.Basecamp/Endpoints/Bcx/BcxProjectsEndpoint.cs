using Skybrud.Social.Basecamp.Options.Bcx.Projects;
using Skybrud.Social.Basecamp.Responses.Bcx.Projects;

namespace Skybrud.Social.Basecamp.Endpoints.Bcx {

    /// <summary>
    /// Class representing the <strong>Projects</strong> endpoint.
    /// </summary>
    public class BcxProjectsEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the parent service.
        /// </summary>
        public BasecampService Service { get; }

        /// <summary>
        /// Gets a reference to the raw <strong>Projects</strong> endpoint.
        /// </summary>
        public BcxProjectsRawEndpoint Raw => Service.Client.Bcx.Projects;

        #endregion

        #region Constructors

        internal BcxProjectsEndpoint(BasecampService service) {
            Service = service;
        }

        #endregion

        #region Member methods
        
        /// <summary>
        /// Returns information about the project with the specified <paramref name="projectId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the Basecamp 2 account.</param>
        /// <param name="projectId">The ID of the project.</param>
        /// <returns>An instance of <see cref="BcxProjectResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/projects.md#get-project</cref>
        /// </see>
        public BcxProjectResponse GetProject(long accountId, long projectId) {
            return new BcxProjectResponse(Raw.GetProject(accountId, projectId));
        }

        /// <summary>
        /// Returns a list of all active projects on the account.
        /// </summary>
        /// <param name="accountId">The ID of the Basecamp 2 account.</param>
        /// <returns>An instance of <see cref="BcxProjectListResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/projects.md#get-projects</cref>
        /// </see>
        public BcxProjectListResponse GetActiveProjects(long accountId) {
            return new BcxProjectListResponse(Raw.GetActiveProjects(accountId));
        }

        /// <summary>
        /// Returns a list of all projects on the account matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="BcxProjectListResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/projects.md#get-projects</cref>
        /// </see>
        public BcxProjectListResponse GetProjects(BcxGetProjectsOptions options) {
            return new BcxProjectListResponse(Raw.GetProjects(options));
        }

        #endregion

    }

}