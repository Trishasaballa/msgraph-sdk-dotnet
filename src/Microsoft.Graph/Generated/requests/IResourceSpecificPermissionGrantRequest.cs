// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IResourceSpecificPermissionGrantRequest.
    /// </summary>
    public partial interface IResourceSpecificPermissionGrantRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ResourceSpecificPermissionGrant using POST.
        /// </summary>
        /// <param name="resourceSpecificPermissionGrantToCreate">The ResourceSpecificPermissionGrant to create.</param>
        /// <returns>The created ResourceSpecificPermissionGrant.</returns>
        System.Threading.Tasks.Task<ResourceSpecificPermissionGrant> CreateAsync(ResourceSpecificPermissionGrant resourceSpecificPermissionGrantToCreate);        /// <summary>
        /// Creates the specified ResourceSpecificPermissionGrant using POST.
        /// </summary>
        /// <param name="resourceSpecificPermissionGrantToCreate">The ResourceSpecificPermissionGrant to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ResourceSpecificPermissionGrant.</returns>
        System.Threading.Tasks.Task<ResourceSpecificPermissionGrant> CreateAsync(ResourceSpecificPermissionGrant resourceSpecificPermissionGrantToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ResourceSpecificPermissionGrant.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ResourceSpecificPermissionGrant.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ResourceSpecificPermissionGrant.
        /// </summary>
        /// <returns>The ResourceSpecificPermissionGrant.</returns>
        System.Threading.Tasks.Task<ResourceSpecificPermissionGrant> GetAsync();

        /// <summary>
        /// Gets the specified ResourceSpecificPermissionGrant.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ResourceSpecificPermissionGrant.</returns>
        System.Threading.Tasks.Task<ResourceSpecificPermissionGrant> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ResourceSpecificPermissionGrant using PATCH.
        /// </summary>
        /// <param name="resourceSpecificPermissionGrantToUpdate">The ResourceSpecificPermissionGrant to update.</param>
        /// <returns>The updated ResourceSpecificPermissionGrant.</returns>
        System.Threading.Tasks.Task<ResourceSpecificPermissionGrant> UpdateAsync(ResourceSpecificPermissionGrant resourceSpecificPermissionGrantToUpdate);

        /// <summary>
        /// Updates the specified ResourceSpecificPermissionGrant using PATCH.
        /// </summary>
        /// <param name="resourceSpecificPermissionGrantToUpdate">The ResourceSpecificPermissionGrant to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ResourceSpecificPermissionGrant.</returns>
        System.Threading.Tasks.Task<ResourceSpecificPermissionGrant> UpdateAsync(ResourceSpecificPermissionGrant resourceSpecificPermissionGrantToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IResourceSpecificPermissionGrantRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IResourceSpecificPermissionGrantRequest Expand(Expression<Func<ResourceSpecificPermissionGrant, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IResourceSpecificPermissionGrantRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IResourceSpecificPermissionGrantRequest Select(Expression<Func<ResourceSpecificPermissionGrant, object>> selectExpression);

    }
}
