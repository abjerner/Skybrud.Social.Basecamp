using Skybrud.Essentials.Http;
using Skybrud.Essentials.Strings.Extensions;
using Skybrud.Social.Basecamp.Models.Headers;

namespace Skybrud.Social.Basecamp.Responses {

    /// <summary>
    /// Class representing a response from the Basecamp API.
    /// </summary>
    public class BasecampListResponse<T> : BasecampResponse<T[]>, IListResponse {

        #region Properties

        /// <inheritdoc/>
        public int TotalCount { get; }

        /// <inheritdoc/>
        public int Count => Body.Length;

        /// <inheritdoc/>
        public BasecampLink Link { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The raw response the instance should be based on.</param>
        protected BasecampListResponse(IHttpResponse response) : base(response) {
            TotalCount = response.Headers["X-Total-Count"].ToInt32();
            Link = BasecampLink.Parse(response);
        }

        #endregion

    }

}