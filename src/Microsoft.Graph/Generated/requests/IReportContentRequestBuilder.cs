// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IStreamRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System.Collections.Generic;

    /// <summary>
    /// The interface IReportContentRequestBuilder.
    /// </summary>
    public partial interface IReportContentRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IReportContentRequest Request(IEnumerable<Option> options = null);
    }
}
