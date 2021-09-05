using Skybrud.Essentials.Http;

namespace Skybrud.Social.Basecamp.Responses.Bcx {

    /// <summary>
    /// Class representing a response from the Basecamp API.
    /// </summary>
    public class BcxListResponse<T> : BcxResponse<T[]> {
        
        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The raw response the instance should be based on.</param>
        protected BcxListResponse(IHttpResponse response) : base(response) { }

        #endregion

    }

}