// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Vpp Token.
    /// </summary>
    
    public partial class VppToken : Entity
    {
    
		///<summary>
		/// The VppToken constructor
		///</summary>
        public VppToken()
        {
            this.ODataType = "microsoft.graph.vppToken";
        }
	
        /// <summary>
        /// Gets or sets apple id.
        /// The apple Id associated with the given Apple Volume Purchase Program Token.
        /// </summary>
        [JsonPropertyName("appleId")]
        public string AppleId { get; set; }
    
        /// <summary>
        /// Gets or sets automatically update apps.
        /// Whether or not apps for the VPP token will be automatically updated.
        /// </summary>
        [JsonPropertyName("automaticallyUpdateApps")]
        public bool? AutomaticallyUpdateApps { get; set; }
    
        /// <summary>
        /// Gets or sets country or region.
        /// Whether or not apps for the VPP token will be automatically updated.
        /// </summary>
        [JsonPropertyName("countryOrRegion")]
        public string CountryOrRegion { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// The expiration date time of the Apple Volume Purchase Program Token.
        /// </summary>
        [JsonPropertyName("expirationDateTime")]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Last modification date time associated with the Apple Volume Purchase Program Token.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last sync date time.
        /// The last time when an application sync was done with the Apple volume purchase program service using the Apple Volume Purchase Program Token.
        /// </summary>
        [JsonPropertyName("lastSyncDateTime")]
        public DateTimeOffset? LastSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last sync status.
        /// Current sync status of the last application sync which was triggered using the Apple Volume Purchase Program Token. Possible values are: none, inProgress, completed, failed. Possible values are: none, inProgress, completed, failed.
        /// </summary>
        [JsonPropertyName("lastSyncStatus")]
        public VppTokenSyncStatus? LastSyncStatus { get; set; }
    
        /// <summary>
        /// Gets or sets organization name.
        /// The organization associated with the Apple Volume Purchase Program Token
        /// </summary>
        [JsonPropertyName("organizationName")]
        public string OrganizationName { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// Current state of the Apple Volume Purchase Program Token. Possible values are: unknown, valid, expired, invalid, assignedToExternalMDM. Possible values are: unknown, valid, expired, invalid, assignedToExternalMDM.
        /// </summary>
        [JsonPropertyName("state")]
        public VppTokenState? State { get; set; }
    
        /// <summary>
        /// Gets or sets token.
        /// The Apple Volume Purchase Program Token string downloaded from the Apple Volume Purchase Program.
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; }
    
        /// <summary>
        /// Gets or sets vpp token account type.
        /// The type of volume purchase program which the given Apple Volume Purchase Program Token is associated with. Possible values are: business, education. Possible values are: business, education.
        /// </summary>
        [JsonPropertyName("vppTokenAccountType")]
        public VppTokenAccountType? VppTokenAccountType { get; set; }
    
    }
}

