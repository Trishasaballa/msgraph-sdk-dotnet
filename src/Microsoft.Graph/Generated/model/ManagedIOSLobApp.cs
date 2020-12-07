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
    /// The type Managed IOSLob App.
    /// </summary>
    
    public partial class ManagedIOSLobApp : ManagedMobileLobApp
    {
    
		///<summary>
		/// The ManagedIOSLobApp constructor
		///</summary>
        public ManagedIOSLobApp()
        {
            this.ODataType = "microsoft.graph.managedIOSLobApp";
        }
	
        /// <summary>
        /// Gets or sets applicable device type.
        /// The iOS architecture for which this app can run on.
        /// </summary>
        [JsonPropertyName("applicableDeviceType")]
        public IosDeviceType ApplicableDeviceType { get; set; }
    
        /// <summary>
        /// Gets or sets build number.
        /// The build number of managed iOS Line of Business (LoB) app.
        /// </summary>
        [JsonPropertyName("buildNumber")]
        public string BuildNumber { get; set; }
    
        /// <summary>
        /// Gets or sets bundle id.
        /// The Identity Name.
        /// </summary>
        [JsonPropertyName("bundleId")]
        public string BundleId { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// The expiration time.
        /// </summary>
        [JsonPropertyName("expirationDateTime")]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets minimum supported operating system.
        /// The value for the minimum applicable operating system.
        /// </summary>
        [JsonPropertyName("minimumSupportedOperatingSystem")]
        public IosMinimumOperatingSystem MinimumSupportedOperatingSystem { get; set; }
    
        /// <summary>
        /// Gets or sets version number.
        /// The version number of managed iOS Line of Business (LoB) app.
        /// </summary>
        [JsonPropertyName("versionNumber")]
        public string VersionNumber { get; set; }
    
    }
}

