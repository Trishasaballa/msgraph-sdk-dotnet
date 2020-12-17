// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ItemActivityStatRequestBuilder.
    /// </summary>
    public partial class ItemActivityStatRequestBuilder : EntityRequestBuilder, IItemActivityStatRequestBuilder
    {

        /// <summary>
        /// Constructs a new ItemActivityStatRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ItemActivityStatRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IItemActivityStatRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IItemActivityStatRequest Request(IEnumerable<Option> options)
        {
            return new ItemActivityStatRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Activities.
        /// </summary>
        /// <returns>The <see cref="IItemActivityStatActivitiesCollectionRequestBuilder"/>.</returns>
        public IItemActivityStatActivitiesCollectionRequestBuilder Activities
        {
            get
            {
                return new ItemActivityStatActivitiesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("activities"), this.Client);
            }
        }
    
    }
}
