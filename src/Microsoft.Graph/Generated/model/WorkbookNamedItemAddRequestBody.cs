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
    /// The type WorkbookNamedItemAddRequestBody.
    /// </summary>
    
    public partial class WorkbookNamedItemAddRequestBody
    {
    
        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets Reference.
        /// </summary>
        [JsonPropertyName("reference")]
        public System.Text.Json.JsonDocument Reference { get; set; }
    
        /// <summary>
        /// Gets or sets Comment.
        /// </summary>
        [JsonPropertyName("comment")]
        public string Comment { get; set; }
    
    }
}
