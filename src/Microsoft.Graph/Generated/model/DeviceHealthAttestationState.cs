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
    /// The type DeviceHealthAttestationState.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeviceHealthAttestationState>))]
    public partial class DeviceHealthAttestationState
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceHealthAttestationState"/> class.
        /// </summary>
        public DeviceHealthAttestationState()
        {
            this.ODataType = "microsoft.graph.deviceHealthAttestationState";
        }

        /// <summary>
        /// Gets or sets attestationIdentityKey.
        /// TWhen an Attestation Identity Key (AIK) is present on a device, it indicates that the device has an endorsement key (EK) certificate.
        /// </summary>
        [JsonPropertyName("attestationIdentityKey")]
        public string AttestationIdentityKey { get; set; }
    
        /// <summary>
        /// Gets or sets bitLockerStatus.
        /// On or Off of BitLocker Drive Encryption
        /// </summary>
        [JsonPropertyName("bitLockerStatus")]
        public string BitLockerStatus { get; set; }
    
        /// <summary>
        /// Gets or sets bootAppSecurityVersion.
        /// The security version number of the Boot Application
        /// </summary>
        [JsonPropertyName("bootAppSecurityVersion")]
        public string BootAppSecurityVersion { get; set; }
    
        /// <summary>
        /// Gets or sets bootDebugging.
        /// When bootDebugging is enabled, the device is used in development and testing
        /// </summary>
        [JsonPropertyName("bootDebugging")]
        public string BootDebugging { get; set; }
    
        /// <summary>
        /// Gets or sets bootManagerSecurityVersion.
        /// The security version number of the Boot Application
        /// </summary>
        [JsonPropertyName("bootManagerSecurityVersion")]
        public string BootManagerSecurityVersion { get; set; }
    
        /// <summary>
        /// Gets or sets bootManagerVersion.
        /// The version of the Boot Manager
        /// </summary>
        [JsonPropertyName("bootManagerVersion")]
        public string BootManagerVersion { get; set; }
    
        /// <summary>
        /// Gets or sets bootRevisionListInfo.
        /// The Boot Revision List that was loaded during initial boot on the attested device
        /// </summary>
        [JsonPropertyName("bootRevisionListInfo")]
        public string BootRevisionListInfo { get; set; }
    
        /// <summary>
        /// Gets or sets codeIntegrity.
        /// When code integrity is enabled, code execution is restricted to integrity verified code
        /// </summary>
        [JsonPropertyName("codeIntegrity")]
        public string CodeIntegrity { get; set; }
    
        /// <summary>
        /// Gets or sets codeIntegrityCheckVersion.
        /// The version of the Boot Manager
        /// </summary>
        [JsonPropertyName("codeIntegrityCheckVersion")]
        public string CodeIntegrityCheckVersion { get; set; }
    
        /// <summary>
        /// Gets or sets codeIntegrityPolicy.
        /// The Code Integrity policy that is controlling the security of the boot environment
        /// </summary>
        [JsonPropertyName("codeIntegrityPolicy")]
        public string CodeIntegrityPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets contentNamespaceUrl.
        /// The DHA report version. (Namespace version)
        /// </summary>
        [JsonPropertyName("contentNamespaceUrl")]
        public string ContentNamespaceUrl { get; set; }
    
        /// <summary>
        /// Gets or sets contentVersion.
        /// The HealthAttestation state schema version
        /// </summary>
        [JsonPropertyName("contentVersion")]
        public string ContentVersion { get; set; }
    
        /// <summary>
        /// Gets or sets dataExcutionPolicy.
        /// DEP Policy defines a set of hardware and software technologies that perform additional checks on memory
        /// </summary>
        [JsonPropertyName("dataExcutionPolicy")]
        public string DataExcutionPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets deviceHealthAttestationStatus.
        /// The DHA report version. (Namespace version)
        /// </summary>
        [JsonPropertyName("deviceHealthAttestationStatus")]
        public string DeviceHealthAttestationStatus { get; set; }
    
        /// <summary>
        /// Gets or sets earlyLaunchAntiMalwareDriverProtection.
        /// ELAM provides protection for the computers in your network when they start up
        /// </summary>
        [JsonPropertyName("earlyLaunchAntiMalwareDriverProtection")]
        public string EarlyLaunchAntiMalwareDriverProtection { get; set; }
    
        /// <summary>
        /// Gets or sets healthAttestationSupportedStatus.
        /// This attribute indicates if DHA is supported for the device
        /// </summary>
        [JsonPropertyName("healthAttestationSupportedStatus")]
        public string HealthAttestationSupportedStatus { get; set; }
    
        /// <summary>
        /// Gets or sets healthStatusMismatchInfo.
        /// This attribute appears if DHA-Service detects an integrity issue
        /// </summary>
        [JsonPropertyName("healthStatusMismatchInfo")]
        public string HealthStatusMismatchInfo { get; set; }
    
        /// <summary>
        /// Gets or sets issuedDateTime.
        /// The DateTime when device was evaluated or issued to MDM
        /// </summary>
        [JsonPropertyName("issuedDateTime")]
        public DateTimeOffset? IssuedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets lastUpdateDateTime.
        /// The Timestamp of the last update.
        /// </summary>
        [JsonPropertyName("lastUpdateDateTime")]
        public string LastUpdateDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets operatingSystemKernelDebugging.
        /// When operatingSystemKernelDebugging is enabled, the device is used in development and testing
        /// </summary>
        [JsonPropertyName("operatingSystemKernelDebugging")]
        public string OperatingSystemKernelDebugging { get; set; }
    
        /// <summary>
        /// Gets or sets operatingSystemRevListInfo.
        /// The Operating System Revision List that was loaded during initial boot on the attested device
        /// </summary>
        [JsonPropertyName("operatingSystemRevListInfo")]
        public string OperatingSystemRevListInfo { get; set; }
    
        /// <summary>
        /// Gets or sets pcr0.
        /// The measurement that is captured in PCR[0]
        /// </summary>
        [JsonPropertyName("pcr0")]
        public string Pcr0 { get; set; }
    
        /// <summary>
        /// Gets or sets pcrHashAlgorithm.
        /// Informational attribute that identifies the HASH algorithm that was used by TPM
        /// </summary>
        [JsonPropertyName("pcrHashAlgorithm")]
        public string PcrHashAlgorithm { get; set; }
    
        /// <summary>
        /// Gets or sets resetCount.
        /// The number of times a PC device has hibernated or resumed
        /// </summary>
        [JsonPropertyName("resetCount")]
        public Int64? ResetCount { get; set; }
    
        /// <summary>
        /// Gets or sets restartCount.
        /// The number of times a PC device has rebooted
        /// </summary>
        [JsonPropertyName("restartCount")]
        public Int64? RestartCount { get; set; }
    
        /// <summary>
        /// Gets or sets safeMode.
        /// Safe mode is a troubleshooting option for Windows that starts your computer in a limited state
        /// </summary>
        [JsonPropertyName("safeMode")]
        public string SafeMode { get; set; }
    
        /// <summary>
        /// Gets or sets secureBoot.
        /// When Secure Boot is enabled, the core components must have the correct cryptographic signatures
        /// </summary>
        [JsonPropertyName("secureBoot")]
        public string SecureBoot { get; set; }
    
        /// <summary>
        /// Gets or sets secureBootConfigurationPolicyFingerPrint.
        /// Fingerprint of the Custom Secure Boot Configuration Policy
        /// </summary>
        [JsonPropertyName("secureBootConfigurationPolicyFingerPrint")]
        public string SecureBootConfigurationPolicyFingerPrint { get; set; }
    
        /// <summary>
        /// Gets or sets testSigning.
        /// When test signing is allowed, the device does not enforce signature validation during boot
        /// </summary>
        [JsonPropertyName("testSigning")]
        public string TestSigning { get; set; }
    
        /// <summary>
        /// Gets or sets tpmVersion.
        /// The security version number of the Boot Application
        /// </summary>
        [JsonPropertyName("tpmVersion")]
        public string TpmVersion { get; set; }
    
        /// <summary>
        /// Gets or sets virtualSecureMode.
        /// VSM is a container that protects high value assets from a compromised kernel
        /// </summary>
        [JsonPropertyName("virtualSecureMode")]
        public string VirtualSecureMode { get; set; }
    
        /// <summary>
        /// Gets or sets windowsPE.
        /// Operating system running with limited services that is used to prepare a computer for Windows
        /// </summary>
        [JsonPropertyName("windowsPE")]
        public string WindowsPE { get; set; }
    
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
