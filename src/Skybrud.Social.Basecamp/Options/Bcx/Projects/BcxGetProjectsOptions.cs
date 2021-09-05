using System;
using Skybrud.Essentials.Http;

namespace Skybrud.Social.Basecamp.Options.Bcx.Projects {
    
    /// <summary>
    /// Options for getting a list of active projects in a Basecamp 2 account.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/projects.md#get-projects</cref>
    /// </see>
    public class BcxGetProjectsOptions : BcxRequestOptions {
        
        /// <summary>
        /// Gets or sets the ID of the Basecamp 2 account.
        /// </summary>
        public long AccountId { get; set; }

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public BcxGetProjectsOptions() { }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="accountId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the account.</param>
        public BcxGetProjectsOptions(long accountId) {
            AccountId = accountId;
        }

        /// <inheritdoc />
        public override IHttpRequest GetRequest()  {
            if (AccountId == default) throw new ArgumentNullException(nameof(AccountId));
            return HttpRequest.Get($"/{AccountId}/api/v1/projects.json");
        }

    }

}