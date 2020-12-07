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
    /// The type WebApplication.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<WebApplication>))]
    public partial class WebApplication
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebApplication"/> class.
        /// </summary>
        public WebApplication()
        {
            this.ODataType = "microsoft.graph.webApplication";
        }

        /// <summary>
        /// Gets or sets homePageUrl.
        /// Home page or landing page of the application.
        /// </summary>
        [JsonPropertyName("homePageUrl")]
        public string HomePageUrl { get; set; }
    
        /// <summary>
        /// Gets or sets implicitGrantSettings.
        /// Specifies whether this web application can request tokens using the OAuth 2.0 implicit flow.
        /// </summary>
        [JsonPropertyName("implicitGrantSettings")]
        public ImplicitGrantSettings ImplicitGrantSettings { get; set; }
    
        /// <summary>
        /// Gets or sets logoutUrl.
        /// Specifies the URL that will be used by Microsoft's authorization service to logout an user using front-channel, back-channel or SAML logout protocols.
        /// </summary>
        [JsonPropertyName("logoutUrl")]
        public string LogoutUrl { get; set; }
    
        /// <summary>
        /// Gets or sets redirectUris.
        /// Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.
        /// </summary>
        [JsonPropertyName("redirectUris")]
        public IEnumerable<string> RedirectUris { get; set; }
    
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
