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
    /// The type WorkbookFunctionsQuartile_ExcRequestBody.
    /// </summary>
    
    public partial class WorkbookFunctionsQuartile_ExcRequestBody
    {
    
        /// <summary>
        /// Gets or sets Array.
        /// </summary>
        [JsonPropertyName("array")]
        public Newtonsoft.Json.Linq.JToken Array { get; set; }
    
        /// <summary>
        /// Gets or sets Quart.
        /// </summary>
        [JsonPropertyName("quart")]
        public Newtonsoft.Json.Linq.JToken Quart { get; set; }
    
    }
}
