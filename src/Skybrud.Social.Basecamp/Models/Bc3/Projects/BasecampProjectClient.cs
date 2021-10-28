using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Basecamp.Models.Bc3.Projects {
    
    /// <summary>
    /// Class representing a Basecamp 3 client reference.
    /// </summary>
    public class BasecampProjectClient : BasecampObject {

        #region Properties
        
        /// <summary>
        /// Gets the ID of the client.
        /// </summary>
        public long Id { get; }
        
        /// <summary>
        /// Gets the name of the client.
        /// </summary>
        public string Name { get; }

        #endregion

        #region Constructors

        private BasecampProjectClient(JObject json) : base(json)  {
            Id = json.GetInt64("id");
            Name = json.GetString("name");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="BasecampProjectClient"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="BasecampProjectClient"/>.</returns>
        public static BasecampProjectClient Parse(JObject json) {
            return json == null ? null : new BasecampProjectClient(json);
        }

        #endregion

    }

}