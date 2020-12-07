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
    /// The type Win32LobAppRule.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Win32LobAppRule>))]
    public abstract partial class Win32LobAppRule
    {

        /// <summary>
        /// Gets or sets ruleType.
        /// The rule type indicating the purpose of the rule. Possible values are: detection, requirement.
        /// </summary>
        [JsonPropertyName("ruleType")]
        public Win32LobAppRuleType? RuleType { get; set; }
    
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
