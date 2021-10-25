using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Basecamp.Models.Bc3 {
    
    /// <summary>
    /// Class with information about a parent object.
    /// </summary>
    public class BasecampParent : BasecampObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the parent.
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// Gets the title of the parent.
        /// </summary>
        public string Title { get; }
        
        /// <summary>
        /// Gets the type of the parent.
        /// </summary>
        public string Type { get; }
        
        /// <summary>
        /// Gets the URL of the parent.
        /// </summary>
        public string Url { get; }
        
        /// <summary>
        /// Gets the app URL of the parent.
        /// </summary>
        public string AppUrl { get; }

        #endregion

        #region Constructors

        private BasecampParent(JObject json) : base(json)  {
            Id = json.GetInt64("id");
            Title = json.GetString("title");
            Type = json.GetString("type");
            Url = json.GetString("url");
            AppUrl = json.GetString("app_url");
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="BasecampParent"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="BasecampParent"/>.</returns>
        public static BasecampParent Parse(JObject json) {
            return json == null ? null : new BasecampParent(json);
        }

        #endregion

    }

}