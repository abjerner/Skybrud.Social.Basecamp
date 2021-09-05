using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json;

namespace Skybrud.Social.Basecamp.Models {

    /// <summary>
    /// Class representing a basic object from the Basecamp API derived from an instance of <see cref="JObject"/>.
    /// </summary>
    public class BasecampObject : JsonObjectBase {

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="json"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> representing the object.</param>
        protected BasecampObject(JObject json) : base(json) { }

        #endregion

        #region Member methods

        /// <summary>
        /// Attemtps to parse the specified <paramref name="json"/> string.
        /// </summary>
        /// <param name="json">The JSON string to be parsed.</param>
        /// <param name="result">The result of the parsing.</param>
        /// <returns><c>true</c> if the parsing succeeds; otherwise <c>false</c>.</returns>
        protected static bool TryParseJson(string json, out JObject result) {

            if (json == null) {
                result = null;
                return false;
            }

            json = json.Trim();

            if (json[0] == '{' && json[json.Length - 1] == '}') {
                result = JsonUtils.ParseJsonObject(json);
                return true;
            }

            result = null;
            return false;

        }

        #endregion

    }

}