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
    /// The type Planner User.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PlannerUser : Entity
    {
    
		///<summary>
		/// The PlannerUser constructor
		///</summary>
        public PlannerUser()
        {
            this.ODataType = "microsoft.graph.plannerUser";
        }
	
        /// <summary>
        /// Gets or sets plans.
        /// Read-only. Nullable. Returns the plannerTasks assigned to the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "plans", Required = Newtonsoft.Json.Required.Default)]
        public IPlannerUserPlansCollectionPage Plans { get; set; }
    
        /// <summary>
        /// Gets or sets tasks.
        /// Read-only. Nullable. Returns the plannerPlans shared with the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tasks", Required = Newtonsoft.Json.Required.Default)]
        public IPlannerUserTasksCollectionPage Tasks { get; set; }
    
    }
}

