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
    /// The type UserIdentity.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<UserIdentity>))]
    public partial class UserIdentity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserIdentity"/> class.
        /// </summary>
        public UserIdentity()
        {
            this.ODataType = "microsoft.graph.userIdentity";
        }

        /// <summary>
        /// Gets or sets displayName.
        /// The identity's display name. Note that this may not always be available or up-to-date.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets id.
        /// Unique identifier for the identity.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or sets ipAddress.
        /// Indicates the client IP address used by user performing the activity (audit log only).
        /// </summary>
        [JsonPropertyName("ipAddress")]
        public string IpAddress { get; set; }
    
        /// <summary>
        /// Gets or sets userPrincipalName.
        /// The userPrincipalName attribute of the user.
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
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
