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
    /// The interface IWorkbookTableRowsCollectionRequestBuilder.
    /// </summary>
    public partial interface IWorkbookTableRowsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IWorkbookTableRowsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IWorkbookTableRowsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IWorkbookTableRowRequestBuilder"/> for the specified WorkbookTableRow.
        /// </summary>
        /// <param name="id">The ID for the WorkbookTableRow.</param>
        /// <returns>The <see cref="IWorkbookTableRowRequestBuilder"/>.</returns>
        IWorkbookTableRowRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for WorkbookTableRowAdd.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableRowAddRequestBuilder"/>.</returns>
        IWorkbookTableRowAddRequestBuilder Add(
            Int32? index = null,
            Newtonsoft.Json.Linq.JToken values = null);

        /// <summary>
        /// Gets the request builder for WorkbookTableRowCount.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableRowCountRequestBuilder"/>.</returns>
        IWorkbookTableRowCountRequestBuilder Count();

        /// <summary>
        /// Gets the request builder for WorkbookTableRowItemAt.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableRowItemAtRequestBuilder"/>.</returns>
        IWorkbookTableRowItemAtRequestBuilder ItemAt(
            Int32 index);
    }
}
