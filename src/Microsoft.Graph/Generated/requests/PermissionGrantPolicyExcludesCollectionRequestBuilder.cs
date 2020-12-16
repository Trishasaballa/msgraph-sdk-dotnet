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
    /// The type PermissionGrantPolicyExcludesCollectionRequestBuilder.
    /// </summary>
    public partial class PermissionGrantPolicyExcludesCollectionRequestBuilder : BaseRequestBuilder, IPermissionGrantPolicyExcludesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new PermissionGrantPolicyExcludesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PermissionGrantPolicyExcludesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IPermissionGrantPolicyExcludesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IPermissionGrantPolicyExcludesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new PermissionGrantPolicyExcludesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IPermissionGrantConditionSetRequestBuilder"/> for the specified PermissionGrantPolicyPermissionGrantConditionSet.
        /// </summary>
        /// <param name="id">The ID for the PermissionGrantPolicyPermissionGrantConditionSet.</param>
        /// <returns>The <see cref="IPermissionGrantConditionSetRequestBuilder"/>.</returns>
        public IPermissionGrantConditionSetRequestBuilder this[string id]
        {
            get
            {
                return new PermissionGrantConditionSetRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
