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
    /// The enum TeamSpecialization.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TeamSpecialization
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// Education Standard
        /// </summary>
        EducationStandard = 1,
	
        /// <summary>
        /// Education Class
        /// </summary>
        EducationClass = 2,
	
        /// <summary>
        /// Education Professional Learning Community
        /// </summary>
        EducationProfessionalLearningCommunity = 3,
	
        /// <summary>
        /// Education Staff
        /// </summary>
        EducationStaff = 4,
	
        /// <summary>
        /// Healthcare Standard
        /// </summary>
        HealthcareStandard = 5,
	
        /// <summary>
        /// Healthcare Care Coordination
        /// </summary>
        HealthcareCareCoordination = 6,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 7,
	
    }
}
