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
    /// The interface IListColumnsCollectionRequestBuilder.
    /// </summary>
    public partial interface IListColumnsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IListColumnsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IListColumnsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IColumnDefinitionRequestBuilder"/> for the specified ColumnDefinition.
        /// </summary>
        /// <param name="id">The ID for the ColumnDefinition.</param>
        /// <returns>The <see cref="IColumnDefinitionRequestBuilder"/>.</returns>
        IColumnDefinitionRequestBuilder this[string id] { get; }

        
    }
}
