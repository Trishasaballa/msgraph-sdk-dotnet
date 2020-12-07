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
    /// The type WorkbookFunctionsStandardizeRequestBody.
    /// </summary>
    
    public partial class WorkbookFunctionsStandardizeRequestBody
    {
    
        /// <summary>
        /// Gets or sets X.
        /// </summary>
        [JsonPropertyName("x")]
        public Newtonsoft.Json.Linq.JToken X { get; set; }
    
        /// <summary>
        /// Gets or sets Mean.
        /// </summary>
        [JsonPropertyName("mean")]
        public Newtonsoft.Json.Linq.JToken Mean { get; set; }
    
        /// <summary>
        /// Gets or sets StandardDev.
        /// </summary>
        [JsonPropertyName("standardDev")]
        public Newtonsoft.Json.Linq.JToken StandardDev { get; set; }
    
    }
}
