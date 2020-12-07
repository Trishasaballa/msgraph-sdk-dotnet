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
    /// The type ConditionalAccessUsers.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ConditionalAccessUsers>))]
    public partial class ConditionalAccessUsers
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalAccessUsers"/> class.
        /// </summary>
        public ConditionalAccessUsers()
        {
            this.ODataType = "microsoft.graph.conditionalAccessUsers";
        }

        /// <summary>
        /// Gets or sets excludeGroups.
        /// Group IDs excluded from scope of policy.
        /// </summary>
        [JsonPropertyName("excludeGroups")]
        public IEnumerable<string> ExcludeGroups { get; set; }
    
        /// <summary>
        /// Gets or sets excludeRoles.
        /// Role IDs excluded from scope of policy.
        /// </summary>
        [JsonPropertyName("excludeRoles")]
        public IEnumerable<string> ExcludeRoles { get; set; }
    
        /// <summary>
        /// Gets or sets excludeUsers.
        /// User IDs excluded from scope of policy and/or GuestsOrExternalUsers.
        /// </summary>
        [JsonPropertyName("excludeUsers")]
        public IEnumerable<string> ExcludeUsers { get; set; }
    
        /// <summary>
        /// Gets or sets includeGroups.
        /// Group IDs in scope of policy unless explicitly excluded, or All.
        /// </summary>
        [JsonPropertyName("includeGroups")]
        public IEnumerable<string> IncludeGroups { get; set; }
    
        /// <summary>
        /// Gets or sets includeRoles.
        /// Role IDs in scope of policy unless explicitly excluded, or All.
        /// </summary>
        [JsonPropertyName("includeRoles")]
        public IEnumerable<string> IncludeRoles { get; set; }
    
        /// <summary>
        /// Gets or sets includeUsers.
        /// User IDs in scope of policy unless explicitly excluded, or None or All or GuestsOrExternalUsers.
        /// </summary>
        [JsonPropertyName("includeUsers")]
        public IEnumerable<string> IncludeUsers { get; set; }
    
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
