using System.Net;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Exceptions;

namespace Skybrud.Social.Basecamp.Exceptions {

    /// <summary>
    /// Class representing an exception returned by the Basecamp API.
    /// </summary>
    public class BasecampHttpException : BasecampException, IHttpException {

        #region Properties

        /// <summary>
        /// Gets a reference to the raw response.
        /// </summary>
        public IHttpResponse Response { get; }
        
        /// <summary>
        /// Gets the status code of the response.
        /// </summary>
        public HttpStatusCode StatusCode => Response.StatusCode;

        /// <summary>
        /// Gets the error information from the response.
        /// </summary>
        public string Error { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new exception based on the specified <paramref name="response"/> and <paramref name="error"/>.
        /// </summary>
        /// <param name="response">The raw response of the exception.</param>
        /// <param name="error">The error.</param>

        public BasecampHttpException(IHttpResponse response, string error) : base("Invalid response received from the Basecamp API.") {
            Response = response;
            Error = error;
        }
        
        #endregion

    }

}