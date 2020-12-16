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
    /// The type OnenotePagesCollectionRequestBuilder.
    /// </summary>
    public partial class OnenotePagesCollectionRequestBuilder : BaseRequestBuilder, IOnenotePagesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new OnenotePagesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public OnenotePagesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IOnenotePagesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IOnenotePagesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new OnenotePagesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IOnenotePageRequestBuilder"/> for the specified OnenoteOnenotePage.
        /// </summary>
        /// <param name="id">The ID for the OnenoteOnenotePage.</param>
        /// <returns>The <see cref="IOnenotePageRequestBuilder"/>.</returns>
        public IOnenotePageRequestBuilder this[string id]
        {
            get
            {
                return new OnenotePageRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
