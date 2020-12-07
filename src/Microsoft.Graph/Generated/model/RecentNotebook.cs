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
    /// The type RecentNotebook.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<RecentNotebook>))]
    public partial class RecentNotebook
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecentNotebook"/> class.
        /// </summary>
        public RecentNotebook()
        {
            this.ODataType = "microsoft.graph.recentNotebook";
        }

        /// <summary>
        /// Gets or sets displayName.
        /// The name of the notebook.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets lastAccessedTime.
        /// The date and time when the notebook was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        /// </summary>
        [JsonPropertyName("lastAccessedTime")]
        public DateTimeOffset? LastAccessedTime { get; set; }
    
        /// <summary>
        /// Gets or sets links.
        /// Links for opening the notebook. The oneNoteClientURL link opens the notebook in the OneNote client, if it's installed. The oneNoteWebURL link opens the notebook in OneNote on the web.
        /// </summary>
        [JsonPropertyName("links")]
        public RecentNotebookLinks Links { get; set; }
    
        /// <summary>
        /// Gets or sets sourceService.
        /// The backend store where the Notebook resides, either OneDriveForBusiness or OneDrive.
        /// </summary>
        [JsonPropertyName("sourceService")]
        public OnenoteSourceService? SourceService { get; set; }
    
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
