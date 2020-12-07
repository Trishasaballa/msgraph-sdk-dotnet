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
    /// The type IPv6Range.
    /// </summary>
    
    public partial class IPv6Range : IpRange
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IPv6Range"/> class.
        /// </summary>
        public IPv6Range()
        {
            this.ODataType = "microsoft.graph.iPv6Range";
        }

        /// <summary>
        /// Gets or sets lowerAddress.
        /// Lower address
        /// </summary>
        [JsonPropertyName("lowerAddress")]
        public string LowerAddress { get; set; }
    
        /// <summary>
        /// Gets or sets upperAddress.
        /// Upper address
        /// </summary>
        [JsonPropertyName("upperAddress")]
        public string UpperAddress { get; set; }
    
    }
}
