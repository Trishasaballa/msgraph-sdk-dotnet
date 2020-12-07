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
    /// The type WorkbookFunctionsHyperlinkRequestBody.
    /// </summary>
    
    public partial class WorkbookFunctionsHyperlinkRequestBody
    {
    
        /// <summary>
        /// Gets or sets LinkLocation.
        /// </summary>
        [JsonPropertyName("linkLocation")]
        public Newtonsoft.Json.Linq.JToken LinkLocation { get; set; }
    
        /// <summary>
        /// Gets or sets FriendlyName.
        /// </summary>
        [JsonPropertyName("friendlyName")]
        public Newtonsoft.Json.Linq.JToken FriendlyName { get; set; }
    
    }
}
