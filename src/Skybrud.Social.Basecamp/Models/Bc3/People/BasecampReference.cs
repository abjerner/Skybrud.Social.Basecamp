using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Basecamp.Models.Bc3.People {
    
    /// <summary>
    /// Class representing a reference to another Basecamp resource.
    /// </summary>
    public class BasecampReference : JsonObjectBase {

        #region Properties

        /// <summary>
        /// Gets the ID of the referenced resource.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Gets the name of the referenced resource.
        /// </summary>
        public string Name { get; }

        #endregion

        #region Constructors

        private BasecampReference(JObject json) : base(json)  {
            Id = json.GetInt32("id");
            Name = json.GetString("name");
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="BasecampReference"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="BasecampReference"/>.</returns>
        public static BasecampReference Parse(JObject json) {
            return json == null ? null : new BasecampReference(json);
        }

        #endregion

    }

}