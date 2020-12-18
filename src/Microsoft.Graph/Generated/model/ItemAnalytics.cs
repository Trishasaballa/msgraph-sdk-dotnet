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
    /// The type Item Analytics.
    /// </summary>
    
    public partial class ItemAnalytics : Entity
    {
    
		///<summary>
		/// The ItemAnalytics constructor
		///</summary>
        public ItemAnalytics()
        {
            this.ODataType = "microsoft.graph.itemAnalytics";
        }
	
        /// <summary>
        /// Gets or sets all time.
        /// </summary>
        [JsonPropertyName("allTime")]
        public ItemActivityStat AllTime { get; set; }
    
        /// <summary>
        /// Gets or sets item activity stats.
        /// </summary>
        [JsonPropertyName("itemActivityStats")]
        public IItemAnalyticsItemActivityStatsCollectionPage ItemActivityStats { get; set; }
    
        /// <summary>
        /// Gets or sets last seven days.
        /// </summary>
        [JsonPropertyName("lastSevenDays")]
        public ItemActivityStat LastSevenDays { get; set; }
    
    }
}

