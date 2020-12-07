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
    /// The type ImageInfo.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ImageInfo>))]
    public partial class ImageInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageInfo"/> class.
        /// </summary>
        public ImageInfo()
        {
            this.ODataType = "microsoft.graph.imageInfo";
        }

        /// <summary>
        /// Gets or sets addImageQuery.
        /// Optional; parameter used to indicate the server is able to render image dynamically in response to parameterization. For example – a high contrast image
        /// </summary>
        [JsonPropertyName("addImageQuery")]
        public bool? AddImageQuery { get; set; }
    
        /// <summary>
        /// Gets or sets alternateText.
        /// Optional; alt-text accessible content for the image
        /// </summary>
        [JsonPropertyName("alternateText")]
        public string AlternateText { get; set; }
    
        /// <summary>
        /// Gets or sets alternativeText.
        /// </summary>
        [JsonPropertyName("alternativeText")]
        public string AlternativeText { get; set; }
    
        /// <summary>
        /// Gets or sets iconUrl.
        /// Optional; URI that points to an icon which represents the application used to generate the activity
        /// </summary>
        [JsonPropertyName("iconUrl")]
        public string IconUrl { get; set; }
    
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
