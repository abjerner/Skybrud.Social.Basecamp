using System;

namespace Skybrud.Social.Basecamp.Exceptions {

    /// <summary>
    /// Class representing a basic Basecamp exception.
    /// </summary>
    public class BasecampException : Exception {

        /// <summary>
        /// Initializes a new exception with the specified <paramref name="message"/>.
        /// </summary>
        /// <param name="message">The message of the exception.</param>
        public BasecampException(string message) : base(message) { }

        /// <summary>
        /// Initializes a new exception with the specified <paramref name="message"/>.
        /// </summary>
        /// <param name="message">The message of the exception.</param>
        /// <param name="innerException">The inner exception.</param>
        public BasecampException(string message, Exception innerException) : base(message, innerException) { }

    }

}