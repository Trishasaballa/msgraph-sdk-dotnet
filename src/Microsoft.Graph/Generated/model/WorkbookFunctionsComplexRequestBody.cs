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
    /// The type WorkbookFunctionsComplexRequestBody.
    /// </summary>
    
    public partial class WorkbookFunctionsComplexRequestBody
    {
    
        /// <summary>
        /// Gets or sets RealNum.
        /// </summary>
        [JsonPropertyName("realNum")]
        public Newtonsoft.Json.Linq.JToken RealNum { get; set; }
    
        /// <summary>
        /// Gets or sets INum.
        /// </summary>
        [JsonPropertyName("iNum")]
        public Newtonsoft.Json.Linq.JToken INum { get; set; }
    
        /// <summary>
        /// Gets or sets Suffix.
        /// </summary>
        [JsonPropertyName("suffix")]
        public Newtonsoft.Json.Linq.JToken Suffix { get; set; }
    
    }
}
