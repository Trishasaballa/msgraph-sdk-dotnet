// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type UserFindMeetingTimesRequestBody.
    /// </summary>
    
    public partial class UserFindMeetingTimesRequestBody
    {
    
        /// <summary>
        /// Gets or sets Attendees.
        /// </summary>
        [JsonPropertyName("attendees")]
        public IEnumerable<AttendeeBase> Attendees { get; set; }
    
        /// <summary>
        /// Gets or sets LocationConstraint.
        /// </summary>
        [JsonPropertyName("locationConstraint")]
        public LocationConstraint LocationConstraint { get; set; }
    
        /// <summary>
        /// Gets or sets TimeConstraint.
        /// </summary>
        [JsonPropertyName("timeConstraint")]
        public TimeConstraint TimeConstraint { get; set; }
    
        /// <summary>
        /// Gets or sets MeetingDuration.
        /// </summary>
        [JsonPropertyName("meetingDuration")]
        public Duration MeetingDuration { get; set; }
    
        /// <summary>
        /// Gets or sets MaxCandidates.
        /// </summary>
        [JsonPropertyName("maxCandidates")]
        public Int32? MaxCandidates { get; set; }
    
        /// <summary>
        /// Gets or sets IsOrganizerOptional.
        /// </summary>
        [JsonPropertyName("isOrganizerOptional")]
        public bool? IsOrganizerOptional { get; set; }
    
        /// <summary>
        /// Gets or sets ReturnSuggestionReasons.
        /// </summary>
        [JsonPropertyName("returnSuggestionReasons")]
        public bool? ReturnSuggestionReasons { get; set; }
    
        /// <summary>
        /// Gets or sets MinimumAttendeePercentage.
        /// </summary>
        [JsonPropertyName("minimumAttendeePercentage")]
        public double? MinimumAttendeePercentage { get; set; }
    
    }
}
