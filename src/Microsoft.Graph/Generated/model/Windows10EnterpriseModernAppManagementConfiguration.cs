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
    /// The type Windows10Enterprise Modern App Management Configuration.
    /// </summary>
    
    public partial class Windows10EnterpriseModernAppManagementConfiguration : DeviceConfiguration
    {
    
		///<summary>
		/// The Windows10EnterpriseModernAppManagementConfiguration constructor
		///</summary>
        public Windows10EnterpriseModernAppManagementConfiguration()
        {
            this.ODataType = "microsoft.graph.windows10EnterpriseModernAppManagementConfiguration";
        }
	
        /// <summary>
        /// Gets or sets uninstall built in apps.
        /// Indicates whether or not to uninstall a fixed list of built-in Windows apps.
        /// </summary>
        [JsonPropertyName("uninstallBuiltInApps")]
        public bool? UninstallBuiltInApps { get; set; }
    
    }
}

