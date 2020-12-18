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
    /// The type Base Item Version.
    /// </summary>
    
    public partial class BaseItemVersion : Entity
    {
    
		///<summary>
		/// The internal BaseItemVersion constructor
		///</summary>
        protected internal BaseItemVersion()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets last modified by.
        /// Identity of the user which last modified the version. Read-only.
        /// </summary>
        [JsonPropertyName("lastModifiedBy")]
        public IdentitySet LastModifiedBy { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Date and time the version was last modified. Read-only.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets publication.
        /// Indicates the publication status of this particular version. Read-only.
        /// </summary>
        [JsonPropertyName("publication")]
        public PublicationFacet Publication { get; set; }
    
    }
}

