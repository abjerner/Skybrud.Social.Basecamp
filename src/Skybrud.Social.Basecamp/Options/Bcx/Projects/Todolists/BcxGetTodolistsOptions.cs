using System;
using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.Models.Bcx.Todolists;

namespace Skybrud.Social.Basecamp.Options.Bcx.Projects.Todolists {
    
    /// <summary>
    /// Options for getting the todolists of a Basecamp 2 project.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/todolists.md#get-to-do-lists</cref>
    /// </see>
    public class BcxGetTodolistsOptions : BcxRequestOptions {
        
        /// <summary>
        /// Gets or sets the ID of the Basecamp 2 account.
        /// </summary>
        public long AccountId { get; set; }
        
        /// <summary>
        /// Gets or sets the ID of the project.
        /// </summary>
        public long ProjectId { get; set; }

        /// <summary>
        /// Gets or sets the state the returned todolists should match.
        /// </summary>
        public BcxTodolistsState State { get; set; }

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public BcxGetTodolistsOptions() { }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="accountId"/> and <paramref name="projectId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the account.</param>
        /// <param name="projectId">The ID of the project.</param>
        public BcxGetTodolistsOptions(long accountId, long projectId) {
            AccountId = accountId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="accountId"/> and <paramref name="projectId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the account.</param>
        /// <param name="projectId">The ID of the project.</param>
        /// <param name="state">The state of the todolists to be returned.</param>
        public BcxGetTodolistsOptions(long accountId, long projectId, BcxTodolistsState state) {
            AccountId = accountId;
            ProjectId = projectId;
            State = state;
        }

        /// <inheritdoc />
        public override IHttpRequest GetRequest()  {
            
            if (AccountId == default) throw new ArgumentNullException(nameof(AccountId));
            if (ProjectId == default) throw new ArgumentNullException(nameof(ProjectId));

            switch (State) {

                case BcxTodolistsState.Active:
                    return HttpRequest.Get($"/{AccountId}/api/v1/projects/{ProjectId}/todolists.json");

                case BcxTodolistsState.Completed:
                    return HttpRequest.Get($"/{AccountId}/api/v1/projects/{ProjectId}/todolists/completed.json");

                case BcxTodolistsState.Trashed:
                    return HttpRequest.Get($"/{AccountId}/api/v1/projects/{ProjectId}/todolists/trashed.json");

                default:
                    throw new Exception($"Unsupported state {State}");
                
            }

        }

    }

}