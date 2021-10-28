using Skybrud.Social.Basecamp.Options.Bc3.Projects;
using Skybrud.Social.Basecamp.Responses.Bc3.People;
using Skybrud.Social.Basecamp.Responses.Bc3.Projects;

namespace Skybrud.Social.Basecamp.Endpoints.Bc3 {

    /// <summary>
    /// Class representing the <strong>Projects</strong> endpoint.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/projects.md</cref>
    /// </see>
    public class BasecampProjectsEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the parent service.
        /// </summary>
        public BasecampHttpService Service { get; }

        /// <summary>
        /// Gets a reference to the raw <strong>Projects</strong> endpoint.
        /// </summary>
        public BasecampProjectsRawEndpoint Raw => Service.Client.Bc3.Projects;

        #endregion

        #region Constructors

        internal BasecampProjectsEndpoint(BasecampHttpService service) {
            Service = service;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Returns information about the of the project matching the specified <paramref name="accountId"/> and <paramref name="projectId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the account.</param>
        /// <param name="projectId">The ID of the project.</param>
        /// <returns>An instance of <see cref="BasecampProjectResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/projects.md#get-a-project</cref>
        /// </see>
        public BasecampProjectResponse GetProject(long accountId, long projectId) {
            return new BasecampProjectResponse(Raw.GetProject(accountId, projectId));
        }

        /// <summary>
        /// Returns information about the of the project matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="BasecampProjectResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/projects.md#get-a-project</cref>
        /// </see>
        public BasecampProjectResponse GetProject(BasecampGetProjectOptions options) {
            return new BasecampProjectResponse(Raw.GetProject(options));
        }
        
        /// <summary>
        /// Returns a list of projects of the account with the specified <paramref name="accountId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the Basecamp account.</param>
        /// <returns>An instance of <see cref="BasecampPersonResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/projects.md#get-projects</cref>
        /// </see>
        public BasecampProjectListResponse GetProjects(long accountId) {
            return new BasecampProjectListResponse(Raw.GetProjects(accountId));
        }
        
        /// <summary>
        /// Returns a list of projects of the account matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="BasecampPersonResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/projects.md#get-projects</cref>
        /// </see>
        public BasecampProjectListResponse GetProjects(BasecampGetProjectsOptions options) {
            return new BasecampProjectListResponse(Raw.GetProjects(options));
        }

        #endregion

    }

}