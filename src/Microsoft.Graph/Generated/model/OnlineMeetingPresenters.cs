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
    /// The enum OnlineMeetingPresenters.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OnlineMeetingPresenters
    {
    
        /// <summary>
        /// Everyone
        /// </summary>
        Everyone = 0,
	
        /// <summary>
        /// Organization
        /// </summary>
        Organization = 1,
	
        /// <summary>
        /// Role Is Presenter
        /// </summary>
        RoleIsPresenter = 2,
	
        /// <summary>
        /// Organizer
        /// </summary>
        Organizer = 3,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 4,
	
    }
}
