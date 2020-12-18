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
    /// The type Remote Assistance Partner.
    /// </summary>
    
    public partial class RemoteAssistancePartner : Entity
    {
    
		///<summary>
		/// The RemoteAssistancePartner constructor
		///</summary>
        public RemoteAssistancePartner()
        {
            this.ODataType = "microsoft.graph.remoteAssistancePartner";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// Display name of the partner.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets last connection date time.
        /// Timestamp of the last request sent to Intune by the TEM partner.
        /// </summary>
        [JsonPropertyName("lastConnectionDateTime")]
        public DateTimeOffset? LastConnectionDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets onboarding status.
        /// TBD. Possible values are: notOnboarded, onboarding, onboarded.
        /// </summary>
        [JsonPropertyName("onboardingStatus")]
        public RemoteAssistanceOnboardingStatus? OnboardingStatus { get; set; }
    
        /// <summary>
        /// Gets or sets onboarding url.
        /// URL of the partner's onboarding portal, where an administrator can configure their Remote Assistance service.
        /// </summary>
        [JsonPropertyName("onboardingUrl")]
        public string OnboardingUrl { get; set; }
    
    }
}

