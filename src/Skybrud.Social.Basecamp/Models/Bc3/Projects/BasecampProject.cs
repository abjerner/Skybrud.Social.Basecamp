using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;

namespace Skybrud.Social.Basecamp.Models.Bc3.Projects {
    
    /// <summary>
    /// Class representing a Basecamp 3 project.
    /// </summary>
    public class BasecampProject : BasecampObject {

        #region Properties
        
        /// <summary>
        /// Gets the ID of the project.
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// Gets the status of the project.
        /// </summary>
        public string Status { get; }

        /// <summary>
        /// Gets a timestamp for when the project was created.
        /// </summary>
        public EssentialsTime CreatedAt { get; }
        
        /// <summary>
        /// Gets a timestamp for when the project was last updated.
        /// </summary>
        public EssentialsTime UpdatedAt { get; }
        
        /// <summary>
        /// Gets the name of the project.
        /// </summary>
        public string Name { get; }
        
        /// <summary>
        /// Gets the description of the project.
        /// </summary>
        public string Description { get; }
        
        /// <summary>
        /// Gets whether clients has been enabled for this project.
        /// </summary>
        public bool IsClientsEnabled { get; }
        
        /// <summary>
        /// Gets the bookmark URL of the project.
        /// </summary>
        public string BookmarkUrl { get; }
        
        /// <summary>
        /// Gets the API URL of the project.
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// Gets the app URL of the project.
        /// </summary>
        public string AppUrl { get; }

        /// <summary>
        /// Gets a reference to the company of the client for the project.
        /// </summary>
        public BasecampProjectClient ClientCompany { get; }

        /// <summary>
        /// Gets an array of the current tools of the project.
        /// </summary>
        public BasecampProjectDock[] Dock { get; }

        /// <summary>
        /// Gets whether the authenticated user has bookmarked this project.
        /// </summary>
        public bool IsBookmarked { get; }

        #endregion

        #region Constructors

        private BasecampProject(JObject json) : base(json)  {
            Id = json.GetInt64("id");
            Status = json.GetString("status");
            CreatedAt = json.GetString("created_at", ParseEssentialsTime);
            UpdatedAt = json.GetString("updated_at", ParseEssentialsTime);
            Name = json.GetString("name");
            Description = json.GetString("description");
            IsClientsEnabled = json.GetBoolean("clients_enabled");
            BookmarkUrl = json.GetString("bookmark_url");
            Url = json.GetString("url");
            AppUrl = json.GetString("app_url");
            ClientCompany = json.GetObject("client_company", BasecampProjectClient.Parse);
            Dock = json.GetArrayItems("dock", BasecampProjectDock.Parse);
            IsBookmarked = json.GetBoolean("bookmarked");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="BasecampProject"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="BasecampProject"/>.</returns>
        public static BasecampProject Parse(JObject json) {
            return json == null ? null : new BasecampProject(json);
        }

        #endregion

    }

}