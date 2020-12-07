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
    /// The type Place.
    /// </summary>
    
    public partial class Place : Entity
    {
    
		///<summary>
		/// The internal Place constructor
		///</summary>
        protected internal Place()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets address.
        /// The street address of the place.
        /// </summary>
        [JsonPropertyName("address")]
        public PhysicalAddress Address { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The name associated with the place.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets geo coordinates.
        /// Specifies the place location in latitude, longitude and (optionally) altitude coordinates.
        /// </summary>
        [JsonPropertyName("geoCoordinates")]
        public OutlookGeoCoordinates GeoCoordinates { get; set; }
    
        /// <summary>
        /// Gets or sets phone.
        /// The phone number of the place.
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }
    
    }
}

