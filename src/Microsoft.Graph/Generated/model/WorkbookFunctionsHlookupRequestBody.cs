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
    /// The type WorkbookFunctionsHlookupRequestBody.
    /// </summary>
    
    public partial class WorkbookFunctionsHlookupRequestBody
    {
    
        /// <summary>
        /// Gets or sets LookupValue.
        /// </summary>
        [JsonPropertyName("lookupValue")]
        public Newtonsoft.Json.Linq.JToken LookupValue { get; set; }
    
        /// <summary>
        /// Gets or sets TableArray.
        /// </summary>
        [JsonPropertyName("tableArray")]
        public Newtonsoft.Json.Linq.JToken TableArray { get; set; }
    
        /// <summary>
        /// Gets or sets RowIndexNum.
        /// </summary>
        [JsonPropertyName("rowIndexNum")]
        public Newtonsoft.Json.Linq.JToken RowIndexNum { get; set; }
    
        /// <summary>
        /// Gets or sets RangeLookup.
        /// </summary>
        [JsonPropertyName("rangeLookup")]
        public Newtonsoft.Json.Linq.JToken RangeLookup { get; set; }
    
    }
}
