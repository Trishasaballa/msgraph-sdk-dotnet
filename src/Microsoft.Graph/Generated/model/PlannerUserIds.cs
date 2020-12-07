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
    /// The type PlannerUserIds.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<PlannerUserIds>))]
    public partial class PlannerUserIds
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlannerUserIds"/> class.
        /// </summary>
        public PlannerUserIds()
        {
            this.ODataType = "microsoft.graph.plannerUserIds";
        }

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
