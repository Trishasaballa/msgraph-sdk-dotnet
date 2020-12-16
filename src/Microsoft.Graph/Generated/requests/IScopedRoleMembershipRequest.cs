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
    /// The interface IScopedRoleMembershipRequest.
    /// </summary>
    public partial interface IScopedRoleMembershipRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ScopedRoleMembership using POST.
        /// </summary>
        /// <param name="scopedRoleMembershipToCreate">The ScopedRoleMembership to create.</param>
        /// <returns>The created ScopedRoleMembership.</returns>
        System.Threading.Tasks.Task<ScopedRoleMembership> CreateAsync(ScopedRoleMembership scopedRoleMembershipToCreate);        /// <summary>
        /// Creates the specified ScopedRoleMembership using POST.
        /// </summary>
        /// <param name="scopedRoleMembershipToCreate">The ScopedRoleMembership to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ScopedRoleMembership.</returns>
        System.Threading.Tasks.Task<ScopedRoleMembership> CreateAsync(ScopedRoleMembership scopedRoleMembershipToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ScopedRoleMembership.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ScopedRoleMembership.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ScopedRoleMembership.
        /// </summary>
        /// <returns>The ScopedRoleMembership.</returns>
        System.Threading.Tasks.Task<ScopedRoleMembership> GetAsync();

        /// <summary>
        /// Gets the specified ScopedRoleMembership.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ScopedRoleMembership.</returns>
        System.Threading.Tasks.Task<ScopedRoleMembership> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ScopedRoleMembership using PATCH.
        /// </summary>
        /// <param name="scopedRoleMembershipToUpdate">The ScopedRoleMembership to update.</param>
        /// <returns>The updated ScopedRoleMembership.</returns>
        System.Threading.Tasks.Task<ScopedRoleMembership> UpdateAsync(ScopedRoleMembership scopedRoleMembershipToUpdate);

        /// <summary>
        /// Updates the specified ScopedRoleMembership using PATCH.
        /// </summary>
        /// <param name="scopedRoleMembershipToUpdate">The ScopedRoleMembership to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ScopedRoleMembership.</returns>
        System.Threading.Tasks.Task<ScopedRoleMembership> UpdateAsync(ScopedRoleMembership scopedRoleMembershipToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IScopedRoleMembershipRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IScopedRoleMembershipRequest Expand(Expression<Func<ScopedRoleMembership, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IScopedRoleMembershipRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IScopedRoleMembershipRequest Select(Expression<Func<ScopedRoleMembership, object>> selectExpression);

    }
}
