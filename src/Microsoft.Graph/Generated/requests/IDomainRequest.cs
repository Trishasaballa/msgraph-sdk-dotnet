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
    /// The interface IDomainRequest.
    /// </summary>
    public partial interface IDomainRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Domain using POST.
        /// </summary>
        /// <param name="domainToCreate">The Domain to create.</param>
        /// <returns>The created Domain.</returns>
        System.Threading.Tasks.Task<Domain> CreateAsync(Domain domainToCreate);        /// <summary>
        /// Creates the specified Domain using POST.
        /// </summary>
        /// <param name="domainToCreate">The Domain to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Domain.</returns>
        System.Threading.Tasks.Task<Domain> CreateAsync(Domain domainToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Domain.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Domain.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Domain.
        /// </summary>
        /// <returns>The Domain.</returns>
        System.Threading.Tasks.Task<Domain> GetAsync();

        /// <summary>
        /// Gets the specified Domain.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Domain.</returns>
        System.Threading.Tasks.Task<Domain> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Domain using PATCH.
        /// </summary>
        /// <param name="domainToUpdate">The Domain to update.</param>
        /// <returns>The updated Domain.</returns>
        System.Threading.Tasks.Task<Domain> UpdateAsync(Domain domainToUpdate);

        /// <summary>
        /// Updates the specified Domain using PATCH.
        /// </summary>
        /// <param name="domainToUpdate">The Domain to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Domain.</returns>
        System.Threading.Tasks.Task<Domain> UpdateAsync(Domain domainToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDomainRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDomainRequest Expand(Expression<Func<Domain, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDomainRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDomainRequest Select(Expression<Func<Domain, object>> selectExpression);

    }
}
