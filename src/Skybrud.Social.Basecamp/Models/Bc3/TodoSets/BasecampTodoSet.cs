using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;
using Skybrud.Social.Basecamp.Models.Bc3.Buckets;
using Skybrud.Social.Basecamp.Models.Bc3.People;

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

        /// <summary>
        /// Gets the status of the to-do set.
        /// </summary>
        public BasecampTodoSetStatus Status { get; }

        /// <summary>
        /// Gets whether the to-do set is visible to clients.
        /// </summary>
        public bool IsVisibleToClients { get; }

        /// <summary>
        /// Gets a timestamp for when the to-do set was created.
        /// </summary>
        public EssentialsTime CreatedAt { get; }

        /// <summary>
        /// Gets a timestamp for when the to-do set was last updated.
        /// </summary>
        public EssentialsTime UpdatedAt { get; }

        /// <summary>
        /// Gets the title of the to-do set.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Gets the JSON URL of the to-do set.
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// Gets the app URL of the to-do set.
        /// </summary>
        public string AppUrl { get; }

        /// <summary>
        /// Gets the position of the to-do set.
        /// </summary>
        public int Position { get; }

        /// <summary>
        /// Gets a reference to the parent bucket (aka project).
        /// </summary>
        public BasecampBucketItem Bucket { get; }

        /// <summary>
        /// Gets a reference to the creator of the to-do set.
        /// </summary>
        public BasecampPerson Creator { get; }

        /// <summary>
        /// Gets whether the to-do set has been completed.
        /// </summary>
        public bool IsCompleted { get; }

        /// <summary>
        /// Gets the completed ratio of the to-do set - eg. <c>1/17</c>.
        /// </summary>
        public string CompletedRatio { get; }

        /// <summary>
        /// Gets the name of the to-do set.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the amount of to-do lists created under the to-do set.
        /// </summary>
        public int TodolistsCount { get; }

        /// <summary>
        /// Gets the API URL for getting the to-do lists of the to-do set.
        /// </summary>
        public string TodolistsUrl { get; }

        /// <summary>
        /// Gets the app URL for viewing the to-do lists of the to-do set.
        /// </summary>
        public string AppTodolistsUrl { get; }

        #endregion

        #region Constructors

        private BasecampTodoSet(JObject json) : base(json)  {
            Id = json.GetInt64("id");
            Status = json.GetEnum<BasecampTodoSetStatus>("status");
            IsVisibleToClients = json.GetBoolean("visible_to_clients");
            CreatedAt = json.GetString("created_at", ParseEssentialsTime);
            UpdatedAt = json.GetString("updated_at", ParseEssentialsTime);
            Title = json.GetString("title");
            Url = json.GetString("url");
            AppUrl = json.GetString("app_url");
            Position = json.GetInt32("position");
            Bucket = json.GetObject("bucket", BasecampBucketItem.Parse);
            Creator = json.GetObject("creator", BasecampPerson.Parse);
            IsCompleted = json.GetBoolean("completed");
            CompletedRatio = json.GetString("completed_ratio");
            Name = json.GetString("name");
            TodolistsCount = json.GetInt32("todolists_count");
            TodolistsUrl = json.GetString("todolists_url");
            AppTodolistsUrl = json.GetString("app_todoslists_url");
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