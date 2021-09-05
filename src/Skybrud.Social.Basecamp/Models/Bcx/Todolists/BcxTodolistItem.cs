using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;
using Skybrud.Social.Basecamp.Models.Bcx.People;

namespace Skybrud.Social.Basecamp.Models.Bcx.Todolists {
    
    /// <summary>
    /// Class representing a Basecamp 2 todolist.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/todolists.md</cref>
    /// </see>
    public class BcxTodolistItem : JsonObjectBase {

        #region Properties

        /// <summary>
        /// Gets the ID of the todolist.
        /// </summary>
        public long Id { get; }
        
        /// <summary>
        /// Gets the name of the todolist.
        /// </summary>
        public string Name { get; }
        
        /// <summary>
        /// Gets the description of the todolist.
        /// </summary>
        public string Description { get; }
        
        /// <summary>
        /// Gets the timestamp for when the todolist was created in Basecamp.
        /// </summary>
        public EssentialsTime CreatedAt { get; }
        
        /// <summary>
        /// Gets the timestamp for when the todolist was last updated in Basecamp.
        /// </summary>
        public EssentialsTime UpdatedAt { get; }

        /// <summary>
        /// Gets whether the todolist has been completed.
        /// </summary>
        public bool IsCompleted { get; }

        /// <summary>
        /// Gets the position of the todolist.
        /// </summary>
        public int Position { get; }

        /// <summary>
        /// Gets whether the todolist is private.
        /// </summary>
        public bool IsPrivate { get; }

        /// <summary>
        /// Gets whether the todolist has been trashed.
        /// </summary>
        public bool IsTrashed { get; }
        
        /// <summary>
        /// Gets the API URL of the todolist.
        /// </summary>
        public string Url { get; }
        
        /// <summary>
        /// Gets the app URL of the todolist.
        /// </summary>
        public string AppUrl { get; }

        /// <summary>
        /// Gets the amount of remainding todos.
        /// </summary>
        public int RemainingCount { get; }
        
        /// <summary>
        /// Gets the amount of completed todos.
        /// </summary>
        public int CompletedCount { get; }
        
        /// <summary>
        /// Gets the total amount of todos.
        /// </summary>
        public int TotalCount { get; }

        /// <summary>
        /// Gets the percent of remaining todos.
        /// </summary>
        public float RemainingPercent => RemainingCount == 0 && CompletedCount == 0 ? 100f : (float) RemainingCount / (TotalCount) * 100;

        /// <summary>
        /// Gets the percent of completed todos.
        /// </summary>
        public float CompletedPercent => RemainingCount == 0 && CompletedCount == 0 ? 100f : (float) CompletedCount / (TotalCount) * 100;

        /// <summary>
        /// Gets a reference to the person who created the todolist.
        /// </summary>
        public BcxPersonReference Creator { get; }
        
        #endregion

        #region Constructors
        
        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="json"/> object.
        /// </summary>
        /// <param name="json">The JSON object representing the project.</param>
        protected BcxTodolistItem(JObject json) : base(json) {
            Id = json.GetInt64("id");
            Name = json.GetString("name");
            Description = json.GetString("description");
            CreatedAt = json.GetString("created_at", EssentialsTime.Parse);
            UpdatedAt = json.GetString("updated_at", EssentialsTime.Parse);
            IsCompleted = json.GetBoolean("completed");
            Position = json.GetInt32("position");
            IsPrivate = json.GetBoolean("private");
            IsTrashed = json.GetBoolean("trashed");
            Url = json.GetString("url");
            AppUrl = json.GetString("app_url");
            RemainingCount = json.GetInt32("remaining_count");
            CompletedCount = json.GetInt32("completed_count");
            TotalCount = RemainingCount + CompletedCount;
            Creator = json.GetObject("creator", BcxPersonReference.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="BcxTodolistItem"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="BcxTodolistItem"/>.</returns>
        public static BcxTodolistItem Parse(JObject json) {
            return json == null ? null : new BcxTodolistItem(json);
        }

        #endregion

    }

}