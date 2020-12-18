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
    /// The type Workbook Range View.
    /// </summary>
    
    public partial class WorkbookRangeView : Entity
    {
    
		///<summary>
		/// The WorkbookRangeView constructor
		///</summary>
        public WorkbookRangeView()
        {
            this.ODataType = "microsoft.graph.workbookRangeView";
        }
	
        /// <summary>
        /// Gets or sets cell addresses.
        /// Represents the cell addresses
        /// </summary>
        [JsonPropertyName("cellAddresses")]
        public System.Text.Json.JsonDocument CellAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets column count.
        /// Returns the number of visible columns. Read-only.
        /// </summary>
        [JsonPropertyName("columnCount")]
        public Int32? ColumnCount { get; set; }
    
        /// <summary>
        /// Gets or sets formulas.
        /// Represents the formula in A1-style notation.
        /// </summary>
        [JsonPropertyName("formulas")]
        public System.Text.Json.JsonDocument Formulas { get; set; }
    
        /// <summary>
        /// Gets or sets formulas local.
        /// Represents the formula in A1-style notation, in the user's language and number-formatting locale. For example, the English '=SUM(A1, 1.5)' formula would become '=SUMME(A1; 1,5)' in German.
        /// </summary>
        [JsonPropertyName("formulasLocal")]
        public System.Text.Json.JsonDocument FormulasLocal { get; set; }
    
        /// <summary>
        /// Gets or sets formulas r1c1.
        /// Represents the formula in R1C1-style notation.
        /// </summary>
        [JsonPropertyName("formulasR1C1")]
        public System.Text.Json.JsonDocument FormulasR1C1 { get; set; }
    
        /// <summary>
        /// Gets or sets index.
        /// Index of the range.
        /// </summary>
        [JsonPropertyName("index")]
        public Int32? Index { get; set; }
    
        /// <summary>
        /// Gets or sets number format.
        /// Represents Excel's number format code for the given cell. Read-only.
        /// </summary>
        [JsonPropertyName("numberFormat")]
        public System.Text.Json.JsonDocument NumberFormat { get; set; }
    
        /// <summary>
        /// Gets or sets row count.
        /// Returns the number of visible rows. Read-only.
        /// </summary>
        [JsonPropertyName("rowCount")]
        public Int32? RowCount { get; set; }
    
        /// <summary>
        /// Gets or sets text.
        /// Text values of the specified range. The Text value will not depend on the cell width. The # sign substitution that happens in Excel UI will not affect the text value returned by the API. Read-only.
        /// </summary>
        [JsonPropertyName("text")]
        public System.Text.Json.JsonDocument Text { get; set; }
    
        /// <summary>
        /// Gets or sets values.
        /// Represents the raw values of the specified range view. The data returned could be of type string, number, or a boolean. Cell that contain an error will return the error string.
        /// </summary>
        [JsonPropertyName("values")]
        public System.Text.Json.JsonDocument Values { get; set; }
    
        /// <summary>
        /// Gets or sets value types.
        /// Represents the type of data of each cell. Read-only. The possible values are: Unknown, Empty, String, Integer, Double, Boolean, Error.
        /// </summary>
        [JsonPropertyName("valueTypes")]
        public System.Text.Json.JsonDocument ValueTypes { get; set; }
    
        /// <summary>
        /// Gets or sets rows.
        /// Represents a collection of range views associated with the range. Read-only. Read-only.
        /// </summary>
        [JsonPropertyName("rows")]
        public IWorkbookRangeViewRowsCollectionPage Rows { get; set; }
    
    }
}

