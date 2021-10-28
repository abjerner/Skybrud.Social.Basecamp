using System;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Collections;
using Skybrud.Essentials.Strings.Extensions;

namespace Skybrud.Social.Basecamp.Options.Bc3.Projects {
    
    /// <summary>
    /// Options for getting list of Basecamp 3 projects.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/projects.md#get-projects</cref>
    /// </see>
    public class BasecampGetProjectsOptions : BasecampBc3RequestOptions {

        #region Properties
        
        /// <summary>
        /// Gets or sets the ID of the Basecamp 3 account.
        /// </summary>
        public long AccountId { get; set; }

        /// <summary>
        /// Gets or sets the status the returned projects should match.
        /// </summary>
        public BasecampProjectStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the page to be returned. If set to <c>0</c>, the <c>page</c> parameter is omitted in the
        /// request to the API.
        /// </summary>
        public int Page { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public BasecampGetProjectsOptions() { }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="accountId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the account.</param>
        public BasecampGetProjectsOptions(long accountId) {
            AccountId = accountId;
        }

        #endregion

        #region Member methods

        /// <inheritdoc />
        public override IHttpRequest GetRequest()  {
            
            // Validate required properties
            if (AccountId == default) throw new ArgumentNullException(nameof(AccountId));

            // Initialize the query string
            IHttpQueryString query = new HttpQueryString();
            if (Status > 0) query.Add("status", Status.ToLower());
            if (Page > 0) query.Add("page", Page);
            
            // Initialize a new GET request
            return HttpRequest.Get($"/{AccountId}/projects.json", query);

        }

        #endregion

    }

}