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
    /// The type Device Management Partner.
    /// </summary>
    
    public partial class DeviceManagementPartner : Entity
    {
    
		///<summary>
		/// The DeviceManagementPartner constructor
		///</summary>
        public DeviceManagementPartner()
        {
            this.ODataType = "microsoft.graph.deviceManagementPartner";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// Partner display name
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets is configured.
        /// Whether device management partner is configured or not
        /// </summary>
        [JsonPropertyName("isConfigured")]
        public bool? IsConfigured { get; set; }
    
        /// <summary>
        /// Gets or sets last heartbeat date time.
        /// Timestamp of last heartbeat after admin enabled option Connect to Device management Partner
        /// </summary>
        [JsonPropertyName("lastHeartbeatDateTime")]
        public DateTimeOffset? LastHeartbeatDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets partner app type.
        /// Partner App type. Possible values are: unknown, singleTenantApp, multiTenantApp.
        /// </summary>
        [JsonPropertyName("partnerAppType")]
        public DeviceManagementPartnerAppType? PartnerAppType { get; set; }
    
        /// <summary>
        /// Gets or sets partner state.
        /// Partner state of this tenant. Possible values are: unknown, unavailable, enabled, terminated, rejected, unresponsive.
        /// </summary>
        [JsonPropertyName("partnerState")]
        public DeviceManagementPartnerTenantState? PartnerState { get; set; }
    
        /// <summary>
        /// Gets or sets single tenant app id.
        /// Partner Single tenant App id
        /// </summary>
        [JsonPropertyName("singleTenantAppId")]
        public string SingleTenantAppId { get; set; }
    
        /// <summary>
        /// Gets or sets when partner devices will be marked as non compliant date time.
        /// DateTime in UTC when PartnerDevices will be marked as NonCompliant
        /// </summary>
        [JsonPropertyName("whenPartnerDevicesWillBeMarkedAsNonCompliantDateTime")]
        public DateTimeOffset? WhenPartnerDevicesWillBeMarkedAsNonCompliantDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets when partner devices will be removed date time.
        /// DateTime in UTC when PartnerDevices will be removed
        /// </summary>
        [JsonPropertyName("whenPartnerDevicesWillBeRemovedDateTime")]
        public DateTimeOffset? WhenPartnerDevicesWillBeRemovedDateTime { get; set; }
    
    }
}

