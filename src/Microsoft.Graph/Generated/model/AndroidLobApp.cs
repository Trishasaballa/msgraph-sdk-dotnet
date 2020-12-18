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
    /// The type Android Lob App.
    /// </summary>
    
    public partial class AndroidLobApp : MobileLobApp
    {
    
		///<summary>
		/// The AndroidLobApp constructor
		///</summary>
        public AndroidLobApp()
        {
            this.ODataType = "microsoft.graph.androidLobApp";
        }
	
        /// <summary>
        /// Gets or sets minimum supported operating system.
        /// The value for the minimum applicable operating system.
        /// </summary>
        [JsonPropertyName("minimumSupportedOperatingSystem")]
        public AndroidMinimumOperatingSystem MinimumSupportedOperatingSystem { get; set; }
    
        /// <summary>
        /// Gets or sets package id.
        /// The package identifier.
        /// </summary>
        [JsonPropertyName("packageId")]
        public string PackageId { get; set; }
    
        /// <summary>
        /// Gets or sets version code.
        /// The version code of Android Line of Business (LoB) app.
        /// </summary>
        [JsonPropertyName("versionCode")]
        public string VersionCode { get; set; }
    
        /// <summary>
        /// Gets or sets version name.
        /// The version name of Android Line of Business (LoB) app.
        /// </summary>
        [JsonPropertyName("versionName")]
        public string VersionName { get; set; }
    
    }
}

