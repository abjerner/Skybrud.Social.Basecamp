using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.Models.Bcx.People;

namespace Skybrud.Social.Basecamp.Responses.Bcx.People {
    
    /// <summary>
    /// Class representing a response with a list of people.
    /// </summary>
    public class BcxPersonListResponse : BcxListResponse<BcxPerson> {

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The raw response the instance should be based on.</param>
        public BcxPersonListResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonArray(response.Body, BcxPerson.Parse);
        }

    }

}