using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Basecamp.Models.Authentication {

    /// <summary>
    /// Class representing the response body of a call to exchange an authorization code for an access token.
    /// </summary>
    public class BasecampToken : BasecampObject {

        #region Properties

        /// <summary>
        /// Gets the access token.
        /// </summary>
        public string AccessToken { get; }

        /// <summary>
        /// Gets a <see cref="TimeSpan"/> for when the <see cref="AccessToken"/> expires.
        /// </summary>
        public TimeSpan ExpiresIn { get; }

        /// <summary>
        /// Gets the refresh token.
        /// </summary>
        public string RefreshToken { get; }

        #endregion

        #region Constructors

        private BasecampToken(JObject json) : base(json) {
            AccessToken = json.GetString("access_token");
            ExpiresIn = json.GetDouble("expires_in", TimeSpan.FromSeconds);
            RefreshToken = json.GetString("refresh_token");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="BasecampToken"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="BasecampToken"/>.</returns>
        public static BasecampToken Parse(JObject json) {
            return json == null ? null : new BasecampToken(json);
        }

        #endregion

    }

}