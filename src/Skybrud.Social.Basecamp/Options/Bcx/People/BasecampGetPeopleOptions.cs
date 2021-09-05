using System;
using Skybrud.Essentials.Http;

namespace Skybrud.Social.Basecamp.Options.Bcx.People {
    
    /// <summary>
    /// Options for getting a list of people in a Basecamp 2 account.
    /// </summary>
    public class BasecampGetPeopleOptions : BasecampBcxRequestOptions {
        
        /// <summary>
        /// Gets or sets the ID of the Basecamp 2 account.
        /// </summary>
        public int AccountId { get; set; }

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public BasecampGetPeopleOptions() { }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="accountId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the account.</param>
        public BasecampGetPeopleOptions(int accountId) {
            AccountId = accountId;
        }

        /// <inheritdoc />
        public override IHttpRequest GetRequest()  {
            if (AccountId == default) throw new ArgumentNullException(nameof(AccountId));
            return HttpRequest.Get($"/{AccountId}/api/v1/people.json");
        }

    }

}