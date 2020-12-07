// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph.CallRecords
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type UserFeedback.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<UserFeedback>))]
    public partial class UserFeedback
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserFeedback"/> class.
        /// </summary>
        public UserFeedback()
        {
            this.ODataType = "microsoft.graph.callRecords.userFeedback";
        }

        /// <summary>
        /// Gets or sets rating.
        /// The rating provided by the user of this endpoint about the quality of this Session. Possible values are: notRated, bad, poor, fair, good, excellent, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("rating")]
        public UserFeedbackRating? Rating { get; set; }
    
        /// <summary>
        /// Gets or sets text.
        /// The feedback text provided by the user of this endpoint for the session.
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }
    
        /// <summary>
        /// Gets or sets tokens.
        /// The set of feedback tokens provided by the user of this endpoint for the session. This is a set of Boolean properties. The property names should not be relied upon since they may change depending on what tokens are offered to the user.
        /// </summary>
        [JsonPropertyName("tokens")]
        public FeedbackTokenSet Tokens { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
