using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.Models.People;

namespace Skybrud.Social.Basecamp.Responses.People {
    
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