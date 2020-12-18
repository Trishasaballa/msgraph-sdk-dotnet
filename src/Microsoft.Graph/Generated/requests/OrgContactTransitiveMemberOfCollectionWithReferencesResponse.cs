// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionWithReferencesResponse.cs.tt
namespace Microsoft.Graph
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type OrgContactTransitiveMemberOfCollectionWithReferencesResponse.
    /// </summary>
    public class OrgContactTransitiveMemberOfCollectionWithReferencesResponse
    {
        /// <summary>
        /// Gets or sets the <see cref="IOrgContactTransitiveMemberOfCollectionWithReferencesPage"/> value.
        /// </summary>
		[JsonPropertyName("value")]
        public IOrgContactTransitiveMemberOfCollectionWithReferencesPage Value { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}
