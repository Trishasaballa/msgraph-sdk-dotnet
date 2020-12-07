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
    /// The type ScheduleItem.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ScheduleItem>))]
    public partial class ScheduleItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleItem"/> class.
        /// </summary>
        public ScheduleItem()
        {
            this.ODataType = "microsoft.graph.scheduleItem";
        }

        /// <summary>
        /// Gets or sets end.
        /// The date, time, and time zone that the corresponding event ends.
        /// </summary>
        [JsonPropertyName("end")]
        public DateTimeTimeZone End { get; set; }
    
        /// <summary>
        /// Gets or sets isPrivate.
        /// The sensitivity of the corresponding event. True if the event is marked private, false otherwise. Optional.
        /// </summary>
        [JsonPropertyName("isPrivate")]
        public bool? IsPrivate { get; set; }
    
        /// <summary>
        /// Gets or sets location.
        /// The location where the corresponding event is held or attended from. Optional.
        /// </summary>
        [JsonPropertyName("location")]
        public string Location { get; set; }
    
        /// <summary>
        /// Gets or sets start.
        /// The date, time, and time zone that the corresponding event starts.
        /// </summary>
        [JsonPropertyName("start")]
        public DateTimeTimeZone Start { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// The availability status of the user or resource during the corresponding event. The possible values are: free, tentative, busy, oof, workingElsewhere, unknown.
        /// </summary>
        [JsonPropertyName("status")]
        public FreeBusyStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets subject.
        /// The corresponding event's subject line. Optional.
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }
    
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
