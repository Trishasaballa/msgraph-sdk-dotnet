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
    /// The type ConditionalAccessGrantControls.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ConditionalAccessGrantControls>))]
    public partial class ConditionalAccessGrantControls
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalAccessGrantControls"/> class.
        /// </summary>
        public ConditionalAccessGrantControls()
        {
            this.ODataType = "microsoft.graph.conditionalAccessGrantControls";
        }

        /// <summary>
        /// Gets or sets builtInControls.
        /// List of values of built-in controls required by the policy. Possible values: Block, Mfa, CompliantDevice, DomainJoinedDevice, ApprovedApplication, CompliantApplication
        /// </summary>
        [JsonPropertyName("builtInControls")]
        public IEnumerable<ConditionalAccessGrantControl> BuiltInControls { get; set; }
    
        /// <summary>
        /// Gets or sets customAuthenticationFactors.
        /// List of custom controls IDs required by the policy. For more information, see Custom controls.
        /// </summary>
        [JsonPropertyName("customAuthenticationFactors")]
        public IEnumerable<string> CustomAuthenticationFactors { get; set; }
    
        /// <summary>
        /// Gets or sets operator.
        /// Defines the relationship of the grant controls. Possible values: AND, OR.
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }
    
        /// <summary>
        /// Gets or sets termsOfUse.
        /// List of terms of use IDs required by the policy.
        /// </summary>
        [JsonPropertyName("termsOfUse")]
        public IEnumerable<string> TermsOfUse { get; set; }
    
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
