using Skybrud.Social.Basecamp.Models.Headers;

namespace Skybrud.Social.Basecamp.Responses {
    
    /// <summary>
    /// Interface describing a list response.
    /// </summary>
    public interface IListResponse {

        /// <summary>
        /// Gets the total amount of items.
        /// </summary>
        int TotalCount { get; }

        /// <summary>
        /// Gets the amount of items returned on the current page.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Gets a reference to the <c>Link</c> header.
        /// </summary>
        BasecampLink Link { get; }

    }

}