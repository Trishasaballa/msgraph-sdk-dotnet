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
    /// The type PostAttachmentsCollectionRequestBuilder.
    /// </summary>
    public partial class PostAttachmentsCollectionRequestBuilder : BaseRequestBuilder, IPostAttachmentsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new PostAttachmentsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PostAttachmentsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IPostAttachmentsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IPostAttachmentsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new PostAttachmentsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IAttachmentRequestBuilder"/> for the specified PostAttachment.
        /// </summary>
        /// <param name="id">The ID for the PostAttachment.</param>
        /// <returns>The <see cref="IAttachmentRequestBuilder"/>.</returns>
        public IAttachmentRequestBuilder this[string id]
        {
            get
            {
                return new AttachmentRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AttachmentCreateUploadSession.
        /// </summary>
        /// <returns>The <see cref="IAttachmentCreateUploadSessionRequestBuilder"/>.</returns>
        public IAttachmentCreateUploadSessionRequestBuilder CreateUploadSession(
            AttachmentItem AttachmentItem)
        {
            return new AttachmentCreateUploadSessionRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.createUploadSession"),
                this.Client,
                AttachmentItem);
        }
    }
}
