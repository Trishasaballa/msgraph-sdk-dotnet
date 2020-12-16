// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ServicePrincipalHomeRealmDiscoveryPoliciesCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class ServicePrincipalHomeRealmDiscoveryPoliciesCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IServicePrincipalHomeRealmDiscoveryPoliciesCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new ServicePrincipalHomeRealmDiscoveryPoliciesCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ServicePrincipalHomeRealmDiscoveryPoliciesCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IServicePrincipalHomeRealmDiscoveryPoliciesCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IServicePrincipalHomeRealmDiscoveryPoliciesCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new ServicePrincipalHomeRealmDiscoveryPoliciesCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IHomeRealmDiscoveryPolicyWithReferenceRequestBuilder"/> for the specified ServicePrincipalHomeRealmDiscoveryPolicy.
        /// </summary>
        /// <param name="id">The ID for the ServicePrincipalHomeRealmDiscoveryPolicy.</param>
        /// <returns>The <see cref="IHomeRealmDiscoveryPolicyWithReferenceRequestBuilder"/>.</returns>
        public IHomeRealmDiscoveryPolicyWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new HomeRealmDiscoveryPolicyWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IServicePrincipalHomeRealmDiscoveryPoliciesCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalHomeRealmDiscoveryPoliciesCollectionReferencesRequestBuilder"/>.</returns>
        public IServicePrincipalHomeRealmDiscoveryPoliciesCollectionReferencesRequestBuilder References
        {
            get
            {
                return new ServicePrincipalHomeRealmDiscoveryPoliciesCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
