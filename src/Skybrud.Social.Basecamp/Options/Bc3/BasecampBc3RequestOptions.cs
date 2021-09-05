using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Options;

namespace Skybrud.Social.Basecamp.Options.Bc3 {
    
    /// <summary>
    /// Abstract implementation of <see cref="IHttpRequestOptions"/> specific to the Basecamp 3 implementation.
    /// </summary>
    public abstract class BasecampBc3RequestOptions : IHttpRequestOptions {
        
        /// <inheritdoc />
        public abstract IHttpRequest GetRequest();

    }

}