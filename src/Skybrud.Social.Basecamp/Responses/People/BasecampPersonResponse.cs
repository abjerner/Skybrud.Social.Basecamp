using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.Models.People;

namespace Skybrud.Social.Basecamp.Responses.People {
    
    public class BasecampPersonResponse : BasecampResponse<BasecampPerson> {
        
        public BasecampPersonResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonObject(response.Body, BasecampPerson.Parse);
        }

    }

}