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
    /// The type WorkbookChartSeriesItemAtRequestBuilder.
    /// </summary>
    public partial class WorkbookChartSeriesItemAtRequestBuilder : BaseFunctionMethodRequestBuilder<IWorkbookChartSeriesItemAtRequest>, IWorkbookChartSeriesItemAtRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookChartSeriesItemAtRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="index">A index parameter for the OData method call.</param>
        public WorkbookChartSeriesItemAtRequestBuilder(
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
        protected override IWorkbookChartSeriesItemAtRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookChartSeriesItemAtRequest(functionUrl, this.Client, options);

            return request;
        }
        /// <summary>
        /// Gets the request builder for WorkbookChartSeriesCountRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartSeriesCountRequestBuilder"/>.</returns>
        public IWorkbookChartSeriesCountRequestBuilder Count()
        {
            return new WorkbookChartSeriesCountRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.count"),
                this.Client);
        }
        /// <summary>
        /// Gets the request builder for WorkbookChartSeriesItemAtRequestBuilder.
        /// </summary>
        /// <param name="index">A index parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookChartSeriesItemAtRequestBuilder"/>.</returns>
        public IWorkbookChartSeriesItemAtRequestBuilder ItemAt(
            Int32 index)
        {
            return new WorkbookChartSeriesItemAtRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.itemAt"),
                this.Client,
                index);
        }
        /// <summary>
        /// Gets the request builder for Format.
        /// Represents the formatting of a chart series, which includes fill and line formatting. Read-only.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartSeriesFormatRequestBuilder"/>.</returns>
        public IWorkbookChartSeriesFormatRequestBuilder Format
        {
            get
            {
                return new WorkbookChartSeriesFormatRequestBuilder(this.AppendSegmentToRequestUrl("format"), this.Client);
            }
        }
        /// <summary>
        /// Gets the request builder for Points.
        /// Represents a collection of all points in the series. Read-only.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartPointRequestBuilder"/>.</returns>
        public IWorkbookChartPointRequestBuilder Points
        {
            get
            {
                return new WorkbookChartPointRequestBuilder(this.AppendSegmentToRequestUrl("points"), this.Client);
            }
        }
    }
}
