// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// The enum AndroidWorkProfileCrossProfileDataSharingType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum AndroidWorkProfileCrossProfileDataSharingType
    {
    
        /// <summary>
        /// Device Default
        /// </summary>
        DeviceDefault = 0,
	
        /// <summary>
        /// Prevent Any
        /// </summary>
        PreventAny = 1,
	
        /// <summary>
        /// Allow Personal To Work
        /// </summary>
        AllowPersonalToWork = 2,
	
        /// <summary>
        /// No Restrictions
        /// </summary>
        NoRestrictions = 3,
	
    }
}
