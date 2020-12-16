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
    /// The interface IDeviceRequest.
    /// </summary>
    public partial interface IDeviceRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Device using POST.
        /// </summary>
        /// <param name="deviceToCreate">The Device to create.</param>
        /// <returns>The created Device.</returns>
        System.Threading.Tasks.Task<Device> CreateAsync(Device deviceToCreate);        /// <summary>
        /// Creates the specified Device using POST.
        /// </summary>
        /// <param name="deviceToCreate">The Device to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Device.</returns>
        System.Threading.Tasks.Task<Device> CreateAsync(Device deviceToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Device.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Device.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Device.
        /// </summary>
        /// <returns>The Device.</returns>
        System.Threading.Tasks.Task<Device> GetAsync();

        /// <summary>
        /// Gets the specified Device.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Device.</returns>
        System.Threading.Tasks.Task<Device> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Device using PATCH.
        /// </summary>
        /// <param name="deviceToUpdate">The Device to update.</param>
        /// <returns>The updated Device.</returns>
        System.Threading.Tasks.Task<Device> UpdateAsync(Device deviceToUpdate);

        /// <summary>
        /// Updates the specified Device using PATCH.
        /// </summary>
        /// <param name="deviceToUpdate">The Device to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Device.</returns>
        System.Threading.Tasks.Task<Device> UpdateAsync(Device deviceToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceRequest Expand(Expression<Func<Device, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceRequest Select(Expression<Func<Device, object>> selectExpression);

    }
}
