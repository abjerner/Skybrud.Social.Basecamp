using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.Models.Bcx.People;

namespace Skybrud.Social.Basecamp.Responses.Bcx.People {
    
    /// <summary>
    /// Class representing a response with profile information about a single person.
    /// </summary>
    public class BcxPersonResponse : BcxResponse<BcxPerson> {

        /// <summary>
        /// Initializes a new instance from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The raw response the instance should be based on.</param>
        public BcxPersonResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonObject(response.Body, BcxPerson.Parse);
        }

    }

}