// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type ChatInfo.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ChatInfo>))]
    public partial class ChatInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatInfo"/> class.
        /// </summary>
        public ChatInfo()
        {
            this.ODataType = "microsoft.graph.chatInfo";
        }

        /// <summary>
        /// Gets or sets messageId.
        /// The unique identifier of a message in a Microsoft Teams channel.
        /// </summary>
        [JsonPropertyName("messageId")]
        public string MessageId { get; set; }
    
        /// <summary>
        /// Gets or sets replyChainMessageId.
        /// The ID of the reply message.
        /// </summary>
        [JsonPropertyName("replyChainMessageId")]
        public string ReplyChainMessageId { get; set; }
    
        /// <summary>
        /// Gets or sets threadId.
        /// The unique identifier for a thread in Microsoft Teams.
        /// </summary>
        [JsonPropertyName("threadId")]
        public string ThreadId { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
