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
    /// The type DriveItemUploadableProperties.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DriveItemUploadableProperties>))]
    public partial class DriveItemUploadableProperties
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DriveItemUploadableProperties"/> class.
        /// </summary>
        public DriveItemUploadableProperties()
        {
            this.ODataType = "microsoft.graph.driveItemUploadableProperties";
        }

        /// <summary>
        /// Gets or sets description.
        /// Provides a user-visible description of the item. Read-write. Only on OneDrive Personal.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets fileSize.
        /// Provides an expected file size to perform a quota check prior to upload. Only on OneDrive Personal.
        /// </summary>
        [JsonPropertyName("fileSize")]
        public Int64? FileSize { get; set; }
    
        /// <summary>
        /// Gets or sets fileSystemInfo.
        /// File system information on client. Read-write.
        /// </summary>
        [JsonPropertyName("fileSystemInfo")]
        public FileSystemInfo FileSystemInfo { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// The name of the item (filename and extension). Read-write.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
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
