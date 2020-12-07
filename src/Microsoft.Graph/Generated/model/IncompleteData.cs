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
    /// The type IncompleteData.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<IncompleteData>))]
    public partial class IncompleteData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IncompleteData"/> class.
        /// </summary>
        public IncompleteData()
        {
            this.ODataType = "microsoft.graph.incompleteData";
        }

        /// <summary>
        /// Gets or sets missingDataBeforeDateTime.
        /// The service does not have source data before the specified time.
        /// </summary>
        [JsonPropertyName("missingDataBeforeDateTime")]
        public DateTimeOffset? MissingDataBeforeDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets wasThrottled.
        /// Some data was not recorded due to excessive activity.
        /// </summary>
        [JsonPropertyName("wasThrottled")]
        public bool? WasThrottled { get; set; }
    
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
