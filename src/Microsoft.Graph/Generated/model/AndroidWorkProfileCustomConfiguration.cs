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
    /// The type Android Work Profile Custom Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidWorkProfileCustomConfiguration : DeviceConfiguration
    {
    
		///<summary>
		/// The AndroidWorkProfileCustomConfiguration constructor
		///</summary>
        public AndroidWorkProfileCustomConfiguration()
        {
            this.ODataType = "microsoft.graph.androidWorkProfileCustomConfiguration";
        }
	
        /// <summary>
        /// Gets or sets oma settings.
        /// OMA settings. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "omaSettings", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<OmaSetting> OmaSettings { get; set; }
    
    }
}

