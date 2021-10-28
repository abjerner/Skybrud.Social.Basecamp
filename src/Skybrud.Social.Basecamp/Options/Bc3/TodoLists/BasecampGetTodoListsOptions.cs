using System;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Collections;
using Skybrud.Essentials.Strings.Extensions;

namespace Skybrud.Social.Basecamp.Options.Bc3.TodoLists {
    
    /// <summary>
    /// Options for getting to-do lists of a Basecamp 3 to-do set.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todolists.md#get-to-do-lists</cref>
    /// </see>
    public class BasecampGetTodoListsOptions : BasecampBc3RequestOptions {

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
        /// Gets or sets the ID of the to-do set.
        /// </summary>
        public long TodoSetId { get; set; }

        /// <summary>
        /// Gets or sets the status the returned to-do lists should match.
        /// </summary>
        public BasecampTodoListStatus Status { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public BasecampGetTodoListsOptions() { }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="accountId"/>, <paramref name="projectId"/> and <paramref name="todoSetId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the account.</param>
        /// <param name="projectId">The ID of the project.</param>
        /// <param name="todoSetId">The ID of the to-do set.</param>
        public BasecampGetTodoListsOptions(long accountId, long projectId, long todoSetId) {
            AccountId = accountId;
            ProjectId = projectId;
            TodoSetId = todoSetId;
        }

        #endregion

        #region Member methods

        /// <inheritdoc />
        public override IHttpRequest GetRequest()  {
            
            // Validate required properties
            if (AccountId == default) throw new ArgumentNullException(nameof(AccountId));
            if (ProjectId == default) throw new ArgumentNullException(nameof(ProjectId));
            if (TodoSetId == default) throw new ArgumentNullException(nameof(TodoSetId));

            // Initialize the query string
            IHttpQueryString query = new HttpQueryString();
            if (Status > 0) query.Add("status", Status.ToLower());
            
            // Initialize a new GET request
            return HttpRequest.Get($"/{AccountId}/buckets/{ProjectId}/todosets/{TodoSetId}/todolists.json", query);

        }

        #endregion

    }

}