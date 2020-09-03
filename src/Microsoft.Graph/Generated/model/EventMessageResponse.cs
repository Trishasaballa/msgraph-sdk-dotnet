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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Event Message Response.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EventMessageResponse : EventMessage
    {
    
		///<summary>
		/// The EventMessageResponse constructor
		///</summary>
        public EventMessageResponse()
        {
            this.ODataType = "microsoft.graph.eventMessageResponse";
        }
	
        /// <summary>
        /// Gets or sets proposed new time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "proposedNewTime", Required = Newtonsoft.Json.Required.Default)]
        public TimeSlot ProposedNewTime { get; set; }
    
        /// <summary>
        /// Gets or sets response type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "responseType", Required = Newtonsoft.Json.Required.Default)]
        public ResponseType? ResponseType { get; set; }
    
    }
}
