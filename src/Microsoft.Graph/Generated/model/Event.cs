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
    /// The type Event.
    /// </summary>
    
    public partial class Event : OutlookItem
    {
    
		///<summary>
		/// The Event constructor
		///</summary>
        public Event()
        {
            this.ODataType = "microsoft.graph.event";
        }
	
        /// <summary>
        /// Gets or sets allow new time proposals.
        /// True if the meeting organizer allows invitees to propose a new time when responding, false otherwise. Optional. Default is true.
        /// </summary>
        [JsonPropertyName("allowNewTimeProposals")]
        public bool? AllowNewTimeProposals { get; set; }
    
        /// <summary>
        /// Gets or sets attendees.
        /// The collection of attendees for the event.
        /// </summary>
        [JsonPropertyName("attendees")]
        public IEnumerable<Attendee> Attendees { get; set; }
    
        /// <summary>
        /// Gets or sets body.
        /// The body of the message associated with the event. It can be in HTML or text format.
        /// </summary>
        [JsonPropertyName("body")]
        public ItemBody Body { get; set; }
    
        /// <summary>
        /// Gets or sets body preview.
        /// The preview of the message associated with the event. It is in text format.
        /// </summary>
        [JsonPropertyName("bodyPreview")]
        public string BodyPreview { get; set; }
    
        /// <summary>
        /// Gets or sets end.
        /// The date, time, and time zone that the event ends. By default, the end time is in UTC.
        /// </summary>
        [JsonPropertyName("end")]
        public DateTimeTimeZone End { get; set; }
    
        /// <summary>
        /// Gets or sets has attachments.
        /// Set to true if the event has attachments.
        /// </summary>
        [JsonPropertyName("hasAttachments")]
        public bool? HasAttachments { get; set; }
    
        /// <summary>
        /// Gets or sets i cal uid.
        /// A unique identifier for an event across calendars. This ID is different for each occurrence in a recurring series. Read-only.
        /// </summary>
        [JsonPropertyName("iCalUId")]
        public string ICalUId { get; set; }
    
        /// <summary>
        /// Gets or sets importance.
        /// The importance of the event. The possible values are: low, normal, high.
        /// </summary>
        [JsonPropertyName("importance")]
        public Importance? Importance { get; set; }
    
        /// <summary>
        /// Gets or sets is all day.
        /// Set to true if the event lasts all day.
        /// </summary>
        [JsonPropertyName("isAllDay")]
        public bool? IsAllDay { get; set; }
    
        /// <summary>
        /// Gets or sets is cancelled.
        /// Set to true if the event has been canceled.
        /// </summary>
        [JsonPropertyName("isCancelled")]
        public bool? IsCancelled { get; set; }
    
        /// <summary>
        /// Gets or sets is draft.
        /// </summary>
        [JsonPropertyName("isDraft")]
        public bool? IsDraft { get; set; }
    
        /// <summary>
        /// Gets or sets is online meeting.
        /// True if this event has online meeting information, false otherwise. Default is false. Optional.
        /// </summary>
        [JsonPropertyName("isOnlineMeeting")]
        public bool? IsOnlineMeeting { get; set; }
    
        /// <summary>
        /// Gets or sets is organizer.
        /// Set to true if the calendar owner (specified by the owner property of the calendar) is the organizer of the event (specified by the organizer property of the event). This also applies if a delegate organized the event on behalf of the owner.
        /// </summary>
        [JsonPropertyName("isOrganizer")]
        public bool? IsOrganizer { get; set; }
    
        /// <summary>
        /// Gets or sets is reminder on.
        /// Set to true if an alert is set to remind the user of the event.
        /// </summary>
        [JsonPropertyName("isReminderOn")]
        public bool? IsReminderOn { get; set; }
    
        /// <summary>
        /// Gets or sets location.
        /// The location of the event.
        /// </summary>
        [JsonPropertyName("location")]
        public Location Location { get; set; }
    
        /// <summary>
        /// Gets or sets locations.
        /// The locations where the event is held or attended from. The location and locations properties always correspond with each other. If you update the location property, any prior locations in the locations collection would be removed and replaced by the new location value.
        /// </summary>
        [JsonPropertyName("locations")]
        public IEnumerable<Location> Locations { get; set; }
    
        /// <summary>
        /// Gets or sets online meeting.
        /// Details for an attendee to join the meeting online. Read-only.
        /// </summary>
        [JsonPropertyName("onlineMeeting")]
        public OnlineMeetingInfo OnlineMeeting { get; set; }
    
        /// <summary>
        /// Gets or sets online meeting provider.
        /// Represents the online meeting service provider. The possible values are teamsForBusiness, skypeForBusiness, and skypeForConsumer. Optional.
        /// </summary>
        [JsonPropertyName("onlineMeetingProvider")]
        public OnlineMeetingProviderType? OnlineMeetingProvider { get; set; }
    
        /// <summary>
        /// Gets or sets online meeting url.
        /// A URL for an online meeting. The property is set only when an organizer specifies an event as an online meeting such as a Skype meeting. Read-only.
        /// </summary>
        [JsonPropertyName("onlineMeetingUrl")]
        public string OnlineMeetingUrl { get; set; }
    
        /// <summary>
        /// Gets or sets organizer.
        /// The organizer of the event.
        /// </summary>
        [JsonPropertyName("organizer")]
        public Recipient Organizer { get; set; }
    
        /// <summary>
        /// Gets or sets original end time zone.
        /// The end time zone that was set when the event was created. A value of tzone://Microsoft/Custom indicates that a legacy custom time zone was set in desktop Outlook.
        /// </summary>
        [JsonPropertyName("originalEndTimeZone")]
        public string OriginalEndTimeZone { get; set; }
    
        /// <summary>
        /// Gets or sets original start.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonPropertyName("originalStart")]
        public DateTimeOffset? OriginalStart { get; set; }
    
        /// <summary>
        /// Gets or sets original start time zone.
        /// The start time zone that was set when the event was created. A value of tzone://Microsoft/Custom indicates that a legacy custom time zone was set in desktop Outlook.
        /// </summary>
        [JsonPropertyName("originalStartTimeZone")]
        public string OriginalStartTimeZone { get; set; }
    
        /// <summary>
        /// Gets or sets recurrence.
        /// The recurrence pattern for the event.
        /// </summary>
        [JsonPropertyName("recurrence")]
        public PatternedRecurrence Recurrence { get; set; }
    
        /// <summary>
        /// Gets or sets reminder minutes before start.
        /// The number of minutes before the event start time that the reminder alert occurs.
        /// </summary>
        [JsonPropertyName("reminderMinutesBeforeStart")]
        public Int32? ReminderMinutesBeforeStart { get; set; }
    
        /// <summary>
        /// Gets or sets response requested.
        /// Default is true, which represents the organizer would like an invitee to send a response to the event.
        /// </summary>
        [JsonPropertyName("responseRequested")]
        public bool? ResponseRequested { get; set; }
    
        /// <summary>
        /// Gets or sets response status.
        /// Indicates the type of response sent in response to an event message.
        /// </summary>
        [JsonPropertyName("responseStatus")]
        public ResponseStatus ResponseStatus { get; set; }
    
        /// <summary>
        /// Gets or sets sensitivity.
        /// The possible values are: normal, personal, private, confidential.
        /// </summary>
        [JsonPropertyName("sensitivity")]
        public Sensitivity? Sensitivity { get; set; }
    
        /// <summary>
        /// Gets or sets series master id.
        /// The ID for the recurring series master item, if this event is part of a recurring series.
        /// </summary>
        [JsonPropertyName("seriesMasterId")]
        public string SeriesMasterId { get; set; }
    
        /// <summary>
        /// Gets or sets show as.
        /// The status to show. The possible values are: free, tentative, busy, oof, workingElsewhere, unknown.
        /// </summary>
        [JsonPropertyName("showAs")]
        public FreeBusyStatus? ShowAs { get; set; }
    
        /// <summary>
        /// Gets or sets start.
        /// The date, time, and time zone that the event starts. By default, the start time is in UTC.
        /// </summary>
        [JsonPropertyName("start")]
        public DateTimeTimeZone Start { get; set; }
    
        /// <summary>
        /// Gets or sets subject.
        /// The text of the event's subject line.
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }
    
        /// <summary>
        /// Gets or sets transaction id.
        /// A custom identifier specified by a client app for the server to avoid redundant POST operations in case of client retries to create the same event. This is useful when low network connectivity causes the client to time out before receiving a response from the server for the client's prior create-event request. After you set transactionId when creating an event, you cannot change transactionId in a subsequent update. This property is only returned in a response payload if an app has set it. Optional.
        /// </summary>
        [JsonPropertyName("transactionId")]
        public string TransactionId { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// The event type. The possible values are: singleInstance, occurrence, exception, seriesMaster. Read-only.
        /// </summary>
        [JsonPropertyName("type")]
        public EventType? Type { get; set; }
    
        /// <summary>
        /// Gets or sets web link.
        /// The URL to open the event in Outlook on the web.Outlook on the web opens the event in the browser if you are signed in to your mailbox. Otherwise, Outlook on the web prompts you to sign in.This URL cannot be accessed from within an iFrame.
        /// </summary>
        [JsonPropertyName("webLink")]
        public string WebLink { get; set; }
    
        /// <summary>
        /// Gets or sets attachments.
        /// The collection of fileAttachment and itemAttachment attachments for the event. Navigation property. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("attachments")]
        public IEventAttachmentsCollectionPage Attachments { get; set; }
    
        /// <summary>
        /// Gets or sets calendar.
        /// The calendar that contains the event. Navigation property. Read-only.
        /// </summary>
        [JsonPropertyName("calendar")]
        public Calendar Calendar { get; set; }
    
        /// <summary>
        /// Gets or sets extensions.
        /// The collection of open extensions defined for the event. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("extensions")]
        public IEventExtensionsCollectionPage Extensions { get; set; }
    
        /// <summary>
        /// Gets or sets instances.
        /// The instances of the event. Navigation property. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("instances")]
        public IEventInstancesCollectionPage Instances { get; set; }
    
        /// <summary>
        /// Gets or sets multi value extended properties.
        /// The collection of multi-value extended properties defined for the event. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("multiValueExtendedProperties")]
        public IEventMultiValueExtendedPropertiesCollectionPage MultiValueExtendedProperties { get; set; }
    
        /// <summary>
        /// Gets or sets single value extended properties.
        /// The collection of single-value extended properties defined for the event. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("singleValueExtendedProperties")]
        public IEventSingleValueExtendedPropertiesCollectionPage SingleValueExtendedProperties { get; set; }
    
    }
}

