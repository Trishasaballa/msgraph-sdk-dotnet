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
    /// The type WorkbookFunctionsXirrRequestBody.
    /// </summary>
    
    public partial class WorkbookFunctionsXirrRequestBody
    {
    
        /// <summary>
        /// Gets or sets Values.
        /// </summary>
        [JsonPropertyName("values")]
        public System.Text.Json.JsonDocument Values { get; set; }
    
        /// <summary>
        /// Gets or sets Dates.
        /// </summary>
        [JsonPropertyName("dates")]
        public System.Text.Json.JsonDocument Dates { get; set; }
    
        /// <summary>
        /// Gets or sets Guess.
        /// </summary>
        [JsonPropertyName("guess")]
        public System.Text.Json.JsonDocument Guess { get; set; }
    
    }
}
