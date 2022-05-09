using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;
using Skybrud.Social.Basecamp.Models.Bc3.Buckets;
using Skybrud.Social.Basecamp.Models.Bc3.People;

namespace Skybrud.Social.Basecamp.Models.Bc3.TodoLists {
    
    /// <summary>
    /// Class with information about a Basecamp 3 to-do list.
    /// </summary>
    public class BasecampTodoList : BasecampObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the to-do list.
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// Gets the status of the to-do list.
        /// </summary>
        public BasecampTodoListStatus Status { get; }

        /// <summary>
        /// Gets whether the to-do list is visible to clients.
        /// </summary>
        public bool IsVisibleToClients { get; }

        /// <summary>
        /// Gets a timestamp for when the to-do list was created.
        /// </summary>
        public EssentialsTime CreatedAt { get; }

        /// <summary>
        /// Gets a timestamp for when the to-do list was last updated.
        /// </summary>
        public EssentialsTime UpdatedAt { get; }

        /// <summary>
        /// Gets the title of the to-do list.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Gets the JSON URL of the to-do list.
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// Gets the app URL of the to-do list.
        /// </summary>
        public string AppUrl { get; }

        /// <summary>
        /// Gets the amount of comments the to-do list has received.
        /// </summary>
        public int CommentsCount { get; }

        /// <summary>
        /// Gets the position of the to-do list.
        /// </summary>
        public int Position { get; }

        /// <summary>
        /// Gets a reference to the parent to-do list.
        /// </summary>
        public BasecampParent Parent { get; }

        /// <summary>
        /// Gets a reference to the parent bucket (aka project).
        /// </summary>
        public BasecampBucketItem Bucket { get; }

        /// <summary>
        /// Gets a reference to the creator of the to-do list.
        /// </summary>
        public BasecampPerson Creator { get; }

        /// <summary>
        /// Gets the description of the to-do list.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Gets whether the to-do list has been completed.
        /// </summary>
        public bool IsCompleted { get; }

        /// <summary>
        /// Gets the completed ratio of the to-do list - eg. <c>1/17</c>.
        /// </summary>
        public string CompletedRatio { get; }

        /// <summary>
        /// Gets the name of the to-do list.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the API URL for getting the to-dos of the to-do list.
        /// </summary>
        public string TodosUrl { get; }

        /// <summary>
        /// Gets the app URL for viewing the to-dos of the to-do list.
        /// </summary>
        public string AppTodosUrl { get; }

        #endregion

        #region Constructors

        private BasecampTodoList(JObject json) : base(json) {
            Id = json.GetInt64("id");
            Status = json.GetEnum<BasecampTodoListStatus>("status");
            IsVisibleToClients = json.GetBoolean("visible_to_clients");
            CreatedAt = json.GetString("created_at", ParseEssentialsTime);
            UpdatedAt = json.GetString("updated_at", ParseEssentialsTime);
            Title = json.GetString("title");
            Url = json.GetString("url");
            AppUrl = json.GetString("app_url");
            CommentsCount = json.GetInt32("comments_count");
            Position = json.GetInt32("position");
            Parent = json.GetObject("parent", BasecampParent.Parse);
            Bucket = json.GetObject("bucket", BasecampBucketItem.Parse);
            Creator = json.GetObject("creator", BasecampPerson.Parse);
            Description = json.GetString("description");
            IsCompleted = json.GetBoolean("completed");
            CompletedRatio = json.GetString("completed_ratio");
            Name = json.GetString("name");
            TodosUrl = json.GetString("todos_url");
            AppTodosUrl = json.GetString("groups_url");
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