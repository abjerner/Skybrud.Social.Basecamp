namespace Skybrud.Social.Basecamp.Options.Bc3.Todos {

    /// <summary>
    /// Enum class representing the status of to-dos that should be returned by the Basecamp 3 API.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todos.md#get-to-dos</cref>
    /// </see>
    public enum BasecampTodoStatus {
        
        /// <summary>
        /// Indicates that the status is not specified.
        /// </summary>
        Unspecified,
        
        /// <summary>
        /// Indicates that only archived to-dos should be returned.
        /// </summary>
        Archived,
        
        /// <summary>
        /// Indicates that only trashed to-dos should be returned.
        /// </summary>
        Trashed

    }

}