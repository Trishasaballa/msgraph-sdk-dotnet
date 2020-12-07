// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type SearchQuery.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SearchQuery>))]
    public partial class SearchQuery
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchQuery"/> class.
        /// </summary>
        public SearchQuery()
        {
            this.ODataType = "microsoft.graph.searchQuery";
        }

        /// <summary>
        /// Gets or sets queryString.
        /// </summary>
        [JsonPropertyName("queryString")]
        public string QueryString { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
