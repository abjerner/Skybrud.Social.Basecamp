using System;
using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.OAuth;
using Skybrud.Social.Basecamp.Options.Bc3.Projects;

namespace Skybrud.Social.Basecamp.Endpoints.Bc3 {
    
    /// <summary>
    /// Class representing the raw <strong>Projects</strong> endpoint.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/projects.md</cref>
    /// </see>
    public class BasecampProjectsRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the parent OAuth client.
        /// </summary>
        public BasecampOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal BasecampProjectsRawEndpoint(BasecampOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Returns information about the of the project matching the specified <paramref name="accountId"/> and <paramref name="projectId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the account.</param>
        /// <param name="projectId">The ID of the project.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/projects.md#get-a-project</cref>
        /// </see>
        public IHttpResponse GetProject(long accountId, long projectId) {
            return GetProject(new BasecampGetProjectOptions(accountId, projectId));
        }

        /// <summary>
        /// Returns information about the of the project matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/projects.md#get-a-project</cref>
        /// </see>
        public IHttpResponse GetProject(BasecampGetProjectOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.GetResponse(options);
        }

        /// <summary>
        /// Returns a list of projects of the account with the specified <paramref name="accountId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the Basecamp account.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/projects.md#get-projects</cref>
        /// </see>
        public IHttpResponse GetProjects(long accountId) {
            return GetProjects(new BasecampGetProjectsOptions(accountId));
        }

        /// <summary>
        /// Returns a list of projects of the account matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/projects.md#get-projects</cref>
        /// </see>
        public IHttpResponse GetProjects(BasecampGetProjectsOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.GetResponse(options);
        }

        #endregion

    }

}