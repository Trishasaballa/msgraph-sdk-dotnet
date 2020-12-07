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
    /// The enum RecordingStatus.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RecordingStatus
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// Not Recording
        /// </summary>
        NotRecording = 1,
	
        /// <summary>
        /// Recording
        /// </summary>
        Recording = 2,
	
        /// <summary>
        /// Failed
        /// </summary>
        Failed = 3,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 4,
	
    }
}
