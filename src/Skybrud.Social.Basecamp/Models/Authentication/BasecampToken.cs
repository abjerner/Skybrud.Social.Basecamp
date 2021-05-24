using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Basecamp.Models.Authentication {

    /// <summary>
    /// Class representing the response body of a call to exchange an authorization code for an access token.
    /// </summary>
    public class BasecampToken {

        #region Properties

        public JObject JObject { get; }

        /// <summary>
        /// Gets the access token.
        /// </summary>
        public string AccessToken { get; }

        public TimeSpan ExpiresIn { get; }

        public string RefreshToken { get; }

        #endregion

        #region Constructors

        private BasecampToken(JObject obj) {
            JObject = obj;
            AccessToken = obj.GetString("access_token");
            ExpiresIn = obj.GetDouble("expires_in", TimeSpan.FromSeconds);
            RefreshToken = obj.GetString("refresh_token");
        }

        #endregion

        #region Static methods

        public static BasecampToken Parse(JObject obj) {
            return obj == null ? null : new BasecampToken(obj);
        }

        #endregion

    }

}