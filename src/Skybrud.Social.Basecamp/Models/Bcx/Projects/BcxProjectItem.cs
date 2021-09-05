using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;
using Skybrud.Social.Basecamp.Models.Bcx.People;

namespace Skybrud.Social.Basecamp.Models.Bcx.Projects {
    
    /// <summary>
    /// Class representing a Basecamp 2 project.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bcx-api/blob/master/sections/projects.md</cref>
    /// </see>
    public class BcxProjectItem : JsonObjectBase {

        #region Properties

        /// <summary>
        /// Gets the ID of the project.
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// Gets the name of the project.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the description of the project.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Gets the timestamp for when the project was created in Basecamp.
        /// </summary>
        public EssentialsTime CreatedAt { get; }

        /// <summary>
        /// Gets the timestamp for when the project was last updated in Basecamp.
        /// </summary>
        public EssentialsTime UpdatedAt { get; }
        
        /// <summary>
        /// Gets the API URL of the project.
        /// </summary>
        public string Url { get; }
        
        /// <summary>
        /// Gets the app URL of the project.
        /// </summary>
        public string AppUrl { get; }

        /// <summary>
        /// Gets whether the project is a template.
        /// </summary>
        public bool IsTemplate { get; }

        /// <summary>
        /// Gets whether the project has been archived.
        /// </summary>
        public bool IsArchived { get; }

        /// <summary>
        /// Gets whether the project has been starred by the current user.
        /// </summary>
        public bool IsStarred { get; }
        
        /// <summary>
        /// Gets whether the project has been trashed.
        /// </summary>
        public bool IsTrashed { get; }
        
        /// <summary>
        /// Gets whether the project is a draft.
        /// </summary>
        public bool IsDraft { get; }
        
        /// <summary>
        /// Gets whether the project is a client project.
        /// </summary>
        public bool IsClientProject { get; }
        
        /// <summary>
        /// Gets the HEX color of the project.
        /// </summary>
        public string Color { get; }

        /// <summary>
        /// Gets a reference to person who created the project.
        /// </summary>
        public BcxPersonReference Creator { get; }
        
        #endregion

        #region Constructors
        
        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="json"/> object.
        /// </summary>
        /// <param name="json">The JSON object representing the project.</param>
        protected BcxProjectItem(JObject json) : base(json)  {
            Id = json.GetInt64("id");
            Name = json.GetString("name");
            Description = json.GetString("description");
            CreatedAt = json.GetString("created_at", EssentialsTime.Parse);
            UpdatedAt = json.GetString("updated_at", EssentialsTime.Parse);
            IsTemplate = json.GetBoolean("template");
            IsArchived = json.GetBoolean("archived");
            IsStarred = json.GetBoolean("starred");
            IsTrashed = json.GetBoolean("trashed");
            IsDraft = json.GetBoolean("draft");
            IsClientProject = json.GetBoolean("is_client_project");
            Color = json.GetString("color");
            Url = json.GetString("url");
            AppUrl = json.GetString("app_url");
            Creator = json.GetObject("creator", BcxPersonReference.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="BcxProjectItem"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="BcxProjectItem"/>.</returns>
        public static BcxProjectItem Parse(JObject json) {
            return json == null ? null : new BcxProjectItem(json);
        }

        #endregion

    }

}