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
    /// The type WorkbookFunctionsRank_AvgRequestBody.
    /// </summary>
    
    public partial class WorkbookFunctionsRank_AvgRequestBody
    {
    
        /// <summary>
        /// Gets or sets Number.
        /// </summary>
        [JsonPropertyName("number")]
        public Newtonsoft.Json.Linq.JToken Number { get; set; }
    
        /// <summary>
        /// Gets or sets Ref.
        /// </summary>
        [JsonPropertyName("ref")]
        public Newtonsoft.Json.Linq.JToken Ref { get; set; }
    
        /// <summary>
        /// Gets or sets Order.
        /// </summary>
        [JsonPropertyName("order")]
        public Newtonsoft.Json.Linq.JToken Order { get; set; }
    
    }
}
