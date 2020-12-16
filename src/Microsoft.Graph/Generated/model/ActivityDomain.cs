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
    /// The enum ActivityDomain.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ActivityDomain
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// Work
        /// </summary>
        Work = 1,
	
        /// <summary>
        /// Personal
        /// </summary>
        Personal = 2,
	
        /// <summary>
        /// Unrestricted
        /// </summary>
        Unrestricted = 3,
	
    }
}
