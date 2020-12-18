// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type WorkbookOperationError.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<WorkbookOperationError>))]
    public partial class WorkbookOperationError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkbookOperationError"/> class.
        /// </summary>
        public WorkbookOperationError()
        {
            this.ODataType = "microsoft.graph.workbookOperationError";
        }

        /// <summary>
        /// Gets or sets code.
        /// The error code.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }
    
        /// <summary>
        /// Gets or sets innerError.
        /// </summary>
        [JsonPropertyName("innerError")]
        public WorkbookOperationError InnerError { get; set; }
    
        /// <summary>
        /// Gets or sets message.
        /// The error message.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
