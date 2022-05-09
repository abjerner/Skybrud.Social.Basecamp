using Newtonsoft.Json;
using Skybrud.Essentials.Json.Converters.Enums;

namespace Skybrud.Social.Basecamp.Models.Bc3.TodoSets {
    
    /// <summary>
    /// Enum class indicating the status of a Basecamp 3 to-do set.
    /// </summary>
    [JsonConverter(typeof(EnumStringConverter))]
    public enum BasecampTodoSetStatus {

        /// <summary>
        /// Indicates that the to-do set is active.
        /// </summary>
        Active,

        /// <summary>
        /// Indicates that the to-do set is archived.
        /// </summary>
        Archived,

        /// <summary>
        /// Indicates that the to-do set is trashed.
        /// </summary>
        Trashed

    }

}