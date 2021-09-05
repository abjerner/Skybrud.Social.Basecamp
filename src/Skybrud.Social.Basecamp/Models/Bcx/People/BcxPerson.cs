using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;

namespace Skybrud.Social.Basecamp.Models.Bcx.People {

    /// <summary>
    /// Class representing a Basecamp 2 person.
    /// </summary>
    public class BcxPerson : JsonObjectBase {

        #region Properties

        /// <summary>
        /// Gets the ID of the person.
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// Gets the name of the person.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the email address of the person.
        /// </summary>
        public string EmailAddress { get; }

        /// <summary>
        /// Gets whether the person is an admin.
        /// </summary>
        public bool IsAdmin { get; }

        /// <summary>
        /// Gets the timestamp for when the person was created in Basecamp.
        /// </summary>
        public EssentialsTime CreatedAt { get; }

        /// <summary>
        /// Gets the timestamp for when the person was last updated in Basecamp.
        /// </summary>
        public EssentialsTime UpdatedAt { get; }

        /// <summary>
        /// Gets whether the person has been trashed.
        /// </summary>
        public bool IsTrashed { get; }
        
        /// <summary>
        /// Gerts the identity ID of the person.
        /// </summary>
        public long IdentityId { get; }

        /// <summary>
        /// Gerts whether the person can create new projects.
        /// </summary>
        public bool CanCreateProjects { get; }

        /// <summary>
        /// Gets the avatar URL of the person.
        /// </summary>
        public string AvatarUrl { get; }
        
        /// <summary>
        /// Gets the full size avatar URL of the person.
        /// </summary>
        public string FullsizeAvatarUrl { get; }
        
        /// <summary>
        /// Gets the API URL of the person.
        /// </summary>
        public string Url { get; }
        
        /// <summary>
        /// Gets the app URL of the person.
        /// </summary>
        public string AppUrl { get; }
        
        #endregion

        #region Constructors

        private BcxPerson(JObject json) : base(json)  {
            Id = json.GetInt64("id");
            Name = json.GetString("name");
            EmailAddress = json.GetString("email_address");
            IsAdmin = json.GetBoolean("admin");
            CreatedAt = json.GetString("created_at", EssentialsTime.Parse);
            UpdatedAt = json.GetString("updated_at", EssentialsTime.Parse);
            IsTrashed = json.GetBoolean("trashed");
            IdentityId = json.GetInt64("identity_id");
            CanCreateProjects = json.GetBoolean("can_create_projects");
            AvatarUrl = json.GetString("avatar_url");
            FullsizeAvatarUrl = json.GetString("fullsize_avatar_url");
            Url = json.GetString("url");
            AppUrl = json.GetString("app_url");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="BcxPerson"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="BcxPerson"/>.</returns>
        public static BcxPerson Parse(JObject json) {
            return json == null ? null : new BcxPerson(json);
        }

        #endregion

    }

}