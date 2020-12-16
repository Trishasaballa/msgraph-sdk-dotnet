// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type OutgoingCallOptions.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class OutgoingCallOptions : CallOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutgoingCallOptions"/> class.
        /// </summary>
        public OutgoingCallOptions()
        {
            this.ODataType = "microsoft.graph.outgoingCallOptions";
        }

    }
}
