using System;
using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.OAuth;
using Skybrud.Social.Basecamp.Options.Bcx.Projects;

namespace Skybrud.Social.Basecamp.Endpoints.Bcx {

    /// <summary>
    /// Class representing the raw <strong>Projects</strong> endpoint.
    /// </summary>
    public class BcxProjectsRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the parent OAuth client.
        /// </summary>
        public BasecampOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal BcxProjectsRawEndpoint(BasecampOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Member methods
        
        /// <summary>
        /// Returns information about the project with the specified <paramref name="projectId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the Basecamp 2 account.</param>
        /// <param name="projectId">The ID of the project.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/projects.md#get-project</cref>
        /// </see>
        public IHttpResponse GetProject(long accountId, long projectId) {
            return Client.GetResponse(new BcxGetProjectOptions(accountId, projectId));
        }
        
        /// <summary>
        /// Returns a list of all active projects on the account.
        /// </summary>
        /// <param name="accountId">The ID of the Basecamp 2 account.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/projects.md#get-projects</cref>
        /// </see>
        public IHttpResponse GetActiveProjects(long accountId) {
            return Client.GetResponse(new BcxGetProjectsOptions(accountId));
        }
        
        /// <summary>
        /// Returns a list of all projects on the account matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/projects.md#get-projects</cref>
        /// </see>
        public IHttpResponse GetProjects(BcxGetProjectsOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.GetResponse(options);
        }

        #endregion

    }

}