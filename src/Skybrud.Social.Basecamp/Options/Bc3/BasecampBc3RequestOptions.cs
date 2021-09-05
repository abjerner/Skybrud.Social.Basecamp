using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Options;

namespace Skybrud.Social.Basecamp.Options.Bc3 {
    
    public abstract class BasecampBc3RequestOptions : IHttpRequestOptions {
        
        /// <inheritdoc />
        public abstract IHttpRequest GetRequest();

    }

}