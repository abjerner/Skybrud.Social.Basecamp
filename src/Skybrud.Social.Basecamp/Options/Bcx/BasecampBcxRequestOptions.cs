using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Options;

namespace Skybrud.Social.Basecamp.Options.Bcx {
    
    /// <summary>
    /// Abstract implementation of <see cref="IHttpRequestOptions"/> specific to the Basecamp 2 implementation.
    /// </summary>
    public abstract class BasecampBcxRequestOptions : IHttpRequestOptions {
        
        /// <inheritdoc />
        public abstract IHttpRequest GetRequest();

    }

}