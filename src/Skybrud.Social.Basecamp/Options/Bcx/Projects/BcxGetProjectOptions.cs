using System;
using Skybrud.Essentials.Http;

namespace Skybrud.Social.Basecamp.Options.Bcx.Projects {
    
    /// <summary>
    /// Options for getting a specific project in a Basecamp 2 account.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/projects.md#get-project</cref>
    /// </see>
    public class BcxGetProjectOptions : BcxRequestOptions {
        
        /// <summary>
        /// Gets or sets the ID of the Basecamp 2 account.
        /// </summary>
        public long AccountId { get; set; }
        
        /// <summary>
        /// Gets or sets the ID of the project.
        /// </summary>
        public long ProjectId { get; set; }

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public BcxGetProjectOptions() { }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="accountId"/> and <paramref name="projectId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the account.</param>
        /// <param name="projectId">The ID of the project.</param>
        public BcxGetProjectOptions(long accountId, long projectId) {
            AccountId = accountId;
            ProjectId = projectId;
        }

        /// <inheritdoc />
        public override IHttpRequest GetRequest()  {
            if (AccountId == default) throw new ArgumentNullException(nameof(AccountId));
            if (ProjectId == default) throw new ArgumentNullException(nameof(ProjectId));
            return HttpRequest.Get($"/{AccountId}/api/v1/projects/{ProjectId}.json");
        }

    }

}