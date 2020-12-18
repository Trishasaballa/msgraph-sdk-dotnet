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
    /// The type WorkbookFunctionsYearFracRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsYearFracRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsYearFracRequest>, IWorkbookFunctionsYearFracRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsYearFracRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="startDate">A startDate parameter for the OData method call.</param>
        /// <param name="endDate">A endDate parameter for the OData method call.</param>
        /// <param name="basis">A basis parameter for the OData method call.</param>
        public WorkbookFunctionsYearFracRequestBuilder(
            string requestUrl,
            IBaseClient client,
            System.Text.Json.JsonDocument startDate,
            System.Text.Json.JsonDocument endDate,
            System.Text.Json.JsonDocument basis)
            : base(requestUrl, client)
        {
            this.SetParameter("startDate", startDate, true);
            this.SetParameter("endDate", endDate, true);
            this.SetParameter("basis", basis, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsYearFracRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsYearFracRequest(functionUrl, this.Client, options);

            if (this.HasParameter("startDate"))
            {
                request.RequestBody.StartDate = this.GetParameter<System.Text.Json.JsonDocument>("startDate");
            }

            if (this.HasParameter("endDate"))
            {
                request.RequestBody.EndDate = this.GetParameter<System.Text.Json.JsonDocument>("endDate");
            }

            if (this.HasParameter("basis"))
            {
                request.RequestBody.Basis = this.GetParameter<System.Text.Json.JsonDocument>("basis");
            }

            return request;
        }
    }
}
