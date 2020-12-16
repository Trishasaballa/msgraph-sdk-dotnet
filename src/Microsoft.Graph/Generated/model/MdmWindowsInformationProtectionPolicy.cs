// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Mdm Windows Information Protection Policy.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MdmWindowsInformationProtectionPolicy : WindowsInformationProtection
    {
    
		///<summary>
		/// The MdmWindowsInformationProtectionPolicy constructor
		///</summary>
        public MdmWindowsInformationProtectionPolicy()
        {
            this.ODataType = "microsoft.graph.mdmWindowsInformationProtectionPolicy";
        }
	
    }
}

