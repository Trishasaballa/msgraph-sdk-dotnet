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
    /// The type Schedule.
    /// </summary>
    
    public partial class Schedule : Entity
    {
    
		///<summary>
		/// The Schedule constructor
		///</summary>
        public Schedule()
        {
            this.ODataType = "microsoft.graph.schedule";
        }
	
        /// <summary>
        /// Gets or sets enabled.
        /// Indicates whether the schedule is enabled for the team. Required.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
    
        /// <summary>
        /// Gets or sets offer shift requests enabled.
        /// Indicates whether offer shift requests are enabled for the schedule.
        /// </summary>
        [JsonPropertyName("offerShiftRequestsEnabled")]
        public bool? OfferShiftRequestsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets open shifts enabled.
        /// Indicates whether open shifts are enabled for the schedule.
        /// </summary>
        [JsonPropertyName("openShiftsEnabled")]
        public bool? OpenShiftsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets provision status.
        /// The status of the schedule provisioning. The possible values are notStarted, running, completed, failed.
        /// </summary>
        [JsonPropertyName("provisionStatus")]
        public OperationStatus? ProvisionStatus { get; set; }
    
        /// <summary>
        /// Gets or sets provision status code.
        /// Additional information about why schedule provisioning failed.
        /// </summary>
        [JsonPropertyName("provisionStatusCode")]
        public string ProvisionStatusCode { get; set; }
    
        /// <summary>
        /// Gets or sets swap shifts requests enabled.
        /// Indicates whether swap shifts requests are enabled for the schedule.
        /// </summary>
        [JsonPropertyName("swapShiftsRequestsEnabled")]
        public bool? SwapShiftsRequestsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets time clock enabled.
        /// Indicates whether time clock is enabled for the schedule.
        /// </summary>
        [JsonPropertyName("timeClockEnabled")]
        public bool? TimeClockEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets time off requests enabled.
        /// Indicates whether time off requests are enabled for the schedule.
        /// </summary>
        [JsonPropertyName("timeOffRequestsEnabled")]
        public bool? TimeOffRequestsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets time zone.
        /// Indicates the time zone of the schedule team using tz database format. Required.
        /// </summary>
        [JsonPropertyName("timeZone")]
        public string TimeZone { get; set; }
    
        /// <summary>
        /// Gets or sets workforce integration ids.
        /// </summary>
        [JsonPropertyName("workforceIntegrationIds")]
        public IEnumerable<string> WorkforceIntegrationIds { get; set; }
    
        /// <summary>
        /// Gets or sets offer shift requests.
        /// </summary>
        [JsonPropertyName("offerShiftRequests")]
        public IScheduleOfferShiftRequestsCollectionPage OfferShiftRequests { get; set; }
    
        /// <summary>
        /// Gets or sets open shift change requests.
        /// </summary>
        [JsonPropertyName("openShiftChangeRequests")]
        public IScheduleOpenShiftChangeRequestsCollectionPage OpenShiftChangeRequests { get; set; }
    
        /// <summary>
        /// Gets or sets open shifts.
        /// </summary>
        [JsonPropertyName("openShifts")]
        public IScheduleOpenShiftsCollectionPage OpenShifts { get; set; }
    
        /// <summary>
        /// Gets or sets scheduling groups.
        /// The logical grouping of users in the schedule (usually by role).
        /// </summary>
        [JsonPropertyName("schedulingGroups")]
        public IScheduleSchedulingGroupsCollectionPage SchedulingGroups { get; set; }
    
        /// <summary>
        /// Gets or sets shifts.
        /// The shifts in the schedule.
        /// </summary>
        [JsonPropertyName("shifts")]
        public IScheduleShiftsCollectionPage Shifts { get; set; }
    
        /// <summary>
        /// Gets or sets swap shifts change requests.
        /// </summary>
        [JsonPropertyName("swapShiftsChangeRequests")]
        public IScheduleSwapShiftsChangeRequestsCollectionPage SwapShiftsChangeRequests { get; set; }
    
        /// <summary>
        /// Gets or sets time off reasons.
        /// The set of reasons for a time off in the schedule.
        /// </summary>
        [JsonPropertyName("timeOffReasons")]
        public IScheduleTimeOffReasonsCollectionPage TimeOffReasons { get; set; }
    
        /// <summary>
        /// Gets or sets time off requests.
        /// </summary>
        [JsonPropertyName("timeOffRequests")]
        public IScheduleTimeOffRequestsCollectionPage TimeOffRequests { get; set; }
    
        /// <summary>
        /// Gets or sets times off.
        /// The instances of times off in the schedule.
        /// </summary>
        [JsonPropertyName("timesOff")]
        public IScheduleTimesOffCollectionPage TimesOff { get; set; }
    
    }
}

