using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Basecamp.Models.Bcx.Projects {

    /// <summary>
    /// Class representing a Basecamp 2 person.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/projects.md</cref>
    /// </see>
    public class BcxProject : BcxProjectItem {
        
        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="json"/> object.
        /// </summary>
        /// <param name="json">The JSON object representing the project.</param>
        public BcxProject(JObject json) : base(json) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="BcxProject"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="BcxProject"/>.</returns>
        public new static BcxProject Parse(JObject json) {
            return json == null ? null : new BcxProject(json);
        }

        #endregion

    }

}