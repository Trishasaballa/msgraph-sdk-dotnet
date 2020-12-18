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
    /// The enum RatingIrelandTelevisionType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RatingIrelandTelevisionType
    {
    
        /// <summary>
        /// All Allowed
        /// </summary>
        AllAllowed = 0,
	
        /// <summary>
        /// All Blocked
        /// </summary>
        AllBlocked = 1,
	
        /// <summary>
        /// General
        /// </summary>
        General = 2,
	
        /// <summary>
        /// Children
        /// </summary>
        Children = 3,
	
        /// <summary>
        /// Young Adults
        /// </summary>
        YoungAdults = 4,
	
        /// <summary>
        /// Parental Supervision
        /// </summary>
        ParentalSupervision = 5,
	
        /// <summary>
        /// Mature
        /// </summary>
        Mature = 6,
	
    }
}
