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
    /// The type Teams App Definition.
    /// </summary>
    
    public partial class TeamsAppDefinition : Entity
    {
    
		///<summary>
		/// The TeamsAppDefinition constructor
		///</summary>
        public TeamsAppDefinition()
        {
            this.ODataType = "microsoft.graph.teamsAppDefinition";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// The name of the app provided by the app developer.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets teams app id.
        /// The ID from the Teams app manifest.
        /// </summary>
        [JsonPropertyName("teamsAppId")]
        public string TeamsAppId { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// The version number of the application.
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }
    
    }
}

