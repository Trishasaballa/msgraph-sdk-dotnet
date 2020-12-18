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
    /// The type WorkbookFunctionsPriceDiscRequestBody.
    /// </summary>
    
    public partial class WorkbookFunctionsPriceDiscRequestBody
    {
    
        /// <summary>
        /// Gets or sets Settlement.
        /// </summary>
        [JsonPropertyName("settlement")]
        public System.Text.Json.JsonDocument Settlement { get; set; }
    
        /// <summary>
        /// Gets or sets Maturity.
        /// </summary>
        [JsonPropertyName("maturity")]
        public System.Text.Json.JsonDocument Maturity { get; set; }
    
        /// <summary>
        /// Gets or sets Discount.
        /// </summary>
        [JsonPropertyName("discount")]
        public System.Text.Json.JsonDocument Discount { get; set; }
    
        /// <summary>
        /// Gets or sets Redemption.
        /// </summary>
        [JsonPropertyName("redemption")]
        public System.Text.Json.JsonDocument Redemption { get; set; }
    
        /// <summary>
        /// Gets or sets Basis.
        /// </summary>
        [JsonPropertyName("basis")]
        public System.Text.Json.JsonDocument Basis { get; set; }
    
    }
}
