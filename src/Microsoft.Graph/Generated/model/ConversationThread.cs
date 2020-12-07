// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Conversation Thread.
    /// </summary>
    
    public partial class ConversationThread : Entity
    {
    
		///<summary>
		/// The ConversationThread constructor
		///</summary>
        public ConversationThread()
        {
            this.ODataType = "microsoft.graph.conversationThread";
        }
	
        /// <summary>
        /// Gets or sets cc recipients.
        /// The Cc: recipients for the thread.
        /// </summary>
        [JsonPropertyName("ccRecipients")]
        public IEnumerable<Recipient> CcRecipients { get; set; }
    
        /// <summary>
        /// Gets or sets has attachments.
        /// Indicates whether any of the posts within this thread has at least one attachment.
        /// </summary>
        [JsonPropertyName("hasAttachments")]
        public bool? HasAttachments { get; set; }
    
        /// <summary>
        /// Gets or sets is locked.
        /// Indicates if the thread is locked.
        /// </summary>
        [JsonPropertyName("isLocked")]
        public bool? IsLocked { get; set; }
    
        /// <summary>
        /// Gets or sets last delivered date time.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonPropertyName("lastDeliveredDateTime")]
        public DateTimeOffset? LastDeliveredDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets preview.
        /// A short summary from the body of the latest post in this conversation.
        /// </summary>
        [JsonPropertyName("preview")]
        public string Preview { get; set; }
    
        /// <summary>
        /// Gets or sets topic.
        /// The topic of the conversation. This property can be set when the conversation is created, but it cannot be updated.
        /// </summary>
        [JsonPropertyName("topic")]
        public string Topic { get; set; }
    
        /// <summary>
        /// Gets or sets to recipients.
        /// The To: recipients for the thread.
        /// </summary>
        [JsonPropertyName("toRecipients")]
        public IEnumerable<Recipient> ToRecipients { get; set; }
    
        /// <summary>
        /// Gets or sets unique senders.
        /// All the users that sent a message to this thread.
        /// </summary>
        [JsonPropertyName("uniqueSenders")]
        public IEnumerable<string> UniqueSenders { get; set; }
    
        /// <summary>
        /// Gets or sets posts.
        /// Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("posts")]
        public IConversationThreadPostsCollectionPage Posts { get; set; }
    
    }
}

