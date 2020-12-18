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
    /// The enum TeamsAsyncOperationStatus.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TeamsAsyncOperationStatus
    {
    
        /// <summary>
        /// Invalid
        /// </summary>
        Invalid = 0,
	
        /// <summary>
        /// Not Started
        /// </summary>
        NotStarted = 1,
	
        /// <summary>
        /// In Progress
        /// </summary>
        InProgress = 2,
	
        /// <summary>
        /// Succeeded
        /// </summary>
        Succeeded = 3,
	
        /// <summary>
        /// Failed
        /// </summary>
        Failed = 4,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 5,
	
    }
}
