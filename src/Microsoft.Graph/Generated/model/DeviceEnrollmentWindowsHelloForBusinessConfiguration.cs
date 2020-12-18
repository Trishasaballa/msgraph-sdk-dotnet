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
    /// The type Device Enrollment Windows Hello For Business Configuration.
    /// </summary>
    
    public partial class DeviceEnrollmentWindowsHelloForBusinessConfiguration : DeviceEnrollmentConfiguration
    {
    
		///<summary>
		/// The DeviceEnrollmentWindowsHelloForBusinessConfiguration constructor
		///</summary>
        public DeviceEnrollmentWindowsHelloForBusinessConfiguration()
        {
            this.ODataType = "microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration";
        }
	
        /// <summary>
        /// Gets or sets enhanced biometrics state.
        /// Not yet documented. Possible values are: notConfigured, enabled, disabled.
        /// </summary>
        [JsonPropertyName("enhancedBiometricsState")]
        public Enablement? EnhancedBiometricsState { get; set; }
    
        /// <summary>
        /// Gets or sets pin expiration in days.
        /// Not yet documented
        /// </summary>
        [JsonPropertyName("pinExpirationInDays")]
        public Int32? PinExpirationInDays { get; set; }
    
        /// <summary>
        /// Gets or sets pin lowercase characters usage.
        /// Not yet documented. Possible values are: allowed, required, disallowed.
        /// </summary>
        [JsonPropertyName("pinLowercaseCharactersUsage")]
        public WindowsHelloForBusinessPinUsage? PinLowercaseCharactersUsage { get; set; }
    
        /// <summary>
        /// Gets or sets pin maximum length.
        /// Not yet documented
        /// </summary>
        [JsonPropertyName("pinMaximumLength")]
        public Int32? PinMaximumLength { get; set; }
    
        /// <summary>
        /// Gets or sets pin minimum length.
        /// Not yet documented
        /// </summary>
        [JsonPropertyName("pinMinimumLength")]
        public Int32? PinMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets pin previous block count.
        /// Not yet documented
        /// </summary>
        [JsonPropertyName("pinPreviousBlockCount")]
        public Int32? PinPreviousBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets pin special characters usage.
        /// Not yet documented. Possible values are: allowed, required, disallowed.
        /// </summary>
        [JsonPropertyName("pinSpecialCharactersUsage")]
        public WindowsHelloForBusinessPinUsage? PinSpecialCharactersUsage { get; set; }
    
        /// <summary>
        /// Gets or sets pin uppercase characters usage.
        /// Not yet documented. Possible values are: allowed, required, disallowed.
        /// </summary>
        [JsonPropertyName("pinUppercaseCharactersUsage")]
        public WindowsHelloForBusinessPinUsage? PinUppercaseCharactersUsage { get; set; }
    
        /// <summary>
        /// Gets or sets remote passport enabled.
        /// Not yet documented
        /// </summary>
        [JsonPropertyName("remotePassportEnabled")]
        public bool? RemotePassportEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets security device required.
        /// Not yet documented
        /// </summary>
        [JsonPropertyName("securityDeviceRequired")]
        public bool? SecurityDeviceRequired { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// Not yet documented. Possible values are: notConfigured, enabled, disabled.
        /// </summary>
        [JsonPropertyName("state")]
        public Enablement? State { get; set; }
    
        /// <summary>
        /// Gets or sets unlock with biometrics enabled.
        /// Not yet documented
        /// </summary>
        [JsonPropertyName("unlockWithBiometricsEnabled")]
        public bool? UnlockWithBiometricsEnabled { get; set; }
    
    }
}

