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
    /// The type OrganizerMeetingInfo.
    /// </summary>
    
    public partial class OrganizerMeetingInfo : MeetingInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizerMeetingInfo"/> class.
        /// </summary>
        public OrganizerMeetingInfo()
        {
            this.ODataType = "microsoft.graph.organizerMeetingInfo";
        }

        /// <summary>
        /// Gets or sets organizer.
        /// The organizer Azure Active Directory identity.
        /// </summary>
        [JsonPropertyName("organizer")]
        public IdentitySet Organizer { get; set; }
    
    }
}
