// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ItemAnalyticsItemActivityStatsCollectionRequestBuilder.
    /// </summary>
    public partial class ItemAnalyticsItemActivityStatsCollectionRequestBuilder : BaseRequestBuilder, IItemAnalyticsItemActivityStatsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ItemAnalyticsItemActivityStatsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ItemAnalyticsItemActivityStatsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IItemAnalyticsItemActivityStatsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IItemAnalyticsItemActivityStatsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ItemAnalyticsItemActivityStatsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IItemActivityStatRequestBuilder"/> for the specified ItemAnalyticsItemActivityStat.
        /// </summary>
        /// <param name="id">The ID for the ItemAnalyticsItemActivityStat.</param>
        /// <returns>The <see cref="IItemActivityStatRequestBuilder"/>.</returns>
        public IItemActivityStatRequestBuilder this[string id]
        {
            get
            {
                return new ItemActivityStatRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
