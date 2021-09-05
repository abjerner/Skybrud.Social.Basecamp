using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;
using Skybrud.Social.Basecamp.Models.Bcx.People;

namespace Skybrud.Social.Basecamp.Models.Bcx.Todos {
    
    /// <summary>
    /// Class representing a Basecamp 2 todo.
    /// </summary>
    public class BcxTodoItem : JsonObjectBase {

        #region Properties

        /// <summary>
        /// Gets the ID of the todo.
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// Gets the ID of the parent todolist.
        /// </summary>
        public long TodolistId { get; }

        /// <summary>
        /// Gets the position of the todo.
        /// </summary>
        public int Position { get; }

        /// <summary>
        /// Gets the content (name) of the todo.
        /// </summary>
        public string Content { get; }

        /// <summary>
        /// Gets whether the todo has been completed.
        /// </summary>
        public bool IsCompleted { get; }
        
        /// <summary>
        /// Gets the timestamp for when the todo was created in Basecamp.
        /// </summary>
        public EssentialsTime CreatedAt { get; }
        
        /// <summary>
        /// Gets the timestamp for when the todo was last updated in Basecamp.
        /// </summary>
        public EssentialsTime UpdatedAt { get; }

        /// <summary>
        /// Gets the amount of comments of the todo.
        /// </summary>
        public int CommentsCount { get; }
        
        /// <summary>
        /// Gets whether the todo is private.
        /// </summary>
        public bool IsPrivate { get; }

        /// <summary>
        /// Gets whether the todo has been trashed.
        /// </summary>
        public bool IsTrashed { get; }
        
        // Add support for the "due_on" property
        // Add support for the "due_at" property
        
        /// <summary>
        /// Gets a reference to the person who created the todo.
        /// </summary>
        public BcxPersonReference Creator { get; }
        
        /// <summary>
        /// Gets a reference to the person currently assigned to the todo, or <c>null</c> if no one is assigned.
        /// </summary>
        public BcxTodoAssignee Assignee { get; }
        
        /// <summary>
        /// Gets the API URL of the todo.
        /// </summary>
        public string Url { get; }
        
        /// <summary>
        /// Gets the app URL of the todo.
        /// </summary>
        public string AppUrl { get; }
        
        #endregion

        #region Constructors
        
        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="json"/> object.
        /// </summary>
        /// <param name="json">The JSON object representing the todo.</param>
        protected BcxTodoItem(JObject json) : base(json) {
            Id = json.GetInt64("id");
            TodolistId = json.GetInt64("todolist_id");
            Position = json.GetInt32("position");
            Content = json.GetString("content");
            IsCompleted = json.GetBoolean("completed");
            CreatedAt = json.GetString("created_at", EssentialsTime.Parse);
            UpdatedAt = json.GetString("updated_at", EssentialsTime.Parse);
            CommentsCount = json.GetInt32("comments_count");
            IsPrivate = json.GetBoolean("private");
            IsTrashed = json.GetBoolean("trashed");
            // Add support for the "due_on" property
            // Add support for the "due_at" property
            Creator = json.GetObject("creator", BcxPersonReference.Parse);
            Assignee = json.GetObject("assignee", BcxTodoAssignee.Parse);
            Url = json.GetString("url");
            AppUrl = json.GetString("app_url");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="BcxTodoItem"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="BcxTodoItem"/>.</returns>
        public static BcxTodoItem Parse(JObject json) {
            return json == null ? null : new BcxTodoItem(json);
        }

        #endregion

    }

}