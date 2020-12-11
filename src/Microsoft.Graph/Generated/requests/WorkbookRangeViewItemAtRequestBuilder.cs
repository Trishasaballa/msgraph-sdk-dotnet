// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookRangeViewItemAtRequestBuilder.
    /// </summary>
    public partial class WorkbookRangeViewItemAtRequestBuilder : BaseFunctionMethodRequestBuilder<IWorkbookRangeViewItemAtRequest>, IWorkbookRangeViewItemAtRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookRangeViewItemAtRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="index">A index parameter for the OData method call.</param>
        public WorkbookRangeViewItemAtRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Int32 index)
            : base(requestUrl, client)
        {
            this.SetParameter("index", index, false);
            this.SetFunctionParameters();
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookRangeViewItemAtRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookRangeViewItemAtRequest(functionUrl, this.Client, options);

            return request;
        }
        /// <summary>
        /// Gets the request builder for WorkbookRangeViewItemAtRequestBuilder.
        /// </summary>
        /// <param name="index">A index parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookRangeViewItemAtRequestBuilder"/>.</returns>
        public IWorkbookRangeViewItemAtRequestBuilder ItemAt(
            Int32 index)
        {
            return new WorkbookRangeViewItemAtRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.itemAt"),
                this.Client,
                index);
        }
        /// <summary>
        /// Gets the request builder for WorkbookRangeViewRangeRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeViewRangeRequestBuilder"/>.</returns>
        public IWorkbookRangeViewRangeRequestBuilder Range()
        {
            return new WorkbookRangeViewRangeRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.range"),
                this.Client);
        }
        /// <summary>
        /// Gets the request builder for Rows.
        /// Represents a collection of range views associated with the range. Read-only. Read-only.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeViewRequestBuilder"/>.</returns>
        public IWorkbookRangeViewRequestBuilder Rows
        {
            get
            {
                return new WorkbookRangeViewRequestBuilder(this.AppendSegmentToRequestUrl("rows"), this.Client);
            }
        }
    }
}
