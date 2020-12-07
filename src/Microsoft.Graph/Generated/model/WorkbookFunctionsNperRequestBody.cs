// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsNperRequestBody.
    /// </summary>
    
    public partial class WorkbookFunctionsNperRequestBody
    {
    
        /// <summary>
        /// Gets or sets Rate.
        /// </summary>
        [JsonPropertyName("rate")]
        public Newtonsoft.Json.Linq.JToken Rate { get; set; }
    
        /// <summary>
        /// Gets or sets Pmt.
        /// </summary>
        [JsonPropertyName("pmt")]
        public Newtonsoft.Json.Linq.JToken Pmt { get; set; }
    
        /// <summary>
        /// Gets or sets Pv.
        /// </summary>
        [JsonPropertyName("pv")]
        public Newtonsoft.Json.Linq.JToken Pv { get; set; }
    
        /// <summary>
        /// Gets or sets Fv.
        /// </summary>
        [JsonPropertyName("fv")]
        public Newtonsoft.Json.Linq.JToken Fv { get; set; }
    
        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonPropertyName("type")]
        public Newtonsoft.Json.Linq.JToken Type { get; set; }
    
    }
}
