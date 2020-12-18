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
    /// The type ScheduleInformation.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ScheduleInformation>))]
    public partial class ScheduleInformation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleInformation"/> class.
        /// </summary>
        public ScheduleInformation()
        {
            this.ODataType = "microsoft.graph.scheduleInformation";
        }

        /// <summary>
        /// Gets or sets availabilityView.
        /// Represents a merged view of availability of all the items in scheduleItems. The view consists of time slots. Availability during each time slot is indicated with: 0= free, 1= tentative, 2= busy, 3= out of office, 4= working elsewhere.
        /// </summary>
        [JsonPropertyName("availabilityView")]
        public string AvailabilityView { get; set; }
    
        /// <summary>
        /// Gets or sets error.
        /// Error information from attempting to get the availability of the user, distribution list, or resource.
        /// </summary>
        [JsonPropertyName("error")]
        public FreeBusyError Error { get; set; }
    
        /// <summary>
        /// Gets or sets scheduleId.
        /// An SMTP address of the user, distribution list, or resource, identifying an instance of scheduleInformation.
        /// </summary>
        [JsonPropertyName("scheduleId")]
        public string ScheduleId { get; set; }
    
        /// <summary>
        /// Gets or sets scheduleItems.
        /// Contains the items that describe the availability of the user or resource.
        /// </summary>
        [JsonPropertyName("scheduleItems")]
        public IEnumerable<ScheduleItem> ScheduleItems { get; set; }
    
        /// <summary>
        /// Gets or sets workingHours.
        /// The days of the week and hours in a specific time zone that the user works. These are set as part of the user's mailboxSettings.
        /// </summary>
        [JsonPropertyName("workingHours")]
        public WorkingHours WorkingHours { get; set; }
    
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
