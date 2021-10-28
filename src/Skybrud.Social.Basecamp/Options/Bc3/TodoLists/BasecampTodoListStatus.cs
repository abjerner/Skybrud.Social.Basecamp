namespace Skybrud.Social.Basecamp.Options.Bc3.TodoLists {
    
    /// <summary>
    /// Enum class representing the status of to-do lists that should be returned by the Basecamp 3 API.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/todolists.md#get-to-do-lists</cref>
    /// </see>
    public enum BasecampTodoListStatus {
        
        /// <summary>
        /// Indicates that the status is not specified.
        /// </summary>
        Unspecified,
        
        /// <summary>
        /// Indicates that only archived to-do lists should be returned.
        /// </summary>
        Archived,
        
        /// <summary>
        /// Indicates that only trashed to-do lists should be returned.
        /// </summary>
        Trashed

    }

}