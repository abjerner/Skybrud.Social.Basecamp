using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Basecamp.Models.Bcx.Todos {
    
    /// <summary>
    /// Class representing a subscriber to a todo.
    /// </summary>
    public class BcxTodoAssignee : JsonObjectBase {

        #region Properties

        /// <summary>
        /// Gets the ID of the assignee.
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// Gets the name of the assignee.
        /// </summary>
        public string Name { get; }
        
        #endregion

        #region Constructors
        
        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="json"/> object.
        /// </summary>
        /// <param name="json">The JSON object representing the assignee.</param>
        protected BcxTodoAssignee(JObject json) : base(json) {
            Id = json.GetInt64("id");
            // TODO: Add support for the "type" property
            Name = json.GetString("name");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="BcxTodoAssignee"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="BcxTodoAssignee"/>.</returns>
        public static BcxTodoAssignee Parse(JObject json) {
            return json == null ? null : new BcxTodoAssignee(json);
        }

        #endregion

    }

}