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
    /// The type KeyValue.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<KeyValue>))]
    public partial class KeyValue
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KeyValue"/> class.
        /// </summary>
        public KeyValue()
        {
            this.ODataType = "microsoft.graph.keyValue";
        }

        /// <summary>
        /// Gets or sets key.
        /// Key for the key-value pair.
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }
    
        /// <summary>
        /// Gets or sets value.
        /// Value for the key-value pair.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    
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
