// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IServicePrincipalOauth2PermissionGrantsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IServicePrincipalOauth2PermissionGrantsCollectionWithReferencesRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IServicePrincipalOauth2PermissionGrantsCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IServicePrincipalOauth2PermissionGrantsCollectionWithReferencesRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IOAuth2PermissionGrantWithReferenceRequestBuilder"/> for the specified OAuth2PermissionGrant.
        /// </summary>
        /// <param name="id">The ID for the OAuth2PermissionGrant.</param>
        /// <returns>The <see cref="IOAuth2PermissionGrantWithReferenceRequestBuilder"/>.</returns>
        IOAuth2PermissionGrantWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IServicePrincipalOauth2PermissionGrantsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalOauth2PermissionGrantsCollectionReferencesRequestBuilder"/>.</returns>
        IServicePrincipalOauth2PermissionGrantsCollectionReferencesRequestBuilder References { get; }

    }
}
