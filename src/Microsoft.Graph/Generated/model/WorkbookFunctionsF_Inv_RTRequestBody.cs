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
    /// The type WorkbookFunctionsF_Inv_RTRequestBody.
    /// </summary>
    
    public partial class WorkbookFunctionsF_Inv_RTRequestBody
    {
    
        /// <summary>
        /// Gets or sets Probability.
        /// </summary>
        [JsonPropertyName("probability")]
        public Newtonsoft.Json.Linq.JToken Probability { get; set; }
    
        /// <summary>
        /// Gets or sets DegFreedom1.
        /// </summary>
        [JsonPropertyName("degFreedom1")]
        public Newtonsoft.Json.Linq.JToken DegFreedom1 { get; set; }
    
        /// <summary>
        /// Gets or sets DegFreedom2.
        /// </summary>
        [JsonPropertyName("degFreedom2")]
        public Newtonsoft.Json.Linq.JToken DegFreedom2 { get; set; }
    
    }
}
