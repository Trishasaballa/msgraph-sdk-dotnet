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
    /// The interface IGraphServiceSchemaExtensionsCollectionRequestBuilder.
    /// </summary>
    public partial interface IGraphServiceSchemaExtensionsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IGraphServiceSchemaExtensionsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IGraphServiceSchemaExtensionsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="ISchemaExtensionRequestBuilder"/> for the specified SchemaExtension.
        /// </summary>
        /// <param name="id">The ID for the SchemaExtension.</param>
        /// <returns>The <see cref="ISchemaExtensionRequestBuilder"/>.</returns>
        ISchemaExtensionRequestBuilder this[string id] { get; }

        
    }
}
