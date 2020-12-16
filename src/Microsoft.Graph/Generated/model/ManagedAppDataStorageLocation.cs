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
    /// The enum ManagedAppDataStorageLocation.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ManagedAppDataStorageLocation
    {
    
        /// <summary>
        /// One Drive For Business
        /// </summary>
        OneDriveForBusiness = 1,
	
        /// <summary>
        /// Share Point
        /// </summary>
        SharePoint = 2,
	
        /// <summary>
        /// Local Storage
        /// </summary>
        LocalStorage = 6,
	
    }
}
