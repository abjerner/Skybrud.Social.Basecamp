using System;
using Skybrud.Essentials.Http;

namespace Skybrud.Social.Basecamp.Options.Bcx.Todolists {
    
    /// <summary>
    /// Options for getting a specific project in a Basecamp 2 account.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/todolists.md#get-to-do-list</cref>
    /// </see>
    public class BcxGetTodolistOptions : BcxRequestOptions {
        
        /// <summary>
        /// Gets or sets the ID of the Basecamp 2 account.
        /// </summary>
        public long AccountId { get; set; }
        
        /// <summary>
        /// Gets or sets the ID of the project.
        /// </summary>
        public long ProjectId { get; set; }
        
        /// <summary>
        /// Gets or sets the ID of the todolist.
        /// </summary>
        public long TodolistId { get; set; }

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public BcxGetTodolistOptions() { }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="accountId"/>, <paramref name="projectId"/> and <paramref name="todolistId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the account.</param>
        /// <param name="projectId">The ID of the project.</param>
        /// <param name="todolistId">The ID of the todolist.</param>
        public BcxGetTodolistOptions(long accountId, long projectId, long todolistId) {
            AccountId = accountId;
            ProjectId = projectId;
            TodolistId = todolistId;
        }

        /// <inheritdoc />
        public override IHttpRequest GetRequest()  {
            if (AccountId == default) throw new ArgumentNullException(nameof(AccountId));
            if (ProjectId == default) throw new ArgumentNullException(nameof(ProjectId));
            if (TodolistId == default) throw new ArgumentNullException(nameof(TodolistId));
            return HttpRequest.Get($"/{AccountId}/api/v1/projects/{ProjectId}/todolists/{TodolistId}.json");
        }

    }

}