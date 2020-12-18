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
    /// The type Conditional Access Root.
    /// </summary>
    
    public partial class ConditionalAccessRoot : Entity
    {
    
		///<summary>
		/// The ConditionalAccessRoot constructor
		///</summary>
        public ConditionalAccessRoot()
        {
            this.ODataType = "microsoft.graph.conditionalAccessRoot";
        }
	
        /// <summary>
        /// Gets or sets named locations.
        /// </summary>
        [JsonPropertyName("namedLocations")]
        public IConditionalAccessRootNamedLocationsCollectionPage NamedLocations { get; set; }
    
        /// <summary>
        /// Gets or sets policies.
        /// </summary>
        [JsonPropertyName("policies")]
        public IConditionalAccessRootPoliciesCollectionPage Policies { get; set; }
    
    }
}

