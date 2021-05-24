using System;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Json;
using Skybrud.Social.Basecamp.Models.Authentication;

namespace Skybrud.Social.Basecamp.Responses.Authentication {

    /// <summary>
    /// Class representing the response of a call to exchange an authorization code for an access token.
    /// </summary>
    public class BasecampTokenResponse : BasecampResponse<BasecampToken> {
        
        #region Constructors

        private BasecampTokenResponse(IHttpResponse response) : base(response) {
            Body = JsonUtils.ParseJsonObject(response.Body, BasecampToken.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="BasecampTokenResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="IHttpResponse"/> representing the raw response.</param>
        /// <returns>An instance of <see cref="BasecampTokenResponse"/> representing the response.</returns>
        public static BasecampTokenResponse ParseResponse(IHttpResponse response) {
            if (response == null) throw new ArgumentNullException(nameof(response));
            return new BasecampTokenResponse(response);
        }

        #endregion

    }

}