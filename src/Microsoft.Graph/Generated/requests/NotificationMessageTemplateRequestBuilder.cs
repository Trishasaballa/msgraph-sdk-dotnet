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
    /// The type NotificationMessageTemplateRequestBuilder.
    /// </summary>
    public partial class NotificationMessageTemplateRequestBuilder : EntityRequestBuilder, INotificationMessageTemplateRequestBuilder
    {

        /// <summary>
        /// Constructs a new NotificationMessageTemplateRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public NotificationMessageTemplateRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new INotificationMessageTemplateRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new INotificationMessageTemplateRequest Request(IEnumerable<Option> options)
        {
            return new NotificationMessageTemplateRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for LocalizedNotificationMessages.
        /// </summary>
        /// <returns>The <see cref="INotificationMessageTemplateLocalizedNotificationMessagesCollectionRequestBuilder"/>.</returns>
        public INotificationMessageTemplateLocalizedNotificationMessagesCollectionRequestBuilder LocalizedNotificationMessages
        {
            get
            {
                return new NotificationMessageTemplateLocalizedNotificationMessagesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("localizedNotificationMessages"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for NotificationMessageTemplateSendTestMessage.
        /// </summary>
        /// <returns>The <see cref="INotificationMessageTemplateSendTestMessageRequestBuilder"/>.</returns>
        public INotificationMessageTemplateSendTestMessageRequestBuilder SendTestMessage()
        {
            return new NotificationMessageTemplateSendTestMessageRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.sendTestMessage"),
                this.Client);
        }
    
    }
}
