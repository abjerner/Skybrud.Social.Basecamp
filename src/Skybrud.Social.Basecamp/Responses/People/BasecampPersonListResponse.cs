using Skybrud.Essentials.Http;
using Skybrud.Social.Basecamp.Models.People;

namespace Skybrud.Social.Basecamp.Responses.People {
    
    public class BasecampPersonListResponse : BasecampListResponse<BasecampPerson> {

        public BasecampPersonListResponse(IHttpResponse response) : base(response) {
            Body = ParseJsonArray(response.Body, BasecampPerson.Parse);
        }

    }

}