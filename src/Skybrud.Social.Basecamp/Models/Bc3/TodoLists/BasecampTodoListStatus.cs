using Newtonsoft.Json;
using Skybrud.Essentials.Json.Converters.Enums;

namespace Skybrud.Social.Basecamp.Models.Bc3.TodoLists {

    /// <summary>
    /// Enum class indicating the status of a Basecamp 3 to-do list.
    /// </summary>
    [JsonConverter(typeof(EnumStringConverter))]
    public enum BasecampTodoListStatus {

        /// <summary>
        /// Indicates that the to-do list is active.
        /// </summary>
        Active,

        /// <summary>
        /// Indicates that the to-do list is archived.
        /// </summary>
        Archived,

        /// <summary>
        /// Indicates that the to-do list is trashed.
        /// </summary>
        Trashed

    }

}