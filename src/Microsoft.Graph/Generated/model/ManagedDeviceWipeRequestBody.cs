// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type ManagedDeviceWipeRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ManagedDeviceWipeRequestBody
    {
    
        /// <summary>
        /// Gets or sets KeepEnrollmentData.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "keepEnrollmentData", Required = Newtonsoft.Json.Required.Default)]
        public bool? KeepEnrollmentData { get; set; }
    
        /// <summary>
        /// Gets or sets KeepUserData.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "keepUserData", Required = Newtonsoft.Json.Required.Default)]
        public bool? KeepUserData { get; set; }
    
        /// <summary>
        /// Gets or sets MacOsUnlockCode.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "macOsUnlockCode", Required = Newtonsoft.Json.Required.Default)]
        public string MacOsUnlockCode { get; set; }
    
    }
}
