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
    /// The type Managed App.
    /// </summary>
    
    public partial class ManagedApp : MobileApp
    {
    
		///<summary>
		/// The internal ManagedApp constructor
		///</summary>
        protected internal ManagedApp()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets app availability.
        /// The Application's availability. Possible values are: global, lineOfBusiness.
        /// </summary>
        [JsonPropertyName("appAvailability")]
        public ManagedAppAvailability? AppAvailability { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// The Application's version.
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }
    
    }
}

