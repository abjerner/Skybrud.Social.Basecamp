using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Basecamp.Models.Bcx.People {
    
    /// <summary>
    /// Class representing a reference to Basecamp 2 person.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/people.md</cref>
    /// </see>
    public class BcxPersonReference : JsonObjectBase {

        #region Properties

        /// <summary>
        /// Gets the ID of the person.
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// Gets the name of the person.
        /// </summary>
        public string Name { get; }
        
        /// <summary>
        /// Gets the API URL of the person.
        /// </summary>
        public string Url { get; }
        
        /// <summary>
        /// Gets the app URL of the person.
        /// </summary>
        public string AppUrl { get; }
        
        #endregion

        #region Constructors
        
        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="json"/> object.
        /// </summary>
        /// <param name="json">The JSON object representing the person.</param>
        protected BcxPersonReference(JObject json) : base(json)  {
            Id = json.GetInt64("id");
            Name = json.GetString("name");
            Url = json.GetString("url");
            AppUrl = json.GetString("app_url");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="BcxPersonReference"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="BcxPersonReference"/>.</returns>
        public static BcxPersonReference Parse(JObject json) {
            return json == null ? null : new BcxPersonReference(json);
        }

        #endregion

    }

}