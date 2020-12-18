// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type MediaContentRatingAustralia.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MediaContentRatingAustralia>))]
    public partial class MediaContentRatingAustralia
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaContentRatingAustralia"/> class.
        /// </summary>
        public MediaContentRatingAustralia()
        {
            this.ODataType = "microsoft.graph.mediaContentRatingAustralia";
        }

        /// <summary>
        /// Gets or sets movieRating.
        /// Movies rating selected for Australia. Possible values are: allAllowed, allBlocked, general, parentalGuidance, mature, agesAbove15, agesAbove18.
        /// </summary>
        [JsonPropertyName("movieRating")]
        public RatingAustraliaMoviesType? MovieRating { get; set; }
    
        /// <summary>
        /// Gets or sets tvRating.
        /// TV rating selected for Australia. Possible values are: allAllowed, allBlocked, preschoolers, children, general, parentalGuidance, mature, agesAbove15, agesAbove15AdultViolence.
        /// </summary>
        [JsonPropertyName("tvRating")]
        public RatingAustraliaTelevisionType? TvRating { get; set; }
    
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
