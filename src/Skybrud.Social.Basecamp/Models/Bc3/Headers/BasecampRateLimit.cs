using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;

namespace Skybrud.Social.Basecamp.Models.Bc3.Headers {
    
    /// <summary>
    /// Class representing the rate limiting information specified in a response from the Basecamp API.
    /// </summary>
    public class BasecampRateLimit : BasecampObject {

        #region Properties

        /// <summary>
        /// Gets the name associated with the rate limit - eg. <c>API</c>.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the rate limiting period.
        /// </summary>
        public int Period { get; }

        /// <summary>
        /// Gets the total amount of calls that can be made to the API in the current timeframe.
        /// </summary>
        public int Limit { get; }

        /// <summary>
        /// Gets the remaining amount of calls that can be made to the API in the current timeframe.
        /// </summary>
        public int Remaining { get; }

        /// <summary>
        /// Gets the timestamp of the next rate limit timeframe.
        /// </summary>
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