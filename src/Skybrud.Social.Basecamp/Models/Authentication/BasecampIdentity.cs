using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Basecamp.Models.Authentication {

    /// <summary>
    /// Class representing the identity of a Basecamp user.
    /// </summary>
    public class BasecampIdentity : BasecampObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the user.
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// Gets the email address of the user.
        /// </summary>
        public string EmailAddress { get; }

        /// <summary>
        /// Gets the first name of the user.
        /// </summary>
        public string FirstName { get; }
        
        /// <summary>
        /// Gets the last name of the user.
        /// </summary>
        public string LastName { get; }

        #endregion

        #region Constructors

        private BasecampIdentity(JObject json) : base(json) {
            Id = json.GetInt64("id");
            EmailAddress = json.GetString("email_address");
            FirstName = json.GetString("first_name");
            LastName = json.GetString("last_name");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="BasecampIdentity"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="BasecampIdentity"/>.</returns>
        public static BasecampIdentity Parse(JObject json) {
            return json == null ? null : new BasecampIdentity(json);
        }

        #endregion

    }

}