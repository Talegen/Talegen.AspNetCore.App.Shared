namespace Talegen.AspNetCore.App.Shared.Services.Messaging
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    /// <summary>
    /// Contains an enumeration of message body types.
    /// </summary>
    public enum MessageBodyType
    {
        /// <summary>
        /// Message body is plain text.
        /// </summary>
        Text = 0,

        /// <summary>
        /// Message body is HTML.
        /// </summary>
        Html = 1,

        /// <summary>
        /// Message body is other.
        /// </summary>
        Other = 2
    }

    /// <summary>
    /// This class contains the message body information.
    /// </summary>
    public class MessageBody
    {
        /// <summary>
        /// Gets or sets the body content type.
        /// </summary>
        public MessageBodyType BodyType { get; set; } = MessageBodyType.Text;

        /// <summary>
        /// Gets or sets the body content.
        /// </summary>
        public string Body { get; set; }
    }
}
