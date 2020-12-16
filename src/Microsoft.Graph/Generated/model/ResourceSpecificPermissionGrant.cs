// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Resource Specific Permission Grant.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ResourceSpecificPermissionGrant : DirectoryObject
    {
    
		///<summary>
		/// The ResourceSpecificPermissionGrant constructor
		///</summary>
        public ResourceSpecificPermissionGrant()
        {
            this.ODataType = "microsoft.graph.resourceSpecificPermissionGrant";
        }
	
        /// <summary>
        /// Gets or sets client app id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "clientAppId", Required = Newtonsoft.Json.Required.Default)]
        public string ClientAppId { get; set; }
    
        /// <summary>
        /// Gets or sets client id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "clientId", Required = Newtonsoft.Json.Required.Default)]
        public string ClientId { get; set; }
    
        /// <summary>
        /// Gets or sets permission.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "permission", Required = Newtonsoft.Json.Required.Default)]
        public string Permission { get; set; }
    
        /// <summary>
        /// Gets or sets permission type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "permissionType", Required = Newtonsoft.Json.Required.Default)]
        public string PermissionType { get; set; }
    
        /// <summary>
        /// Gets or sets resource app id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceAppId", Required = Newtonsoft.Json.Required.Default)]
        public string ResourceAppId { get; set; }
    
    }
}

