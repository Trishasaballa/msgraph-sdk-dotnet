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
    /// The type Workbook Chart Area Format.
    /// </summary>
    
    public partial class WorkbookChartAreaFormat : Entity
    {
    
		///<summary>
		/// The WorkbookChartAreaFormat constructor
		///</summary>
        public WorkbookChartAreaFormat()
        {
            this.ODataType = "microsoft.graph.workbookChartAreaFormat";
        }
	
        /// <summary>
        /// Gets or sets fill.
        /// Represents the fill format of an object, which includes background formatting information. Read-only.
        /// </summary>
        [JsonPropertyName("fill")]
        public WorkbookChartFill Fill { get; set; }
    
        /// <summary>
        /// Gets or sets font.
        /// Represents the font attributes (font name, font size, color, etc.) for the current object. Read-only.
        /// </summary>
        [JsonPropertyName("font")]
        public WorkbookChartFont Font { get; set; }
    
    }
}

