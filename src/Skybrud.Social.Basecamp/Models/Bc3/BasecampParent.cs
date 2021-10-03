using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Basecamp.Models.Bc3 {
    
    public class BasecampParent : BasecampObject {

        #region Properties

        public long Id { get; }

        public string Title { get; }

        public string Type { get; }

        public string Url { get; }

        public string AppUrl { get; }

        #endregion

        #region Constructors

        private BasecampParent(JObject json) : base(json)  {
            Id = json.GetInt64("id");
            Title = json.GetString("title");
            Type = json.GetString("type");
            Url = json.GetString("url");
            AppUrl = json.GetString("app_url");
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="BasecampParent"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="BasecampParent"/>.</returns>
        public static BasecampParent Parse(JObject json) {
            return json == null ? null : new BasecampParent(json);
        }

        #endregion

    }

}