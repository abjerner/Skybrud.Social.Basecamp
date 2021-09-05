using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.Models.Bc3.People;

namespace Skybrud.Social.Basecamp.Responses.Bc3.People {
    
    /// <summary>
    /// Class representing a response with profile information about a single person.
    /// </summary>
    public class BasecampPersonResponse : BasecampResponse<BasecampPerson> {

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The raw response the instance should be based on.</param>
        public BasecampPersonResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonObject(response.Body, BasecampPerson.Parse);
        }

    }

}