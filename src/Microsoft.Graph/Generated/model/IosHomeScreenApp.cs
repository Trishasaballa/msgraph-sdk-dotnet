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
    /// The type IosHomeScreenApp.
    /// </summary>
    
    public partial class IosHomeScreenApp : IosHomeScreenItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IosHomeScreenApp"/> class.
        /// </summary>
        public IosHomeScreenApp()
        {
            this.ODataType = "microsoft.graph.iosHomeScreenApp";
        }

        /// <summary>
        /// Gets or sets bundleID.
        /// BundleID of app
        /// </summary>
        [JsonPropertyName("bundleID")]
        public string BundleID { get; set; }
    
    }
}
