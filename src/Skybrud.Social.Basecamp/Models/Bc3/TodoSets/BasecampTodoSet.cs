using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Basecamp.Models.Bc3.TodoSets {
    
    /// <summary>
    /// Class with information about a Basecamp 3 to-do set.
    /// </summary>
    public class BasecampTodoSet : BasecampObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the to-do set.
        /// </summary>
        public long Id { get; }

        #endregion

        #region Constructors

        private BasecampTodoSet(JObject json) : base(json)  {
            Id = json.GetInt64("id");
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="BasecampTodoSet"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="BasecampTodoSet"/>.</returns>
        public static BasecampTodoSet Parse(JObject json) {
            return json == null ? null : new BasecampTodoSet(json);
        }

        #endregion

    }

}