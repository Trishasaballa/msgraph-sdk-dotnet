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
    /// The interface IWindowsPhone81CustomConfigurationRequest.
    /// </summary>
    public partial interface IWindowsPhone81CustomConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsPhone81CustomConfiguration using POST.
        /// </summary>
        /// <param name="windowsPhone81CustomConfigurationToCreate">The WindowsPhone81CustomConfiguration to create.</param>
        /// <returns>The created WindowsPhone81CustomConfiguration.</returns>
        System.Threading.Tasks.Task<WindowsPhone81CustomConfiguration> CreateAsync(WindowsPhone81CustomConfiguration windowsPhone81CustomConfigurationToCreate);        /// <summary>
        /// Creates the specified WindowsPhone81CustomConfiguration using POST.
        /// </summary>
        /// <param name="windowsPhone81CustomConfigurationToCreate">The WindowsPhone81CustomConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsPhone81CustomConfiguration.</returns>
        System.Threading.Tasks.Task<WindowsPhone81CustomConfiguration> CreateAsync(WindowsPhone81CustomConfiguration windowsPhone81CustomConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsPhone81CustomConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WindowsPhone81CustomConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsPhone81CustomConfiguration.
        /// </summary>
        /// <returns>The WindowsPhone81CustomConfiguration.</returns>
        System.Threading.Tasks.Task<WindowsPhone81CustomConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified WindowsPhone81CustomConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsPhone81CustomConfiguration.</returns>
        System.Threading.Tasks.Task<WindowsPhone81CustomConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsPhone81CustomConfiguration using PATCH.
        /// </summary>
        /// <param name="windowsPhone81CustomConfigurationToUpdate">The WindowsPhone81CustomConfiguration to update.</param>
        /// <returns>The updated WindowsPhone81CustomConfiguration.</returns>
        System.Threading.Tasks.Task<WindowsPhone81CustomConfiguration> UpdateAsync(WindowsPhone81CustomConfiguration windowsPhone81CustomConfigurationToUpdate);

        /// <summary>
        /// Updates the specified WindowsPhone81CustomConfiguration using PATCH.
        /// </summary>
        /// <param name="windowsPhone81CustomConfigurationToUpdate">The WindowsPhone81CustomConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsPhone81CustomConfiguration.</returns>
        System.Threading.Tasks.Task<WindowsPhone81CustomConfiguration> UpdateAsync(WindowsPhone81CustomConfiguration windowsPhone81CustomConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPhone81CustomConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPhone81CustomConfigurationRequest Expand(Expression<Func<WindowsPhone81CustomConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPhone81CustomConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPhone81CustomConfigurationRequest Select(Expression<Func<WindowsPhone81CustomConfiguration, object>> selectExpression);

    }
}
