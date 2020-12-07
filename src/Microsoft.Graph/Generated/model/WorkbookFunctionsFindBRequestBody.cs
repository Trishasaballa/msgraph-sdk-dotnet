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
    /// The type WorkbookFunctionsFindBRequestBody.
    /// </summary>
    
    public partial class WorkbookFunctionsFindBRequestBody
    {
    
        /// <summary>
        /// Gets or sets FindText.
        /// </summary>
        [JsonPropertyName("findText")]
        public System.Text.Json.JsonDocument FindText { get; set; }
    
        /// <summary>
        /// Gets or sets WithinText.
        /// </summary>
        [JsonPropertyName("withinText")]
        public System.Text.Json.JsonDocument WithinText { get; set; }
    
        /// <summary>
        /// Gets or sets StartNum.
        /// </summary>
        [JsonPropertyName("startNum")]
        public System.Text.Json.JsonDocument StartNum { get; set; }
    
    }
}
