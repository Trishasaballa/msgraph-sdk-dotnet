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
    /// The type TargetResource.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TargetResource>))]
    public partial class TargetResource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TargetResource"/> class.
        /// </summary>
        public TargetResource()
        {
            this.ODataType = "microsoft.graph.targetResource";
        }

        /// <summary>
        /// Gets or sets displayName.
        /// Indicates the visible name defined for the resource. Typically specified when the resource is created.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets groupType.
        /// When type is set to Group, this indicates the group type.
        /// </summary>
        [JsonPropertyName("groupType")]
        public GroupType? GroupType { get; set; }
    
        /// <summary>
        /// Gets or sets id.
        /// Indicates the unique ID of the resource.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or sets modifiedProperties.
        /// Indicates name, old value and new value of each attribute that changed. Property values depend on the operation type.
        /// </summary>
        [JsonPropertyName("modifiedProperties")]
        public IEnumerable<ModifiedProperty> ModifiedProperties { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// Describes the resource type.  Example values include Application, Group, ServicePrincipal, and User.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or sets userPrincipalName.
        /// When type is set to User, this includes the user name that initiated the action; null for other types.
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
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
