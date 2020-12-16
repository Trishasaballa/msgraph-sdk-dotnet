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
    /// The type Activity History Item.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ActivityHistoryItem : Entity
    {
    
		///<summary>
		/// The ActivityHistoryItem constructor
		///</summary>
        public ActivityHistoryItem()
        {
            this.ODataType = "microsoft.graph.activityHistoryItem";
        }
	
        /// <summary>
        /// Gets or sets active duration seconds.
        /// Optional. The duration of active user engagement. if not supplied, this is calculated from the startedDateTime and lastActiveDateTime.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activeDurationSeconds", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ActiveDurationSeconds { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Set by the server. DateTime in UTC when the object was created on the server.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// Optional. UTC DateTime when the historyItem will undergo hard-delete. Can be set by the client.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expirationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last active date time.
        /// Optional. UTC DateTime when the historyItem (activity session) was last understood as active or finished - if null, historyItem status should be Ongoing.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastActiveDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastActiveDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Set by the server. DateTime in UTC when the object was modified on the server.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets started date time.
        /// Required. UTC DateTime when the historyItem (activity session) was started. Required for timeline history.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "startedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? StartedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Set by the server. A status code used to identify valid objects. Values: active, updated, deleted, ignored.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public Status? Status { get; set; }
    
        /// <summary>
        /// Gets or sets user timezone.
        /// Optional. The timezone in which the user's device used to generate the activity was located at activity creation time. Values supplied as Olson IDs in order to support cross-platform representation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userTimezone", Required = Newtonsoft.Json.Required.Default)]
        public string UserTimezone { get; set; }
    
        /// <summary>
        /// Gets or sets activity.
        /// Optional. NavigationProperty/Containment; navigation property to the associated activity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activity", Required = Newtonsoft.Json.Required.Default)]
        public UserActivity Activity { get; set; }
    
    }
}

