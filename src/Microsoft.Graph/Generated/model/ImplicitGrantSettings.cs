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
    /// The type ImplicitGrantSettings.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ImplicitGrantSettings>))]
    public partial class ImplicitGrantSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImplicitGrantSettings"/> class.
        /// </summary>
        public ImplicitGrantSettings()
        {
            this.ODataType = "microsoft.graph.implicitGrantSettings";
        }

        /// <summary>
        /// Gets or sets enableAccessTokenIssuance.
        /// Specifies whether this web application can request an access token using the OAuth 2.0 implicit flow.
        /// </summary>
        [JsonPropertyName("enableAccessTokenIssuance")]
        public bool? EnableAccessTokenIssuance { get; set; }
    
        /// <summary>
        /// Gets or sets enableIdTokenIssuance.
        /// Specifies whether this web application can request an ID token using the OAuth 2.0 implicit flow.
        /// </summary>
        [JsonPropertyName("enableIdTokenIssuance")]
        public bool? EnableIdTokenIssuance { get; set; }
    
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
