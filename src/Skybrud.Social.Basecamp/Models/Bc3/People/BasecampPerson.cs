using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;

namespace Skybrud.Social.Basecamp.Models.Bc3.People {
    
    /// <summary>
    /// Class representing a Basecamp person.
    /// </summary>
    public class BasecampPerson : JsonObjectBase {

        #region Properties

        /// <summary>
        /// Gets the ID of the person.
        /// </summary>
        public int Id { get; }

        public string AttachableSgid { get; }

        /// <summary>
        /// Gets the name of the person.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the email address of the person.
        /// </summary>
        public string EmailAddress { get; }

        /// <summary>
        /// Gets the type of the person.
        /// </summary>
        public string PersonableType { get; }

        /// <summary>
        /// Gets the title of the person.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Gets the bio of the person.
        /// </summary>
        public string Bio { get; }

        /// <summary>
        /// Gets the timestamp for when the person was created in Basecamp.
        /// </summary>
        public EssentialsTime CreatedAt { get; }

        /// <summary>
        /// Gets the timestamp for when the person was last updated in Basecamp.
        /// </summary>
        public EssentialsTime UpdatedAt { get; }

        /// <summary>
        /// Gets whether the person is an administrator in the parent account.
        /// </summary>
        public bool IsAdmin { get; }

        /// <summary>
        /// Gets whether the person is an administrator of the parent account.
        /// </summary>
        public bool IsOwner { get; }

        /// <summary>
        /// Gets whether the person is a client.
        /// </summary>
        public bool IsClient { get; }

        /// <summary>
        /// Gets a textual representation of the person's time zone.
        /// </summary>
        public string TimeZone { get; }

        /// <summary>
        /// Gets the avatar URL of the person.
        /// </summary>
        public string AvatarUrl { get; }

        /// <summary>
        /// Gets a reference to the company of the person.
        /// </summary>
        public BasecampReference Company { get; }

        /// <summary>
        /// Gets whether a company has been specified for this user.
        /// </summary>
        public bool HasCompany => Company != null;

        #endregion

        #region Constructors

        private BasecampPerson(JObject json) : base(json)  {
            Id = json.GetInt32("id");
            AttachableSgid = json.GetString("attachable_sgid");
            Name = json.GetString("name");
            EmailAddress = json.GetString("email_address");
            PersonableType = json.GetString("personable_type");
            Title = json.GetString("title");
            Bio = json.GetString("bio");
            CreatedAt = json.GetString("created_at", EssentialsTime.Parse);
            UpdatedAt = json.GetString("updated_at", EssentialsTime.Parse);
            IsAdmin = json.GetBoolean("admin");
            IsOwner = json.GetBoolean("owner");
            IsClient = json.GetBoolean("client");
            TimeZone = json.GetString("time_zone");
            AvatarUrl = json.GetString("avatar_url");
            Company = json.GetObject("company", BasecampReference.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="BasecampPerson"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="BasecampPerson"/>.</returns>
        public static BasecampPerson Parse(JObject json) {
            return json == null ? null : new BasecampPerson(json);
        }

        #endregion

    }

}