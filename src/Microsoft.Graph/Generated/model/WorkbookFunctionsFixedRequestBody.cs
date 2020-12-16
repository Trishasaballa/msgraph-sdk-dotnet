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
    /// The type WorkbookFunctionsFixedRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsFixedRequestBody
    {
    
        /// <summary>
        /// Gets or sets Number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "number", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Number { get; set; }
    
        /// <summary>
        /// Gets or sets Decimals.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "decimals", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Decimals { get; set; }
    
        /// <summary>
        /// Gets or sets NoCommas.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "noCommas", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken NoCommas { get; set; }
    
    }
}
