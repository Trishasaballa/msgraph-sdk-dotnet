// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionReferencesRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IServicePrincipalTokenIssuancePoliciesCollectionReferencesRequest.
    /// </summary>
    public partial interface IServicePrincipalTokenIssuancePoliciesCollectionReferencesRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified TokenIssuancePolicy to the collection via POST.
        /// </summary>
        /// <param name="tokenIssuancePolicy">The TokenIssuancePolicy to add.</param>
        System.Threading.Tasks.Task AddAsync(TokenIssuancePolicy tokenIssuancePolicy);

        /// <summary>
        /// Adds the specified TokenIssuancePolicy to the collection via POST.
        /// </summary>
        /// <param name="tokenIssuancePolicy">The TokenIssuancePolicy to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        System.Threading.Tasks.Task AddAsync(TokenIssuancePolicy tokenIssuancePolicy, CancellationToken cancellationToken);
    }
}
