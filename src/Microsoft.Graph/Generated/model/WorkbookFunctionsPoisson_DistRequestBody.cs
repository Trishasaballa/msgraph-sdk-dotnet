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
    /// The type WorkbookFunctionsPoisson_DistRequestBody.
    /// </summary>
    
    public partial class WorkbookFunctionsPoisson_DistRequestBody
    {
    
        /// <summary>
        /// Gets or sets X.
        /// </summary>
        [JsonPropertyName("x")]
        public System.Text.Json.JsonDocument X { get; set; }
    
        /// <summary>
        /// Gets or sets Mean.
        /// </summary>
        [JsonPropertyName("mean")]
        public System.Text.Json.JsonDocument Mean { get; set; }
    
        /// <summary>
        /// Gets or sets Cumulative.
        /// </summary>
        [JsonPropertyName("cumulative")]
        public System.Text.Json.JsonDocument Cumulative { get; set; }
    
    }
}
