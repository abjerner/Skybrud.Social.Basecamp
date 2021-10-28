using System;
using Skybrud.Essentials.Http;

namespace Skybrud.Social.Basecamp.Options.Bc3.TodoSets {
    
    /// <summary>
    /// Options for getting information about a Basecamp 3 to-do set.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todosets.md#get-to-do-set</cref>
    /// </see>
    public class BasecampGetTodoSetOptions : BasecampBc3RequestOptions {

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

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public BasecampGetTodoSetOptions() { }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="accountId"/>, <paramref name="projectId"/> and <paramref name="todoSetId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the account.</param>
        /// <param name="projectId">The ID of the project.</param>
        /// <param name="todoSetId">The ID of the to-do set.</param>
        public BasecampGetTodoSetOptions(long accountId, long projectId, long todoSetId) {
            AccountId = accountId;
            ProjectId = projectId;
            TodoSetId = todoSetId;
        }

        #endregion

        #region Member methods

        /// <inheritdoc />
        public override IHttpRequest GetRequest()  {
            if (AccountId == default) throw new ArgumentNullException(nameof(AccountId));
            if (ProjectId == default) throw new ArgumentNullException(nameof(ProjectId));
            if (TodoSetId == default) throw new ArgumentNullException(nameof(TodoSetId));
            return HttpRequest.Get($"/{AccountId}/buckets/{ProjectId}/todosets/{TodoSetId}.json");
        }

        #endregion

    }

}