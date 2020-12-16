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
    /// The type TodoRequestBuilder.
    /// </summary>
    public partial class TodoRequestBuilder : EntityRequestBuilder, ITodoRequestBuilder
    {

        /// <summary>
        /// Constructs a new TodoRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public TodoRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new ITodoRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new ITodoRequest Request(IEnumerable<Option> options)
        {
            return new TodoRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Lists.
        /// </summary>
        /// <returns>The <see cref="ITodoListsCollectionRequestBuilder"/>.</returns>
        public ITodoListsCollectionRequestBuilder Lists
        {
            get
            {
                return new TodoListsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("lists"), this.Client);
            }
        }
    
    }
}
