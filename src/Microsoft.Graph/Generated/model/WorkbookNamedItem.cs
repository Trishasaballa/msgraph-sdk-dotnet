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
    /// The type Workbook Named Item.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookNamedItem : Entity
    {
    
		///<summary>
		/// The WorkbookNamedItem constructor
		///</summary>
        public WorkbookNamedItem()
        {
            this.ODataType = "microsoft.graph.workbookNamedItem";
        }
	
        /// <summary>
        /// Gets or sets comment.
        /// Represents the comment associated with this name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "comment", Required = Newtonsoft.Json.Required.Default)]
        public string Comment { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// The name of the object. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets scope.
        /// Indicates whether the name is scoped to the workbook or to a specific worksheet. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scope", Required = Newtonsoft.Json.Required.Default)]
        public string Scope { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// Indicates what type of reference is associated with the name. The possible values are: String, Integer, Double, Boolean, Range. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type", Required = Newtonsoft.Json.Required.Default)]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or sets value.
        /// Represents the formula that the name is defined to refer to. E.g. =Sheet14!$B$2:$H$12, =4.75, etc. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "value", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Value { get; set; }
    
        /// <summary>
        /// Gets or sets visible.
        /// Specifies whether the object is visible or not.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "visible", Required = Newtonsoft.Json.Required.Default)]
        public bool? Visible { get; set; }
    
        /// <summary>
        /// Gets or sets worksheet.
        /// Returns the worksheet on which the named item is scoped to. Available only if the item is scoped to the worksheet. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "worksheet", Required = Newtonsoft.Json.Required.Default)]
        public WorkbookWorksheet Worksheet { get; set; }
    
    }
}

