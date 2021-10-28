using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Basecamp.Models.Bc3.Projects {
    
    /// <summary>
    /// Class representing a Basecamp 3 project dock.
    /// </summary>
    public class BasecampProjectDock : BasecampObject {

        #region Properties
        
        /// <summary>
        /// Gets the ID of the dock.
        /// </summary>
        public long Id { get; }
        
        /// <summary>
        /// Gets the title of the dock.
        /// </summary>
        public string Title { get; }
        
        /// <summary>
        /// Gets the name of the dock.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets whether the dock/tool is enabled.
        /// </summary>
        public bool IsEnabled { get; }

        /// <summary>
        /// Gets the position of the dock.
        /// </summary>
        public int? Position { get; }
        
        /// <summary>
        /// Gets the API URL of the dock.
        /// </summary>
        public string Url { get; }
        
        /// <summary>
        /// Gets the app URL of the dock.
        /// </summary>
        public string AppUrl { get; }

        #endregion

        #region Constructors

        private BasecampProjectDock(JObject json) : base(json)  {
            Id = json.GetInt64("id");
            Title = json.GetString("title");
            Name = json.GetString("name");
            IsEnabled = json.GetBoolean("enabled");
            Position = json.HasValue("position") ? null : json.GetInt32("position");
            Url = json.GetString("url");
            AppUrl = json.GetString("app_url");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="BasecampProjectDock"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="BasecampProjectDock"/>.</returns>
        public static BasecampProjectDock Parse(JObject json) {
            return json == null ? null : new BasecampProjectDock(json);
        }

        #endregion

    }

}