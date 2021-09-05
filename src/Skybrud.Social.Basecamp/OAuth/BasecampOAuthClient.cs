using System;
using Skybrud.Essentials.Common;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Client;
using Skybrud.Essentials.Http.Collections;
using Skybrud.Essentials.Http.Options;
using Skybrud.Essentials.Strings.Extensions;
using Skybrud.Social.Basecamp.Apis;
using Skybrud.Social.Basecamp.Endpoints;
using Skybrud.Social.Basecamp.Options.Bc3;
using Skybrud.Social.Basecamp.Options.Bcx;
using Skybrud.Social.Basecamp.Responses.Authentication;

namespace Skybrud.Social.Basecamp.OAuth {

    /// <summary>
    /// Class for handling the raw communication with the Basecamp API as well as any OAuth 2.0 communication/authentication.
    /// </summary>
    public class BasecampOAuthClient : HttpClient {

        #region Properties

        /// <summary>
        /// Gets or sets the ID of the client.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the secret of the client.
        /// </summary>
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or sets the redirect URI of your application.
        /// </summary>
        public string RedirectUri { get; set; }

        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the user agent.
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        /// Gets a reference to the raw <strong>Authorization</strong> endpoint.
        /// </summary>
        public BasecampAuthorizationRawEndpoint Authorization { get; }

        /// <summary>
        /// Gets a reference to the raw Basecamp 2 API implementation.
        /// </summary>
        public BasecampBcxRawApi Bcx { get; }
        
        /// <summary>
        /// Gets a reference to the raw Basecamp 3 API implementation.
        /// </summary>
        public BasecampBc3RawApi Bc3 { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new OAuth client with default options.
        /// </summary>
        public BasecampOAuthClient() {
            Authorization = new BasecampAuthorizationRawEndpoint(this);
            Bcx = new BasecampBcxRawApi(this);
            Bc3 = new BasecampBc3RawApi(this);
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets an authorization URL using the specified <paramref name="state"/>.
        /// </summary>
        /// <param name="state">A unique state for the request.</param>
        /// <returns>A <see cref="string"/> with the authorization URL.</returns>
        public string GetAuthorizationUrl(string state) {

            // Some input validation
            if (string.IsNullOrWhiteSpace(ClientId)) throw new PropertyNotSetException(nameof(ClientId));
            if (string.IsNullOrWhiteSpace(RedirectUri)) throw new PropertyNotSetException(nameof(RedirectUri));

            // Do we have a valid "state" ?
            if (string.IsNullOrWhiteSpace(state)) {
                throw new ArgumentNullException(nameof(state), "A valid state should be specified as it is part of the security of OAuth 2.0.");
            }

            // Initialize the query string
            IHttpQueryString query = new HttpQueryString {
                {"type", "web_server"},
                {"client_id", ClientId },
                {"redirect_uri", RedirectUri},
                {"state", state}
            };

            // Generate the URL
            return "https://launchpad.37signals.com/authorization/new?" + query;

        }

        /// <summary>
        /// Exchanges the specified <paramref name="authorizationCode"/> for a user access token.
        /// </summary>
        /// <param name="authorizationCode">The authorization code received from the GitHub OAuth dialog.</param>
        public BasecampTokenResponse GetAccessTokenFromAuthorizationCode(string authorizationCode) {

            // Some validation
            if (string.IsNullOrWhiteSpace(ClientId)) throw new PropertyNotSetException(nameof(ClientId));
            if (string.IsNullOrWhiteSpace(ClientSecret)) throw new PropertyNotSetException(nameof(ClientId));
            if (string.IsNullOrWhiteSpace(authorizationCode)) throw new ArgumentNullException(nameof(authorizationCode));

            IHttpQueryString query = new HttpQueryString {
                {"type", "web_server"},
                {"client_id", ClientId},
                {"client_secret", ClientSecret},
                {"code", authorizationCode }
            };

            // Add the redirect URI (if specified)
            if (!string.IsNullOrWhiteSpace(RedirectUri)) query.Add("redirect_uri", RedirectUri);

            // Get the response from the server
            IHttpResponse response = HttpUtils.Requests.Post("https://launchpad.37signals.com/authorization/token", query, default(IHttpPostData));
            
            // Return the response
            return BasecampTokenResponse.ParseResponse(response);

        }
        
        /// <summary>
        /// Returns the response of the request identified by the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instanceo of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public override IHttpResponse GetResponse(IHttpRequestOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            IHttpRequest request = options.GetRequest();
            PrepareHttpRequest(request, options);
            return request.GetResponse();
        }
        
        /// <summary>
        /// Virtual method that can be used for configuring a request.
        /// </summary>
        /// <param name="request">The request.</param>
        protected override void PrepareHttpRequest(IHttpRequest request) {

            // Set the user agent (required by Basecamp)
            request.UserAgent = UserAgent.HasValue() ? UserAgent : "Skybrud.Social (https://github.com/abjerner/Skybrud.Social.Basecamp)";

            // Append the access token to the HTTP headers (if present)
            if (!string.IsNullOrWhiteSpace(AccessToken)) {
                request.Headers.Authorization = "Bearer " + AccessToken;
            }

        }
        
        /// <summary>
        /// Virtual method that can be used for configuring a request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="options">The options describing a HTTP request.</param>
        protected void PrepareHttpRequest(IHttpRequest request, IHttpRequestOptions options) {
            
            // Append scheme and host if not already present
            switch (options) {

                case BasecampBcxRequestOptions _:
                    if (request.Url.StartsWith("/")) request.Url = "https://basecamp.com" + request.Url;
                    break;

                case BasecampBc3RequestOptions _:
                    if (request.Url.StartsWith("/")) request.Url = "https://3.basecampapi.com" + request.Url;
                    break;

                
            }

            // Call the inherited method
            PrepareHttpRequest(request);

        }

        #endregion

    }

}