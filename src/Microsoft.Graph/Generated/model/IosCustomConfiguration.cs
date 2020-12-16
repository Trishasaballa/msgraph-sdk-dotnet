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
    /// The type Ios Custom Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IosCustomConfiguration : DeviceConfiguration
    {
    
		///<summary>
		/// The IosCustomConfiguration constructor
		///</summary>
        public IosCustomConfiguration()
        {
            this.ODataType = "microsoft.graph.iosCustomConfiguration";
        }
	
        /// <summary>
        /// Gets or sets payload.
        /// Payload. (UTF8 encoded byte array)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payload", Required = Newtonsoft.Json.Required.Default)]
        public byte[] Payload { get; set; }
    
        /// <summary>
        /// Gets or sets payload file name.
        /// Payload file name (.mobileconfig
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payloadFileName", Required = Newtonsoft.Json.Required.Default)]
        public string PayloadFileName { get; set; }
    
        /// <summary>
        /// Gets or sets payload name.
        /// Name that is displayed to the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payloadName", Required = Newtonsoft.Json.Required.Default)]
        public string PayloadName { get; set; }
    
    }
}

