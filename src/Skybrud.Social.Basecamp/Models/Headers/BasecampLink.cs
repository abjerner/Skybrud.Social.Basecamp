using System;
using System.Text.RegularExpressions;
using Skybrud.Essentials.Http;

namespace Skybrud.Social.Basecamp.Models.Headers {
    
    public class BasecampLink {

        #region Properties

        public int Next { get; }

        public string NextUrl { get; }

        public bool HasNext => !string.IsNullOrWhiteSpace(NextUrl);

        #endregion

        #region Constructors

        private BasecampLink(string value) {

            if (string.IsNullOrWhiteSpace(value)) return;

            // Match the different URLs using REGEX
            foreach (Match match in Regex.Matches(value, "\\<(.+?)\\>; rel=\"([a-z]+)\"")) {

                string url = match.Groups[1].Value;
                string rel = match.Groups[2].Value;

                // Match the page parameter from the query string
                Match m2 = Regex.Match(url, "page=([0-9]+)");

                // Skip the URL if a page number wasn't part of the URL
                if (!m2.Success) continue;

                // Parse the page number
                int page = int.Parse(m2.Groups[1].Value);

                switch (rel) {

                    case "next":
                        Next = page;
                        NextUrl = url;
                        break;

                }

            }

        }

        #endregion

        /// <summary>
        /// Parses the <c>Link</c> header from the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <returns>An instance of <see cref="BasecampLink"/>.</returns>
        public static BasecampLink Parse(IHttpResponse response) {
            if (response == null) throw new ArgumentNullException(nameof(response));
            return new BasecampLink(response.Headers["Link"]);
        }

    }

}