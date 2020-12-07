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
    /// The type Device Install State.
    /// </summary>
    
    public partial class DeviceInstallState : Entity
    {
    
		///<summary>
		/// The DeviceInstallState constructor
		///</summary>
        public DeviceInstallState()
        {
            this.ODataType = "microsoft.graph.deviceInstallState";
        }
	
        /// <summary>
        /// Gets or sets device id.
        /// Device Id.
        /// </summary>
        [JsonPropertyName("deviceId")]
        public string DeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets device name.
        /// Device name.
        /// </summary>
        [JsonPropertyName("deviceName")]
        public string DeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets error code.
        /// The error code for install failures.
        /// </summary>
        [JsonPropertyName("errorCode")]
        public string ErrorCode { get; set; }
    
        /// <summary>
        /// Gets or sets install state.
        /// The install state of the eBook. Possible values are: notApplicable, installed, failed, notInstalled, uninstallFailed, unknown.
        /// </summary>
        [JsonPropertyName("installState")]
        public InstallState? InstallState { get; set; }
    
        /// <summary>
        /// Gets or sets last sync date time.
        /// Last sync date and time.
        /// </summary>
        [JsonPropertyName("lastSyncDateTime")]
        public DateTimeOffset? LastSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets os description.
        /// OS Description.
        /// </summary>
        [JsonPropertyName("osDescription")]
        public string OsDescription { get; set; }
    
        /// <summary>
        /// Gets or sets os version.
        /// OS Version.
        /// </summary>
        [JsonPropertyName("osVersion")]
        public string OsVersion { get; set; }
    
        /// <summary>
        /// Gets or sets user name.
        /// Device User Name.
        /// </summary>
        [JsonPropertyName("userName")]
        public string UserName { get; set; }
    
    }
}

