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
    /// The type Onenote Section.
    /// </summary>
    
    public partial class OnenoteSection : OnenoteEntityHierarchyModel
    {
    
		///<summary>
		/// The OnenoteSection constructor
		///</summary>
        public OnenoteSection()
        {
            this.ODataType = "microsoft.graph.onenoteSection";
        }
	
        /// <summary>
        /// Gets or sets is default.
        /// Indicates whether this is the user's default section. Read-only.
        /// </summary>
        [JsonPropertyName("isDefault")]
        public bool? IsDefault { get; set; }
    
        /// <summary>
        /// Gets or sets links.
        /// Links for opening the section. The oneNoteClientURL link opens the section in the OneNote native client if it's installed. The oneNoteWebURL link opens the section in OneNote on the web.
        /// </summary>
        [JsonPropertyName("links")]
        public SectionLinks Links { get; set; }
    
        /// <summary>
        /// Gets or sets pages url.
        /// The pages endpoint where you can get details for all the pages in the section. Read-only.
        /// </summary>
        [JsonPropertyName("pagesUrl")]
        public string PagesUrl { get; set; }
    
        /// <summary>
        /// Gets or sets pages.
        /// The collection of pages in the section.  Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("pages")]
        public IOnenoteSectionPagesCollectionPage Pages { get; set; }
    
        /// <summary>
        /// Gets or sets parent notebook.
        /// The notebook that contains the section.  Read-only.
        /// </summary>
        [JsonPropertyName("parentNotebook")]
        public Notebook ParentNotebook { get; set; }
    
        /// <summary>
        /// Gets or sets parent section group.
        /// The section group that contains the section.  Read-only.
        /// </summary>
        [JsonPropertyName("parentSectionGroup")]
        public SectionGroup ParentSectionGroup { get; set; }
    
    }
}

