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
    /// The type MobileAppInstallTimeSettings.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MobileAppInstallTimeSettings>))]
    public partial class MobileAppInstallTimeSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MobileAppInstallTimeSettings"/> class.
        /// </summary>
        public MobileAppInstallTimeSettings()
        {
            this.ODataType = "microsoft.graph.mobileAppInstallTimeSettings";
        }

        /// <summary>
        /// Gets or sets deadlineDateTime.
        /// The time at which the app should be installed.
        /// </summary>
        [JsonPropertyName("deadlineDateTime")]
        public DateTimeOffset? DeadlineDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets startDateTime.
        /// The time at which the app should be available for installation.
        /// </summary>
        [JsonPropertyName("startDateTime")]
        public DateTimeOffset? StartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets useLocalTime.
        /// Whether the local device time or UTC time should be used when determining the available and deadline times.
        /// </summary>
        [JsonPropertyName("useLocalTime")]
        public bool? UseLocalTime { get; set; }
    
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
