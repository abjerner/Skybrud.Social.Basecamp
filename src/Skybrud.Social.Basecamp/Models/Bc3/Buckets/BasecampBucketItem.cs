using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Basecamp.Models.Bc3.Buckets {

    /// <summary>
    /// Class with basic information about a Basecamp 3 bucket (aka project).
    /// </summary>
    public class BasecampBucketItem : BasecampObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the parent.
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// Gets the name of the parent.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the type of the parent.
        /// </summary>
        public string Type { get; }

        #endregion

        #region Constructors

        private BasecampBucketItem(JObject json) : base(json) {
            Id = json.GetInt64("id");
            Name = json.GetString("name");
            Type = json.GetString("type");
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="BasecampBucketItem"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="BasecampBucketItem"/>.</returns>
        public static BasecampBucketItem Parse(JObject json) {
            return json == null ? null : new BasecampBucketItem(json);
        }

        #endregion

    }

}