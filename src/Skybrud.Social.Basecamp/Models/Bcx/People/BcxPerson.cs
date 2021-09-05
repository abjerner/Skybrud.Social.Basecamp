using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;

namespace Skybrud.Social.Basecamp.Models.Bcx.People {

    /// <summary>
    /// Class representing a Basecamp 2 person.
    /// </summary>
    public class BcxPerson : BcxPersonItem {
        
        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="json"/> object.
        /// </summary>
        /// <param name="json">The JSON object representing the person.</param>
        public BcxPerson(JObject json) : base(json) { }

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