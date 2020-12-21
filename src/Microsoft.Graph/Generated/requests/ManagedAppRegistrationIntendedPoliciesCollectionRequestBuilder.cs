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
    /// The type ManagedAppRegistrationIntendedPoliciesCollectionRequestBuilder.
    /// </summary>
    public partial class ManagedAppRegistrationIntendedPoliciesCollectionRequestBuilder : BaseRequestBuilder, IManagedAppRegistrationIntendedPoliciesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ManagedAppRegistrationIntendedPoliciesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ManagedAppRegistrationIntendedPoliciesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IManagedAppRegistrationIntendedPoliciesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IManagedAppRegistrationIntendedPoliciesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ManagedAppRegistrationIntendedPoliciesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IManagedAppPolicyRequestBuilder"/> for the specified ManagedAppRegistrationManagedAppPolicy.
        /// </summary>
        /// <param name="id">The ID for the ManagedAppRegistrationManagedAppPolicy.</param>
        /// <returns>The <see cref="IManagedAppPolicyRequestBuilder"/>.</returns>
        public IManagedAppPolicyRequestBuilder this[string id]
        {
            get
            {
                return new ManagedAppPolicyRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
