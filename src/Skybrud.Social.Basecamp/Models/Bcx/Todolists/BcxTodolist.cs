using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Basecamp.Models.Bcx.Todolists {

    /// <summary>
    /// Class representing a Basecamp 2 todolist.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/todolists.md</cref>
    /// </see>
    public class BcxTodolist : BcxTodolistItem {

        #region Properties

        /// <summary>
        /// Gets a list of todos of the todolist.
        /// </summary>
        public BcxTodolistTodoList Todos { get; }

        /// <summary>
        /// Gets a list of subscribers to the todolist.
        /// </summary>
        public BcxTodolistSubscriber[] Subscribers { get; }

        #endregion
        
        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="json"/> object.
        /// </summary>
        /// <param name="json">The JSON object representing the project.</param>
        public BcxTodolist(JObject json) : base(json) {
            Todos = json.GetObject("todos", BcxTodolistTodoList.Parse);
            Subscribers = json.GetArrayItems("subscribers", BcxTodolistSubscriber.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="BcxTodolist"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="BcxTodolist"/>.</returns>
        public new static BcxTodolist Parse(JObject json) {
            return json == null ? null : new BcxTodolist(json);
        }

        #endregion

    }

}