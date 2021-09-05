using System;
using Skybrud.Essentials.Http;

namespace Skybrud.Social.Basecamp.Options.Bcx.People {
    
    /// <summary>
    /// Options for getting the profile of the authenticated Basecamp 2 user.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/people.md#get-person</cref>
    /// </see>
    public class BasecampGetProfileOptions : BasecampBcxRequestOptions {
        
        /// <summary>
        /// Gets or sets the ID of the Basecamp 2 account.
        /// </summary>
        public long AccountId { get; set; }

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public BasecampGetProfileOptions() { }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="accountId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the account.</param>
        public BasecampGetProfileOptions(long accountId) {
            AccountId = accountId;
        }

        /// <inheritdoc />
        public override IHttpRequest GetRequest()  {
            if (AccountId == default) throw new ArgumentNullException(nameof(AccountId));
            return HttpRequest.Get($"/{AccountId}/api/v1/people/me.json");
        }

    }

}