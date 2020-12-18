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
    /// The type WorkbookFunctionsTextRequestBody.
    /// </summary>
    
    public partial class WorkbookFunctionsTextRequestBody
    {
    
        /// <summary>
        /// Gets or sets Value.
        /// </summary>
        [JsonPropertyName("value")]
        public System.Text.Json.JsonDocument Value { get; set; }
    
        /// <summary>
        /// Gets or sets FormatText.
        /// </summary>
        [JsonPropertyName("formatText")]
        public System.Text.Json.JsonDocument FormatText { get; set; }
    
    }
}
