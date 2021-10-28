using System;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Collections;
using Skybrud.Essentials.Strings.Extensions;

namespace Skybrud.Social.Basecamp.Options.Bc3.Todos {
    
    /// <summary>
    /// Options for getting to-dos of a Basecamp 3 to-do list.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todos.md#get-to-dos</cref>
    /// </see>
    public class BasecampGetTodosOptions : BasecampBc3RequestOptions {

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
        public long TodoListId { get; set; }

        /// <summary>
        /// Gets or sets the status the returned to-dos should match.
        /// </summary>
        public BasecampTodoStatus Status { get; set; }

        /// <summary>
        /// Gets or sets wether only completed to-dos should be returned.
        /// </summary>
        public bool Completed { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public BasecampGetTodosOptions() { }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="accountId"/>, <paramref name="projectId"/> and <paramref name="todoListId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the account.</param>
        /// <param name="projectId">The ID of the project.</param>
        /// <param name="todoListId">The ID of the to-do list.</param>
        public BasecampGetTodosOptions(long accountId, long projectId, long todoListId) {
            AccountId = accountId;
            ProjectId = projectId;
            TodoListId = todoListId;
        }

        #endregion

        #region Member methods

        /// <inheritdoc />
        public override IHttpRequest GetRequest()  {
            
            // Validate required properties
            if (AccountId == default) throw new ArgumentNullException(nameof(AccountId));
            if (ProjectId == default) throw new ArgumentNullException(nameof(ProjectId));
            if (TodoListId == default) throw new ArgumentNullException(nameof(TodoListId));

            // Initialize the query string
            IHttpQueryString query = new HttpQueryString();
            if (Status > 0) query.Add("status", Status.ToLower());
            if (Completed) query.Add("completed", "true");
            
            // Initialize a new GET request
            return HttpRequest.Get($"/{AccountId}/buckets/{ProjectId}/todolists/{TodoListId}/todos.json", query);

        }

        #endregion

    }

}