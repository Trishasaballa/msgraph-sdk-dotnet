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
    /// The type Device App Management.
    /// </summary>
    
    public partial class DeviceAppManagement : Entity
    {
    
		///<summary>
		/// The DeviceAppManagement constructor
		///</summary>
        public DeviceAppManagement()
        {
            this.ODataType = "microsoft.graph.deviceAppManagement";
        }
	
        /// <summary>
        /// Gets or sets is enabled for microsoft store for business.
        /// Whether the account is enabled for syncing applications from the Microsoft Store for Business.
        /// </summary>
        [JsonPropertyName("isEnabledForMicrosoftStoreForBusiness")]
        public bool? IsEnabledForMicrosoftStoreForBusiness { get; set; }
    
        /// <summary>
        /// Gets or sets microsoft store for business language.
        /// The locale information used to sync applications from the Microsoft Store for Business. Cultures that are specific to a country/region. The names of these cultures follow RFC 4646 (Windows Vista and later). The format is -&amp;lt;country/regioncode2&amp;gt;, where  is a lowercase two-letter code derived from ISO 639-1 and &amp;lt;country/regioncode2&amp;gt; is an uppercase two-letter code derived from ISO 3166. For example, en-US for English (United States) is a specific culture.
        /// </summary>
        [JsonPropertyName("microsoftStoreForBusinessLanguage")]
        public string MicrosoftStoreForBusinessLanguage { get; set; }
    
        /// <summary>
        /// Gets or sets microsoft store for business last completed application sync time.
        /// The last time an application sync from the Microsoft Store for Business was completed.
        /// </summary>
        [JsonPropertyName("microsoftStoreForBusinessLastCompletedApplicationSyncTime")]
        public DateTimeOffset? MicrosoftStoreForBusinessLastCompletedApplicationSyncTime { get; set; }
    
        /// <summary>
        /// Gets or sets microsoft store for business last successful sync date time.
        /// The last time the apps from the Microsoft Store for Business were synced successfully for the account.
        /// </summary>
        [JsonPropertyName("microsoftStoreForBusinessLastSuccessfulSyncDateTime")]
        public DateTimeOffset? MicrosoftStoreForBusinessLastSuccessfulSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets managed ebooks.
        /// The Managed eBook.
        /// </summary>
        [JsonPropertyName("managedEBooks")]
        public IDeviceAppManagementManagedEBooksCollectionPage ManagedEBooks { get; set; }
    
        /// <summary>
        /// Gets or sets mobile app categories.
        /// The mobile app categories.
        /// </summary>
        [JsonPropertyName("mobileAppCategories")]
        public IDeviceAppManagementMobileAppCategoriesCollectionPage MobileAppCategories { get; set; }
    
        /// <summary>
        /// Gets or sets mobile app configurations.
        /// The Managed Device Mobile Application Configurations.
        /// </summary>
        [JsonPropertyName("mobileAppConfigurations")]
        public IDeviceAppManagementMobileAppConfigurationsCollectionPage MobileAppConfigurations { get; set; }
    
        /// <summary>
        /// Gets or sets mobile apps.
        /// The mobile apps.
        /// </summary>
        [JsonPropertyName("mobileApps")]
        public IDeviceAppManagementMobileAppsCollectionPage MobileApps { get; set; }
    
        /// <summary>
        /// Gets or sets vpp tokens.
        /// List of Vpp tokens for this organization.
        /// </summary>
        [JsonPropertyName("vppTokens")]
        public IDeviceAppManagementVppTokensCollectionPage VppTokens { get; set; }
    
        /// <summary>
        /// Gets or sets android managed app protections.
        /// Android managed app policies.
        /// </summary>
        [JsonPropertyName("androidManagedAppProtections")]
        public IDeviceAppManagementAndroidManagedAppProtectionsCollectionPage AndroidManagedAppProtections { get; set; }
    
        /// <summary>
        /// Gets or sets default managed app protections.
        /// Default managed app policies.
        /// </summary>
        [JsonPropertyName("defaultManagedAppProtections")]
        public IDeviceAppManagementDefaultManagedAppProtectionsCollectionPage DefaultManagedAppProtections { get; set; }
    
        /// <summary>
        /// Gets or sets ios managed app protections.
        /// iOS managed app policies.
        /// </summary>
        [JsonPropertyName("iosManagedAppProtections")]
        public IDeviceAppManagementIosManagedAppProtectionsCollectionPage IosManagedAppProtections { get; set; }
    
        /// <summary>
        /// Gets or sets managed app policies.
        /// Managed app policies.
        /// </summary>
        [JsonPropertyName("managedAppPolicies")]
        public IDeviceAppManagementManagedAppPoliciesCollectionPage ManagedAppPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets managed app registrations.
        /// The managed app registrations.
        /// </summary>
        [JsonPropertyName("managedAppRegistrations")]
        public IDeviceAppManagementManagedAppRegistrationsCollectionPage ManagedAppRegistrations { get; set; }
    
        /// <summary>
        /// Gets or sets managed app statuses.
        /// The managed app statuses.
        /// </summary>
        [JsonPropertyName("managedAppStatuses")]
        public IDeviceAppManagementManagedAppStatusesCollectionPage ManagedAppStatuses { get; set; }
    
        /// <summary>
        /// Gets or sets mdm windows information protection policies.
        /// Windows information protection for apps running on devices which are MDM enrolled.
        /// </summary>
        [JsonPropertyName("mdmWindowsInformationProtectionPolicies")]
        public IDeviceAppManagementMdmWindowsInformationProtectionPoliciesCollectionPage MdmWindowsInformationProtectionPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets targeted managed app configurations.
        /// Targeted managed app configurations.
        /// </summary>
        [JsonPropertyName("targetedManagedAppConfigurations")]
        public IDeviceAppManagementTargetedManagedAppConfigurationsCollectionPage TargetedManagedAppConfigurations { get; set; }
    
        /// <summary>
        /// Gets or sets windows information protection policies.
        /// Windows information protection for apps running on devices which are not MDM enrolled.
        /// </summary>
        [JsonPropertyName("windowsInformationProtectionPolicies")]
        public IDeviceAppManagementWindowsInformationProtectionPoliciesCollectionPage WindowsInformationProtectionPolicies { get; set; }
    
    }
}

