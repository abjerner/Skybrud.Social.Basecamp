using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;

namespace Skybrud.Social.Basecamp.Models.Bc3.Todos {
    
    /// <summary>
    /// Class representing a Basecamp to-do.
    /// </summary>
    public class BasecampTodo : BasecampObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the to-do.
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// Gets the timestamp for when the to-do was created in Basecamp.
        /// </summary>
        public EssentialsTime CreatedAt { get; }

        /// <summary>
        /// Gets the timestamp for when the person was last updated in Basecamp.
        /// </summary>
        public EssentialsTime UpdatedAt { get; }

        /// <summary>
        /// Gets the name of the to-do.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Gets the API URL of the to-do.
        /// </summary>
        public string Url { get; }
        
        /// <summary>
        /// Gets the app URL of the to-do.
        /// </summary>
        public string AppUrl { get; }
        
        /// <summary>
        /// Gets information about the parent object.
        /// </summary>
        public BasecampParent Parent { get; }

        #endregion

        #region Constructors

        private BasecampTodo(JObject json) : base(json)  {
            Id = json.GetInt64("id");
            CreatedAt = json.GetString("created_at", EssentialsTime.Parse);
            UpdatedAt = json.GetString("updated_at", EssentialsTime.Parse);
            Title = json.GetString("title");
            Url = json.GetString("url");
            AppUrl = json.GetString("app_url");
            Parent = json.GetObject("parent", BasecampParent.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="BasecampTodo"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="BasecampTodo"/>.</returns>
        public static BasecampTodo Parse(JObject json) {
            return json == null ? null : new BasecampTodo(json);
        }

        #endregion

    }

}