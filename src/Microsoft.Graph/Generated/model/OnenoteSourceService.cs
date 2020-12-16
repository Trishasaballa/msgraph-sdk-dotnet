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
    /// The enum OnenoteSourceService.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum OnenoteSourceService
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// One Drive
        /// </summary>
        OneDrive = 1,
	
        /// <summary>
        /// One Drive For Business
        /// </summary>
        OneDriveForBusiness = 2,
	
        /// <summary>
        /// On Prem One Drive For Business
        /// </summary>
        OnPremOneDriveForBusiness = 3,
	
    }
}
