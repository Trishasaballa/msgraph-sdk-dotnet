// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Mobile Threat Defense Connector.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MobileThreatDefenseConnector : Entity
    {
    
		///<summary>
		/// The MobileThreatDefenseConnector constructor
		///</summary>
        public MobileThreatDefenseConnector()
        {
            this.ODataType = "microsoft.graph.mobileThreatDefenseConnector";
        }
	
        /// <summary>
        /// Gets or sets android device blocked on missing partner data.
        /// For Android, set whether Intune must receive data from the data sync partner prior to marking a device compliant
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "androidDeviceBlockedOnMissingPartnerData", Required = Newtonsoft.Json.Required.Default)]
        public bool? AndroidDeviceBlockedOnMissingPartnerData { get; set; }
    
        /// <summary>
        /// Gets or sets android enabled.
        /// For Android, set whether data from the data sync partner should be used during compliance evaluations
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "androidEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? AndroidEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets ios device blocked on missing partner data.
        /// For IOS, set whether Intune must receive data from the data sync partner prior to marking a device compliant
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "iosDeviceBlockedOnMissingPartnerData", Required = Newtonsoft.Json.Required.Default)]
        public bool? IosDeviceBlockedOnMissingPartnerData { get; set; }
    
        /// <summary>
        /// Gets or sets ios enabled.
        /// For IOS, get or set whether data from the data sync partner should be used during compliance evaluations
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "iosEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? IosEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets last heartbeat date time.
        /// DateTime of last Heartbeat recieved from the Data Sync Partner
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastHeartbeatDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastHeartbeatDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets partner state.
        /// Data Sync Partner state for this account. Possible values are: unavailable, available, enabled, unresponsive.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "partnerState", Required = Newtonsoft.Json.Required.Default)]
        public MobileThreatPartnerTenantState? PartnerState { get; set; }
    
        /// <summary>
        /// Gets or sets partner unresponsiveness threshold in days.
        /// Get or Set days the per tenant tolerance to unresponsiveness for this partner integration
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "partnerUnresponsivenessThresholdInDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PartnerUnresponsivenessThresholdInDays { get; set; }
    
        /// <summary>
        /// Gets or sets partner unsupported os version blocked.
        /// Get or set whether to block devices on the enabled platforms that do not meet the minimum version requirements of the Data Sync Partner
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "partnerUnsupportedOsVersionBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? PartnerUnsupportedOsVersionBlocked { get; set; }
    
    }
}

