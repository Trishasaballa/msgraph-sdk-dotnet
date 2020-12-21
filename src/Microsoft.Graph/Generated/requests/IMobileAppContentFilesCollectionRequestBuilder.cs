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
    /// The interface IMobileAppContentFilesCollectionRequestBuilder.
    /// </summary>
    public partial interface IMobileAppContentFilesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IMobileAppContentFilesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IMobileAppContentFilesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IMobileAppContentFileRequestBuilder"/> for the specified MobileAppContentFile.
        /// </summary>
        /// <param name="id">The ID for the MobileAppContentFile.</param>
        /// <returns>The <see cref="IMobileAppContentFileRequestBuilder"/>.</returns>
        IMobileAppContentFileRequestBuilder this[string id] { get; }

        
    }
}
