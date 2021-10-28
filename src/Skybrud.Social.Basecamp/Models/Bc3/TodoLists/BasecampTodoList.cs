using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Basecamp.Models.Bc3.TodoLists {
    
    /// <summary>
    /// Class with information about a Basecamp 3 to-do list.
    /// </summary>
    public class BasecampTodoList : BasecampObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the to-do set.
        /// </summary>
        public long Id { get; }

        #endregion

        #region Constructors

        private BasecampTodoList(JObject json) : base(json)  {
            Id = json.GetInt64("id");
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="BasecampTodoList"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="BasecampTodoList"/>.</returns>
        public static BasecampTodoList Parse(JObject json) {
            return json == null ? null : new BasecampTodoList(json);
        }

        #endregion

    }

}