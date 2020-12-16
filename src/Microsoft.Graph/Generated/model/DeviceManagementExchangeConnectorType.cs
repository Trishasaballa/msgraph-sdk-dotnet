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
    /// The enum DeviceManagementExchangeConnectorType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum DeviceManagementExchangeConnectorType
    {
    
        /// <summary>
        /// On Premises
        /// </summary>
        OnPremises = 0,
	
        /// <summary>
        /// Hosted
        /// </summary>
        Hosted = 1,
	
        /// <summary>
        /// Service To Service
        /// </summary>
        ServiceToService = 2,
	
        /// <summary>
        /// Dedicated
        /// </summary>
        Dedicated = 3,
	
    }
}
