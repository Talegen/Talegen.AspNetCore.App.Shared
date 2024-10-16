﻿/*
 * Talegen ASP.net Core App Shared Library
 * (c) Copyright Talegen, LLC.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * http://www.apache.org/licenses/LICENSE-2.0
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
*/
namespace Talegen.AspNetCore.App.Shared.Services.Messaging
{
    using System.Collections.Generic;
    using Talegen.AspNetCore.App.Shared.Services.Queue;



    /// <summary>
    /// Contains an enumeration of message priorities.
    /// </summary>
    public enum MessagePriority
    {
        /// <summary>
        /// Low priority.
        /// </summary>
        Low = 0,

        /// <summary>
        /// Normal priority.
        /// </summary>
        Normal = 1,

        /// <summary>
        /// High priority.
        /// </summary>
        High = 2
    }

    /// <summary>
    /// This interface defines a minimum implementation of a sender message.
    /// </summary>
    public interface ISenderMessage : IQueueItem
    {
        /// <summary>
        /// Gets or sets the sender address.
        /// </summary>
        ISenderAddress From { get; set; }

        /// <summary>
        /// Gets or sets the recipient addresses.
        /// </summary>
        List<ISenderAddress> Recipients { get; set; }

        /// <summary>
        /// Gets or sets the message priority.
        /// </summary>
        MessagePriority Priority { get; set; }

        /// <summary>
        /// Gets or sets the message subject.
        /// </summary>
        string Subject { get; set; }

        /// <summary>
        /// Gets or sets the text body of the message.
        /// </summary>
        string TextBody { get; set; }

        /// <summary>
        /// Gets or sets the HTML body of the message.
        /// </summary>
        string HtmlBody { get; set; }
    }
}
