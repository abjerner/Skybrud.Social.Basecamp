using System;
using Skybrud.Essentials.Http;

namespace Skybrud.Social.Basecamp.Exceptions {
    
    public class BasecampHttpException : Exception {

        public IHttpResponse Response { get; }

        public string Error { get; }

        public BasecampHttpException(IHttpResponse response, string error) : base("Invalid response received from the Basecamp API.") {
            Response = response;
            Error = error;
        }

    }

}