using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Options;

namespace Skybrud.Social.Basecamp.Options.Bcx {
    
    public abstract class BasecampBcxRequestOptions : IHttpRequestOptions {
        
        /// <inheritdoc />
        public abstract IHttpRequest GetRequest();

    }

}