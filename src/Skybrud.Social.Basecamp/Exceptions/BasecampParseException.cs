namespace Skybrud.Social.Basecamp.Exceptions {

    /// <summary>
    /// Class representing an exception occured when parsing data from the Basecamp API.
    /// </summary>
    public class BasecampParseException : BasecampException {

        /// <summary>
        /// Initializes a new exception with the specified <paramref name="message"/>.
        /// </summary>
        /// <param name="message">The message of the exception.</param>
        public BasecampParseException(string message) : base(message) { }

    }

}