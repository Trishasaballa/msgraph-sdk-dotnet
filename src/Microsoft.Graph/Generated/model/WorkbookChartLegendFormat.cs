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
    /// The type Workbook Chart Legend Format.
    /// </summary>
    
    public partial class WorkbookChartLegendFormat : Entity
    {
    
		///<summary>
		/// The WorkbookChartLegendFormat constructor
		///</summary>
        public WorkbookChartLegendFormat()
        {
            this.ODataType = "microsoft.graph.workbookChartLegendFormat";
        }
	
        /// <summary>
        /// Gets or sets fill.
        /// Represents the fill format of an object, which includes background formating information. Read-only.
        /// </summary>
        [JsonPropertyName("fill")]
        public WorkbookChartFill Fill { get; set; }
    
        /// <summary>
        /// Gets or sets font.
        /// Represents the font attributes such as font name, font size, color, etc. of a chart legend. Read-only.
        /// </summary>
        [JsonPropertyName("font")]
        public WorkbookChartFont Font { get; set; }
    
    }
}

