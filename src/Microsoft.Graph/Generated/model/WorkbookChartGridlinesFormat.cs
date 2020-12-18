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
    /// The type Workbook Chart Gridlines Format.
    /// </summary>
    
    public partial class WorkbookChartGridlinesFormat : Entity
    {
    
		///<summary>
		/// The WorkbookChartGridlinesFormat constructor
		///</summary>
        public WorkbookChartGridlinesFormat()
        {
            this.ODataType = "microsoft.graph.workbookChartGridlinesFormat";
        }
	
        /// <summary>
        /// Gets or sets line.
        /// Represents chart line formatting. Read-only.
        /// </summary>
        [JsonPropertyName("line")]
        public WorkbookChartLineFormat Line { get; set; }
    
    }
}

