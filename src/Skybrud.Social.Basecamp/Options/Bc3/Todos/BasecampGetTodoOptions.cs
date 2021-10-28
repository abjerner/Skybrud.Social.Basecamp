using System;
using Skybrud.Essentials.Http;

namespace Skybrud.Social.Basecamp.Options.Bc3.Todos {
    
    /// <summary>
    /// Options for getting information about a Basecamp 3 to-do.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todos.md#get-a-to-do</cref>
    /// </see>
    public class BasecampGetTodoOptions : BasecampBc3RequestOptions {

        #region Properties
        
        /// <summary>
        /// Gets or sets the ID of the Basecamp 3 account.
        /// </summary>
        public long AccountId { get; set; }
        
        /// <summary>
        /// Gets or sets the ID of the project.
        /// </summary>
        public long ProjectId { get; set; }
        
        /// <summary>
        /// Gets or sets the ID of the to-do.
        /// </summary>
        public long TodoId { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public BasecampGetTodoOptions() { }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="accountId"/>, <paramref name="projectId"/> and <paramref name="todoId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the account.</param>
        /// <param name="projectId">The ID of the project.</param>
        /// <param name="todoId">The ID of the to-do.</param>
        public BasecampGetTodoOptions(long accountId, long projectId, long todoId) {
            AccountId = accountId;
            ProjectId = projectId;
            TodoId = todoId;
        }

        #endregion

        #region Member methods

        /// <inheritdoc />
        public override IHttpRequest GetRequest()  {
            if (AccountId == default) throw new ArgumentNullException(nameof(AccountId));
            if (ProjectId == default) throw new ArgumentNullException(nameof(ProjectId));
            if (TodoId == default) throw new ArgumentNullException(nameof(TodoId));
            return HttpRequest.Get($"/{AccountId}/buckets/{ProjectId}/todos/{TodoId}.json");
        }

        #endregion

    }

}