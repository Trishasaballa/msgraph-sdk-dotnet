// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IManagedEBookUserStateSummaryCollectionRequestBuilder.
    /// </summary>
    public partial interface IManagedEBookUserStateSummaryCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IManagedEBookUserStateSummaryCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IManagedEBookUserStateSummaryCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IUserInstallStateSummaryRequestBuilder"/> for the specified UserInstallStateSummary.
        /// </summary>
        /// <param name="id">The ID for the UserInstallStateSummary.</param>
        /// <returns>The <see cref="IUserInstallStateSummaryRequestBuilder"/>.</returns>
        IUserInstallStateSummaryRequestBuilder this[string id] { get; }

        
    }
}
