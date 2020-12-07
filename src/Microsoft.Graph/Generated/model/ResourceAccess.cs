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
    /// The type ResourceAccess.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ResourceAccess>))]
    public partial class ResourceAccess
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceAccess"/> class.
        /// </summary>
        public ResourceAccess()
        {
            this.ODataType = "microsoft.graph.resourceAccess";
        }

        /// <summary>
        /// Gets or sets id.
        /// The unique identifier for one of the oauth2PermissionScopes or appRole instances that the resource application exposes.
        /// </summary>
        [JsonPropertyName("id")]
        public Guid? Id { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// Specifies whether the id property references an oauth2PermissionScopes or an appRole. Possible values are Scope or Role.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
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
