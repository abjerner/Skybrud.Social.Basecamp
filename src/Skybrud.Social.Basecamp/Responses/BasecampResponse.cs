using System.Net;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Json;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Basecamp.Exceptions;
using Skybrud.Social.Basecamp.Models.Headers;

namespace Skybrud.Social.Basecamp.Responses {

    /// <summary>
    /// Class representing a response from the Basecamp API.
    /// </summary>
    public class BasecampResponse : HttpResponseBase {

        #region Properties

        public BasecampRateLimit RateLimit { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The raw response the instance should be based on.</param>
        public BasecampResponse(IHttpResponse response) : base(response) {

            RateLimit = BasecampRateLimit.Parse(response);

            if (response.StatusCode == HttpStatusCode.OK) return;
            if (response.StatusCode == HttpStatusCode.Created) return;

            JObject obj = JsonUtils.ParseJsonObject(response.Body);

            string error = obj.GetString("error");

            throw new BasecampHttpException(response, error);

        }

        #endregion

    }

    /// <summary>
    /// Class representing a response from the Basecamp API.
    /// </summary>
    public class BasecampResponse<T> : BasecampResponse {

        #region Properties

        /// <summary>
        /// Gets the body of the response.
        /// </summary>
        public T Body { get; protected set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The raw response the instance should be based on.</param>
        protected BasecampResponse(IHttpResponse response) : base(response) { }

        #endregion

    }

}