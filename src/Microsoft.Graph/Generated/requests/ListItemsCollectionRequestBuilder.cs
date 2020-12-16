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
    /// The type ListItemsCollectionRequestBuilder.
    /// </summary>
    public partial class ListItemsCollectionRequestBuilder : BaseRequestBuilder, IListItemsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ListItemsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ListItemsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IListItemsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IListItemsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ListItemsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IListItemRequestBuilder"/> for the specified ListListItem.
        /// </summary>
        /// <param name="id">The ID for the ListListItem.</param>
        /// <returns>The <see cref="IListItemRequestBuilder"/>.</returns>
        public IListItemRequestBuilder this[string id]
        {
            get
            {
                return new ListItemRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
