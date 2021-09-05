using System;
using Skybrud.Essentials.Http;

namespace Skybrud.Social.Basecamp.Options.Bcx.People {
    
    /// <summary>
    /// Options for getting a specific person in a Basecamp 2 account.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/people.md#get-person</cref>
    /// </see>
    public class BcxGetPersonOptions : BcxRequestOptions {
        
        /// <summary>
        /// Gets or sets the ID of the Basecamp 2 account.
        /// </summary>
        public long AccountId { get; set; }
        
        /// <summary>
        /// Gets or sets the ID of the person.
        /// </summary>
        public long PersonId { get; set; }

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public BcxGetPersonOptions() { }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="accountId"/> and <paramref name="personId"/>.
        /// </summary>
        /// <param name="accountId">The ID of the account.</param>
        /// <param name="personId">The ID of the person.</param>
        public BcxGetPersonOptions(long accountId, long personId) {
            AccountId = accountId;
            PersonId = personId;
        }

        /// <inheritdoc />
        public override IHttpRequest GetRequest()  {
            if (AccountId == default) throw new ArgumentNullException(nameof(AccountId));
            if (PersonId == default) throw new ArgumentNullException(nameof(PersonId));
            return HttpRequest.Get($"/{AccountId}/api/v1/people/{PersonId}.json");
        }

    }

}