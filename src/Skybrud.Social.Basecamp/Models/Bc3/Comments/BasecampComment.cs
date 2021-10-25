using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;

namespace Skybrud.Social.Basecamp.Models.Bc3.Comments {

    /// <summary>
    /// Class representing a Basecamp comment.
    /// </summary>
    public class BasecampComment : BasecampObject {

        #region Properties
        
        /// <summary>
        /// Gets the ID of the comment.
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// Gets the timestamp for when the comment was created in Basecamp.
        /// </summary>
        public EssentialsTime CreatedAt { get; }

        /// <summary>
        /// Gets the timestamp for when the comment was last updated in Basecamp.
        /// </summary>
        public EssentialsTime UpdatedAt { get; }

        /// <summary>
        /// Gets the name of the to-do.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Gets the API URL of the comment.
        /// </summary>
        public string Url { get; }
        
        /// <summary>
        /// Gets the app URL of the comment.
        /// </summary>
        public string AppUrl { get; }
        
        /// <summary>
        /// Gets information about the parent object.
        /// </summary>
        public BasecampParent Parent { get; }

        /// <summary>
        /// Gets the content of the comment.
        /// </summary>
        public string Content { get; }

        #endregion

        #region Constructors

        private BasecampComment(JObject json) : base(json)  {
            Id = json.GetInt64("id");
            Title = json.GetString("title");
            CreatedAt = json.GetString("created_at", EssentialsTime.Parse);
            UpdatedAt = json.GetString("updated_at", EssentialsTime.Parse);
            Title = json.GetString("title");
            Url = json.GetString("url");
            AppUrl = json.GetString("app_url");
            Parent = json.GetObject("parent", BasecampParent.Parse);
            Content = json.GetString("content");
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="BasecampComment"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="BasecampComment"/>.</returns>
        public static BasecampComment Parse(JObject json) {
            return json == null ? null : new BasecampComment(json);
        }

        #endregion

    }

}