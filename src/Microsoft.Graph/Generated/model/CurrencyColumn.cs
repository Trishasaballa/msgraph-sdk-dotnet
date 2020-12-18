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
    /// The type CurrencyColumn.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<CurrencyColumn>))]
    public partial class CurrencyColumn
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyColumn"/> class.
        /// </summary>
        public CurrencyColumn()
        {
            this.ODataType = "microsoft.graph.currencyColumn";
        }

        /// <summary>
        /// Gets or sets locale.
        /// Specifies the locale from which to infer the currency symbol.
        /// </summary>
        [JsonPropertyName("locale")]
        public string Locale { get; set; }
    
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
