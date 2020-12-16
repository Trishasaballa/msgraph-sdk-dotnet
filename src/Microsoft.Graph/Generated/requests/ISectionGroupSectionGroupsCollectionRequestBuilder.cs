// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface ISectionGroupSectionGroupsCollectionRequestBuilder.
    /// </summary>
    public partial interface ISectionGroupSectionGroupsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        ISectionGroupSectionGroupsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        ISectionGroupSectionGroupsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="ISectionGroupRequestBuilder"/> for the specified SectionGroup.
        /// </summary>
        /// <param name="id">The ID for the SectionGroup.</param>
        /// <returns>The <see cref="ISectionGroupRequestBuilder"/>.</returns>
        ISectionGroupRequestBuilder this[string id] { get; }

        
    }
}
