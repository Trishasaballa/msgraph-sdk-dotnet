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
    /// The enum ThreatAssessmentContentType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ThreatAssessmentContentType
    {
    
        /// <summary>
        /// Mail
        /// </summary>
        Mail = 1,
	
        /// <summary>
        /// Url
        /// </summary>
        Url = 2,
	
        /// <summary>
        /// File
        /// </summary>
        File = 3,
	
    }
}
