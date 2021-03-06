// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.CallRecords
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface ISessionSegmentsCollectionRequestBuilder.
    /// </summary>
    public partial interface ISessionSegmentsCollectionRequestBuilder : Microsoft.Graph.IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        ISessionSegmentsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        ISessionSegmentsCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options);

        /// <summary>
        /// Gets an <see cref="ISegmentRequestBuilder"/> for the specified Segment.
        /// </summary>
        /// <param name="id">The ID for the Segment.</param>
        /// <returns>The <see cref="ISegmentRequestBuilder"/>.</returns>
        ISegmentRequestBuilder this[string id] { get; }

        
    }
}
