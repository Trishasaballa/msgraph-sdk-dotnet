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
    /// The type ManagedAndroidStoreAppRequestBuilder.
    /// </summary>
    public partial class ManagedAndroidStoreAppRequestBuilder : ManagedAppRequestBuilder, IManagedAndroidStoreAppRequestBuilder
    {

        /// <summary>
        /// Constructs a new ManagedAndroidStoreAppRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ManagedAndroidStoreAppRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IManagedAndroidStoreAppRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IManagedAndroidStoreAppRequest Request(IEnumerable<Option> options)
        {
            return new ManagedAndroidStoreAppRequest(this.RequestUrl, this.Client, options);
        }
    
    }
}
