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
    /// The enum WindowsUpdateType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WindowsUpdateType
    {
    
        /// <summary>
        /// User Defined
        /// </summary>
        UserDefined = 0,
	
        /// <summary>
        /// All
        /// </summary>
        All = 1,
	
        /// <summary>
        /// Business Ready Only
        /// </summary>
        BusinessReadyOnly = 2,
	
        /// <summary>
        /// Windows Insider Build Fast
        /// </summary>
        WindowsInsiderBuildFast = 3,
	
        /// <summary>
        /// Windows Insider Build Slow
        /// </summary>
        WindowsInsiderBuildSlow = 4,
	
        /// <summary>
        /// Windows Insider Build Release
        /// </summary>
        WindowsInsiderBuildRelease = 5,
	
    }
}
