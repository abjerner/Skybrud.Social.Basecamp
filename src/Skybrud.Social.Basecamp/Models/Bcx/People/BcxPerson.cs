using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Basecamp.Models.Bcx.People {

    /// <summary>
    /// Class representing a Basecamp 2 person.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/people.md</cref>
    /// </see>
    public class BcxPerson : BcxPersonItem {

        #region Properties

        /// <summary>
        /// Gets whether the person is the owner of the account.
        /// </summary>
        public bool IsAccountOwner { get; }

        #endregion
        
        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="json"/> object.
        /// </summary>
        /// <param name="json">The JSON object representing the person.</param>
        public BcxPerson(JObject json) : base(json) {
            IsAccountOwner = json.GetBoolean("account_owner");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="BcxPerson"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="BcxPerson"/>.</returns>
        public new static BcxPerson Parse(JObject json) {
            return json == null ? null : new BcxPerson(json);
        }

        #endregion

    }

}