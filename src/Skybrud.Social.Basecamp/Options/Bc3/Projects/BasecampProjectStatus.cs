namespace Skybrud.Social.Basecamp.Options.Bc3.Projects {
   
    /// <summary>
    /// Enum class representing the status of projects that should be returned by the Basecamp 3 API.
    /// </summary>
    /// <see>
    ///     <cref>https://github.com/basecamp/bc3-api/blob/master/sections/projects.md#get-projects</cref>
    /// </see>
    public enum BasecampProjectStatus {
        
        /// <summary>
        /// Indicates that the status is not specified.
        /// </summary>
        Unspecified,
        
        /// <summary>
        /// Indicates that only archived projects should be returned.
        /// </summary>
        Archived,
        
        /// <summary>
        /// Indicates that only trashed projects should be returned.
        /// </summary>
        Trashed

    }

}