using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Basecamp.Models.Bcx.Todolists {
    
    /// <summary>
    /// Class representing a subscriber to a todolist.
    /// </summary>
    public class BcxTodolistSubscriber : JsonObjectBase {

        #region Properties

        /// <summary>
        /// Gets the ID of the subscriber.
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// Gets the name of the subscriber.
        /// </summary>
        public string Name { get; }
        
        #endregion

        #region Constructors
        
        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="json"/> object.
        /// </summary>
        /// <param name="json">The JSON object representing the subscriber.</param>
        protected BcxTodolistSubscriber(JObject json) : base(json) {
            Id = json.GetInt64("id");
            Name = json.GetString("name");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="BcxTodolistSubscriber"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="BcxTodolistSubscriber"/>.</returns>
        public static BcxTodolistSubscriber Parse(JObject json) {
            return json == null ? null : new BcxTodolistSubscriber(json);
        }

        #endregion

    }

}