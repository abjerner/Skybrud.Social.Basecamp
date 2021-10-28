using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;

namespace Skybrud.Social.Basecamp.Models.Authentication {
    
    /// <summary>
    /// Class with information about the authenticated user and their accounts.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/api/blob/master/sections/authentication.md#get-authorization</cref>
    /// </see>
    public class BasecampAuthorization : BasecampObject {

        #region Properties

        /// <summary>
        /// Gets a timestamp for when the current access token will expire.
        /// </summary>
        public EssentialsTime ExpiresAt { get; }

        /// <summary>
        /// Gets brief information about the authenticated user.
        /// </summary>
        public BasecampIdentity Identity { get; }

        /// <summary>
        /// Gets a list of the Basecamp accounts of the authenticated user.
        /// </summary>
        public BasecampAccount[] Accounts { get; }

        #endregion

        #region Constructors

        private BasecampAuthorization(JObject json) : base(json) {
            ExpiresAt = json.GetString("expires_at", EssentialsTime.FromIso8601);
            Identity = json.GetObject("identity", BasecampIdentity.Parse);
            Accounts = json.GetArrayItems("accounts", BasecampAccount.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="BasecampAuthorization"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="BasecampAuthorization"/>.</returns>
        public static BasecampAuthorization Parse(JObject json) {
            return json == null ? null : new BasecampAuthorization(json);
        }

        #endregion

    }

}