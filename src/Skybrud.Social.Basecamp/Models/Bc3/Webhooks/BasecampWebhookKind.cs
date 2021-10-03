namespace Skybrud.Social.Basecamp.Models.Bc3.Webhooks {
    
    public enum BasecampWebhookKind {
        
        /// <summary>
        /// Indicates an unknown kind - eg. if the kind could not be parsed.
        /// </summary>
        Unknown,
        
        TodoCreated,
        
        TodoAssignmentCreated

    }

}