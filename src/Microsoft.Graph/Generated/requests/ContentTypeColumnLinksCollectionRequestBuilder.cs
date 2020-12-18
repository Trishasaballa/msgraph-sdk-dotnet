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
    /// The type ContentTypeColumnLinksCollectionRequestBuilder.
    /// </summary>
    public partial class ContentTypeColumnLinksCollectionRequestBuilder : BaseRequestBuilder, IContentTypeColumnLinksCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ContentTypeColumnLinksCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ContentTypeColumnLinksCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IContentTypeColumnLinksCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IContentTypeColumnLinksCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ContentTypeColumnLinksCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IColumnLinkRequestBuilder"/> for the specified ContentTypeColumnLink.
        /// </summary>
        /// <param name="id">The ID for the ContentTypeColumnLink.</param>
        /// <returns>The <see cref="IColumnLinkRequestBuilder"/>.</returns>
        public IColumnLinkRequestBuilder this[string id]
        {
            get
            {
                return new ColumnLinkRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
