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
    /// The type Windows10Custom Configuration.
    /// </summary>
    
    public partial class Windows10CustomConfiguration : DeviceConfiguration
    {
    
		///<summary>
		/// The Windows10CustomConfiguration constructor
		///</summary>
        public Windows10CustomConfiguration()
        {
            this.ODataType = "microsoft.graph.windows10CustomConfiguration";
        }
	
        /// <summary>
        /// Gets or sets oma settings.
        /// OMA settings. This collection can contain a maximum of 1000 elements.
        /// </summary>
        [JsonPropertyName("omaSettings")]
        public IEnumerable<OmaSetting> OmaSettings { get; set; }
    
    }
}

