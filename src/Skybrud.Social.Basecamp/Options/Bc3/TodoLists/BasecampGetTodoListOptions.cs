using System;
using Skybrud.Essentials.Http;

namespace Skybrud.Social.Basecamp.Options.Bc3.TodoLists {
    
    /// <summary>
    /// Options for getting information about a Basecamp 3 to-do list.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todolists.md#get-a-to-do-list</cref>
    /// </see>
    public class BasecampGetTodoListOptions : BasecampBc3RequestOptions {

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
        /// Gets or sets the ID of the to-do list.
        /// </summary>
        public long TodoListId { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public BasecampGetTodoListOptions() { }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="accountId"/>, <paramref name="projectId"/> and <paramref name="todoListId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the account.</param>
        /// <param name="projectId">The ID of the project.</param>
        /// <param name="todoListId">The ID of the to-do list.</param>
        public BasecampGetTodoListOptions(long accountId, long projectId, long todoListId) {
            AccountId = accountId;
            ProjectId = projectId;
            TodoListId = todoListId;
        }

        #endregion

        #region Member methods

        /// <inheritdoc />
        public override IHttpRequest GetRequest()  {
            if (AccountId == default) throw new ArgumentNullException(nameof(AccountId));
            if (ProjectId == default) throw new ArgumentNullException(nameof(ProjectId));
            if (TodoListId == default) throw new ArgumentNullException(nameof(TodoListId));
            return HttpRequest.Get($"/{AccountId}/buckets/{ProjectId}/todolists/{TodoListId}.json");
        }

        #endregion

    }

}