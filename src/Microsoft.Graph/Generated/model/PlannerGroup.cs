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
    /// The type Planner Group.
    /// </summary>
    
    public partial class PlannerGroup : Entity
    {
    
		///<summary>
		/// The PlannerGroup constructor
		///</summary>
        public PlannerGroup()
        {
            this.ODataType = "microsoft.graph.plannerGroup";
        }
	
        /// <summary>
        /// Gets or sets plans.
        /// Read-only. Nullable. Returns the plannerPlans owned by the group.
        /// </summary>
        [JsonPropertyName("plans")]
        public IPlannerGroupPlansCollectionPage Plans { get; set; }
    
    }
}

