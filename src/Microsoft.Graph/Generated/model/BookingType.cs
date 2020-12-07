// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum BookingType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BookingType
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// Standard
        /// </summary>
        Standard = 1,
	
        /// <summary>
        /// Reserved
        /// </summary>
        Reserved = 2,
	
    }
}
