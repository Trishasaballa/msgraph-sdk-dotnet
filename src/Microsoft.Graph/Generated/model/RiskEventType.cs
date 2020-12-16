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
    /// The enum RiskEventType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum RiskEventType
    {
    
        /// <summary>
        /// Unlikely Travel
        /// </summary>
        UnlikelyTravel = 0,
	
        /// <summary>
        /// Anonymized IPAddress
        /// </summary>
        AnonymizedIPAddress = 1,
	
        /// <summary>
        /// Malicious IPAddress
        /// </summary>
        MaliciousIPAddress = 2,
	
        /// <summary>
        /// Unfamiliar Features
        /// </summary>
        UnfamiliarFeatures = 3,
	
        /// <summary>
        /// Malware Infected IPAddress
        /// </summary>
        MalwareInfectedIPAddress = 4,
	
        /// <summary>
        /// Suspicious IPAddress
        /// </summary>
        SuspiciousIPAddress = 5,
	
        /// <summary>
        /// Leaked Credentials
        /// </summary>
        LeakedCredentials = 6,
	
        /// <summary>
        /// Investigations Threat Intelligence
        /// </summary>
        InvestigationsThreatIntelligence = 7,
	
        /// <summary>
        /// Generic
        /// </summary>
        Generic = 8,
	
        /// <summary>
        /// Admin Confirmed User Compromised
        /// </summary>
        AdminConfirmedUserCompromised = 9,
	
        /// <summary>
        /// Mcas Impossible Travel
        /// </summary>
        McasImpossibleTravel = 10,
	
        /// <summary>
        /// Mcas Suspicious Inbox Manipulation Rules
        /// </summary>
        McasSuspiciousInboxManipulationRules = 11,
	
        /// <summary>
        /// Investigations Threat Intelligence Signin Linked
        /// </summary>
        InvestigationsThreatIntelligenceSigninLinked = 12,
	
        /// <summary>
        /// Malicious IPAddress Valid Credentials Blocked IP
        /// </summary>
        MaliciousIPAddressValidCredentialsBlockedIP = 13,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 14,
	
    }
}
