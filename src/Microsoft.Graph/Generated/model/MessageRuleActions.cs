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
    /// The type MessageRuleActions.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MessageRuleActions>))]
    public partial class MessageRuleActions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageRuleActions"/> class.
        /// </summary>
        public MessageRuleActions()
        {
            this.ODataType = "microsoft.graph.messageRuleActions";
        }

        /// <summary>
        /// Gets or sets assignCategories.
        /// A list of categories to be assigned to a message.
        /// </summary>
        [JsonPropertyName("assignCategories")]
        public IEnumerable<string> AssignCategories { get; set; }
    
        /// <summary>
        /// Gets or sets copyToFolder.
        /// The ID of a folder that a message is to be copied to.
        /// </summary>
        [JsonPropertyName("copyToFolder")]
        public string CopyToFolder { get; set; }
    
        /// <summary>
        /// Gets or sets delete.
        /// Indicates whether a message should be moved to the Deleted Items folder.
        /// </summary>
        [JsonPropertyName("delete")]
        public bool? Delete { get; set; }
    
        /// <summary>
        /// Gets or sets forwardAsAttachmentTo.
        /// The email addresses of the recipients to which a message should be forwarded as an attachment.
        /// </summary>
        [JsonPropertyName("forwardAsAttachmentTo")]
        public IEnumerable<Recipient> ForwardAsAttachmentTo { get; set; }
    
        /// <summary>
        /// Gets or sets forwardTo.
        /// The email addresses of the recipients to which a message should be forwarded.
        /// </summary>
        [JsonPropertyName("forwardTo")]
        public IEnumerable<Recipient> ForwardTo { get; set; }
    
        /// <summary>
        /// Gets or sets markAsRead.
        /// Indicates whether a message should be marked as read.
        /// </summary>
        [JsonPropertyName("markAsRead")]
        public bool? MarkAsRead { get; set; }
    
        /// <summary>
        /// Gets or sets markImportance.
        /// Sets the importance of the message, which can be: low, normal, high.
        /// </summary>
        [JsonPropertyName("markImportance")]
        public Importance? MarkImportance { get; set; }
    
        /// <summary>
        /// Gets or sets moveToFolder.
        /// The ID of the folder that a message will be moved to.
        /// </summary>
        [JsonPropertyName("moveToFolder")]
        public string MoveToFolder { get; set; }
    
        /// <summary>
        /// Gets or sets permanentDelete.
        /// Indicates whether a message should be permanently deleted and not saved to the Deleted Items folder.
        /// </summary>
        [JsonPropertyName("permanentDelete")]
        public bool? PermanentDelete { get; set; }
    
        /// <summary>
        /// Gets or sets redirectTo.
        /// The email addresses to which a message should be redirected.
        /// </summary>
        [JsonPropertyName("redirectTo")]
        public IEnumerable<Recipient> RedirectTo { get; set; }
    
        /// <summary>
        /// Gets or sets stopProcessingRules.
        /// Indicates whether subsequent rules should be evaluated.
        /// </summary>
        [JsonPropertyName("stopProcessingRules")]
        public bool? StopProcessingRules { get; set; }
    
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
