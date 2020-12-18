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
    /// The type TeamMessagingSettings.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TeamMessagingSettings>))]
    public partial class TeamMessagingSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMessagingSettings"/> class.
        /// </summary>
        public TeamMessagingSettings()
        {
            this.ODataType = "microsoft.graph.teamMessagingSettings";
        }

        /// <summary>
        /// Gets or sets allowChannelMentions.
        /// If set to true, @channel mentions are allowed.
        /// </summary>
        [JsonPropertyName("allowChannelMentions")]
        public bool? AllowChannelMentions { get; set; }
    
        /// <summary>
        /// Gets or sets allowOwnerDeleteMessages.
        /// If set to true, owners can delete any message.
        /// </summary>
        [JsonPropertyName("allowOwnerDeleteMessages")]
        public bool? AllowOwnerDeleteMessages { get; set; }
    
        /// <summary>
        /// Gets or sets allowTeamMentions.
        /// If set to true, @team mentions are allowed.
        /// </summary>
        [JsonPropertyName("allowTeamMentions")]
        public bool? AllowTeamMentions { get; set; }
    
        /// <summary>
        /// Gets or sets allowUserDeleteMessages.
        /// If set to true, users can delete their messages.
        /// </summary>
        [JsonPropertyName("allowUserDeleteMessages")]
        public bool? AllowUserDeleteMessages { get; set; }
    
        /// <summary>
        /// Gets or sets allowUserEditMessages.
        /// If set to true, users can edit their messages.
        /// </summary>
        [JsonPropertyName("allowUserEditMessages")]
        public bool? AllowUserEditMessages { get; set; }
    
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
