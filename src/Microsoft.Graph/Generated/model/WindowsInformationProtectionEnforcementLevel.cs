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
    /// The enum WindowsInformationProtectionEnforcementLevel.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WindowsInformationProtectionEnforcementLevel
    {
    
        /// <summary>
        /// No Protection
        /// </summary>
        NoProtection = 0,
	
        /// <summary>
        /// Encrypt And Audit Only
        /// </summary>
        EncryptAndAuditOnly = 1,
	
        /// <summary>
        /// Encrypt Audit And Prompt
        /// </summary>
        EncryptAuditAndPrompt = 2,
	
        /// <summary>
        /// Encrypt Audit And Block
        /// </summary>
        EncryptAuditAndBlock = 3,
	
    }
}
