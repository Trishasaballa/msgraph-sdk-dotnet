// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IPolicyRootActivityBasedTimeoutPoliciesCollectionRequest.
    /// </summary>
    public partial interface IPolicyRootActivityBasedTimeoutPoliciesCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified ActivityBasedTimeoutPolicy to the collection via POST.
        /// </summary>
        /// <param name="activityBasedTimeoutPolicy">The ActivityBasedTimeoutPolicy to add.</param>
        /// <returns>The created ActivityBasedTimeoutPolicy.</returns>
        System.Threading.Tasks.Task<ActivityBasedTimeoutPolicy> AddAsync(ActivityBasedTimeoutPolicy activityBasedTimeoutPolicy);

        /// <summary>
        /// Adds the specified ActivityBasedTimeoutPolicy to the collection via POST.
        /// </summary>
        /// <param name="activityBasedTimeoutPolicy">The ActivityBasedTimeoutPolicy to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ActivityBasedTimeoutPolicy.</returns>
        System.Threading.Tasks.Task<ActivityBasedTimeoutPolicy> AddAsync(ActivityBasedTimeoutPolicy activityBasedTimeoutPolicy, CancellationToken cancellationToken);
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IPolicyRootActivityBasedTimeoutPoliciesCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IPolicyRootActivityBasedTimeoutPoliciesCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPolicyRootActivityBasedTimeoutPoliciesCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPolicyRootActivityBasedTimeoutPoliciesCollectionRequest Expand(Expression<Func<ActivityBasedTimeoutPolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPolicyRootActivityBasedTimeoutPoliciesCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPolicyRootActivityBasedTimeoutPoliciesCollectionRequest Select(Expression<Func<ActivityBasedTimeoutPolicy, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IPolicyRootActivityBasedTimeoutPoliciesCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IPolicyRootActivityBasedTimeoutPoliciesCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IPolicyRootActivityBasedTimeoutPoliciesCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IPolicyRootActivityBasedTimeoutPoliciesCollectionRequest OrderBy(string value);
    }
}
