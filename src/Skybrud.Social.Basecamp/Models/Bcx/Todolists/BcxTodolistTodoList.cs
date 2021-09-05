using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Basecamp.Models.Bcx.Todos;

namespace Skybrud.Social.Basecamp.Models.Bcx.Todolists {

    /// <summary>
    /// Class representing a list of todos.
    /// </summary>
    public class BcxTodolistTodoList : BasecampObject {

        #region Properties

        /// <summary>
        /// Gets an array with the remaining todos of the parent todolist.
        /// </summary>
        public BcxTodoItem[] Remaining { get; }
        
        /// <summary>
        /// Gets an array with the completed todos of the parent todolist.
        /// </summary>
        public BcxTodoItem[] Completed { get; }
        
        /// <summary>
        /// Gets an array with the trashed todos of the parent todolist.
        /// </summary>
        public BcxTodoItem[] Trashed { get; }

        #endregion
        
        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="json"/> object.
        /// </summary>
        /// <param name="json">The JSON object representing the project.</param>
        public BcxTodolistTodoList(JObject json) : base(json) {
            Remaining = json.GetArrayItems("remaining", BcxTodoItem.Parse);
            Completed = json.GetArrayItems("completed", BcxTodoItem.Parse);
            Trashed = json.GetArrayItems("trashed", BcxTodoItem.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="BcxTodolistTodoList"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="BcxTodolistTodoList"/>.</returns>
        public static BcxTodolistTodoList Parse(JObject json) {
            return json == null ? null : new BcxTodolistTodoList(json);
        }

        #endregion

    }

}