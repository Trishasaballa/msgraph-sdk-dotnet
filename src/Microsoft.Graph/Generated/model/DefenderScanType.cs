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
    /// The enum DefenderScanType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DefenderScanType
    {
    
        /// <summary>
        /// User Defined
        /// </summary>
        UserDefined = 0,
	
        /// <summary>
        /// Disabled
        /// </summary>
        Disabled = 1,
	
        /// <summary>
        /// Quick
        /// </summary>
        Quick = 2,
	
        /// <summary>
        /// Full
        /// </summary>
        Full = 3,
	
    }
}
