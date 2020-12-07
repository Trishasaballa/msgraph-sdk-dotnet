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
    /// The enum VppTokenState.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum VppTokenState
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// Valid
        /// </summary>
        Valid = 1,
	
        /// <summary>
        /// Expired
        /// </summary>
        Expired = 2,
	
        /// <summary>
        /// Invalid
        /// </summary>
        Invalid = 3,
	
        /// <summary>
        /// Assigned To External MDM
        /// </summary>
        AssignedToExternalMDM = 4,
	
    }
}
