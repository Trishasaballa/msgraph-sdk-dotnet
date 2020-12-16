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
    /// The type WorkbookFunctionsConvertRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsConvertRequestBody
    {
    
        /// <summary>
        /// Gets or sets Number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "number", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Number { get; set; }
    
        /// <summary>
        /// Gets or sets FromUnit.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fromUnit", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken FromUnit { get; set; }
    
        /// <summary>
        /// Gets or sets ToUnit.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "toUnit", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken ToUnit { get; set; }
    
    }
}
