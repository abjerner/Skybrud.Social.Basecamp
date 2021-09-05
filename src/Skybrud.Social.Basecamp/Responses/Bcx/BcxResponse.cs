using System;
using System.Net;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Json;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Basecamp.Exceptions;

namespace Skybrud.Social.Basecamp.Responses.Bcx {

    /// <summary>
    /// Class representing a response from the Basecamp 2 API.
    /// </summary>
    public class BcxResponse : HttpResponseBase {

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The raw response the instance should be based on.</param>
        public BcxResponse(IHttpResponse response) : base(response) {

            if (response.StatusCode == HttpStatusCode.OK) return;
            if (response.StatusCode == HttpStatusCode.Created) return;
            
            if (response.Body.Length == 0) throw new BasecampHttpException(response);

            JObject obj = JsonUtils.ParseJsonObject(response.Body);
            string error = obj.GetString("error");

            throw new BasecampHttpException(response, error);

        }

        #endregion

    }

    /// <summary>
    /// Class representing a response from the Basecamp 2 API.
    /// </summary>
    public class BcxResponse<T> : BcxResponse {

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
        protected BcxResponse(IHttpResponse response) : base(response) { }

        #endregion

    }

}