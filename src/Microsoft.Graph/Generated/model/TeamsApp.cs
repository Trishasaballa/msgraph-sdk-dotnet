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
    /// The type Teams App.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class TeamsApp : Entity
    {
    
		///<summary>
		/// The TeamsApp constructor
		///</summary>
        public TeamsApp()
        {
            this.ODataType = "microsoft.graph.teamsApp";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// The name of the catalog app provided by the app developer in the Microsoft Teams zip app package.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets distribution method.
        /// The method of distribution for the app. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "distributionMethod", Required = Newtonsoft.Json.Required.Default)]
        public TeamsAppDistributionMethod? DistributionMethod { get; set; }
    
        /// <summary>
        /// Gets or sets external id.
        /// The ID of the catalog provided by the app developer in the Microsoft Teams zip app package.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "externalId", Required = Newtonsoft.Json.Required.Default)]
        public string ExternalId { get; set; }
    
        /// <summary>
        /// Gets or sets app definitions.
        /// The details for each version of the app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appDefinitions", Required = Newtonsoft.Json.Required.Default)]
        public ITeamsAppAppDefinitionsCollectionPage AppDefinitions { get; set; }
    
    }
}

