using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Basecamp.Models.Authentication {

    /// <summary>
    /// Class representing the account of a Basecamp user.
    /// </summary>
    public class BasecampAccount : BasecampObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the account.
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// Gets the name of the account.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Get the product of the account - eg. <c>bcx</c> for Basecamp 2 or <c>bc3</c> for Basecamp 3.
        /// </summary>
        public string Product { get; }

        /// <summary>
        /// Gets the API URL of the account.
        /// </summary>
        public string Href { get; }

        /// <summary>
        /// Gets the app URL of the account.
        /// </summary>
        public string AppHref { get; }

        /// <summary>
        /// Gets whether the account is hidden.
        /// </summary>
        public bool IsHidden { get; }

        #endregion

        #region Constructors

        private BasecampAccount(JObject json) : base(json) {
            Id = json.GetInt64("id");
            Name = json.GetString("name");
            Product = json.GetString("product");
            Href = json.GetString("href");
            AppHref = json.GetString("app_href");
            IsHidden = json.GetBoolean("hidden");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="BasecampAccount"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="BasecampAccount"/>.</returns>
        public static BasecampAccount Parse(JObject json) {
            return json == null ? null : new BasecampAccount(json);
        }

        #endregion

    }

}