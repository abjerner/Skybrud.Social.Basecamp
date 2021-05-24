using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.Models.People;

namespace Skybrud.Social.Basecamp.Responses.People {
    
    /// <summary>
    /// Class representing a response with a list of people.
    /// </summary>
    public class BasecampPersonListResponse : BasecampListResponse<BasecampPerson> {

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The raw response the instance should be based on.</param>
        public BasecampPersonListResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonArray(response.Body, BasecampPerson.Parse);
        }

    }

}