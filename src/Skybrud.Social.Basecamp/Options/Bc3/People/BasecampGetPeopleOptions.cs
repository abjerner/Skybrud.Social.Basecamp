using System;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Collections;

namespace Skybrud.Social.Basecamp.Options.Bc3.People {
    
    /// <summary>
    /// Options for getting a list of people in a Basecamp 2 account.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/people.md#get-all-people</cref>
    /// </see>
    public class BasecampGetPeopleOptions : BasecampBc3RequestOptions {
        
        /// <summary>
        /// Gets or sets the ID of the Basecamp 2 account.
        /// </summary>
        public long AccountId { get; set; }

        /// <summary>
        /// Gets or sets the page to be returned.
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public BasecampGetPeopleOptions() { }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="accountId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the account.</param>
        public BasecampGetPeopleOptions(long accountId) {
            AccountId = accountId;
        }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="accountId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the account.</param>
        /// <param name="page">The page to be returned.</param>
        public BasecampGetPeopleOptions(long accountId, int page) {
            AccountId = accountId;
            Page = page;
        }

        /// <inheritdoc />
        public override IHttpRequest GetRequest()  {
            
            if (AccountId == default) throw new ArgumentNullException(nameof(AccountId));

            IHttpQueryString query = new HttpQueryString();
            if (Page > 0) query.Add("page", Page);
            
            return HttpRequest.Get($"/{AccountId}/people.json", query);

        }

    }

}