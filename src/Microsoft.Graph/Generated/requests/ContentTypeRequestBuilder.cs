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
    /// The type ContentTypeRequestBuilder.
    /// </summary>
    public partial class ContentTypeRequestBuilder : EntityRequestBuilder, IContentTypeRequestBuilder
    {

        /// <summary>
        /// Constructs a new ContentTypeRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ContentTypeRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IContentTypeRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IContentTypeRequest Request(IEnumerable<Option> options)
        {
            return new ContentTypeRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for ColumnLinks.
        /// </summary>
        /// <returns>The <see cref="IContentTypeColumnLinksCollectionRequestBuilder"/>.</returns>
        public IContentTypeColumnLinksCollectionRequestBuilder ColumnLinks
        {
            get
            {
                return new ContentTypeColumnLinksCollectionRequestBuilder(this.AppendSegmentToRequestUrl("columnLinks"), this.Client);
            }
        }
    
    }
}
