using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;

namespace Skybrud.Social.Basecamp.Models.Headers {
    
    public class BasecampRateLimit : BasecampObject {

        #region Properties

        public string Name { get; }

        public int Period { get; }

        public int Limit { get; }

        public int Remaining { get; }

        public EssentialsTime Until { get; }

        #endregion

        #region Constructors

        private BasecampRateLimit(JObject json) : base(json) {
            Name = json.GetString("name");
            Period = json.GetInt32("period");
            Limit = json.GetInt32("limit");
            Remaining = json.GetInt32("remaining");
            Until = json.GetString("until", EssentialsTime.FromIso8601);
        }

        #endregion

        /// <summary>
        /// Parses the <c>X-Ratelimit</c> header from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <returns>An instance of <see cref="BasecampRateLimit"/>.</returns>
        public static BasecampRateLimit Parse(IHttpResponse response) {
            if (response == null) throw new ArgumentNullException(nameof(response));
            return TryParseJson(response.Headers["X-Ratelimit"], out JObject result) ? new BasecampRateLimit(result) : null;
        }

    }

}