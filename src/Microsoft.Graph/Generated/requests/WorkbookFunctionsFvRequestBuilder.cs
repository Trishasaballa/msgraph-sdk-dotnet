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
    /// The type WorkbookFunctionsFvRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsFvRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsFvRequest>, IWorkbookFunctionsFvRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsFvRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="rate">A rate parameter for the OData method call.</param>
        /// <param name="nper">A nper parameter for the OData method call.</param>
        /// <param name="pmt">A pmt parameter for the OData method call.</param>
        /// <param name="pv">A pv parameter for the OData method call.</param>
        /// <param name="type">A type parameter for the OData method call.</param>
        public WorkbookFunctionsFvRequestBuilder(
            string requestUrl,
            IBaseClient client,
            System.Text.Json.JsonDocument rate,
            System.Text.Json.JsonDocument nper,
            System.Text.Json.JsonDocument pmt,
            System.Text.Json.JsonDocument pv,
            System.Text.Json.JsonDocument type)
            : base(requestUrl, client)
        {
            this.SetParameter("rate", rate, true);
            this.SetParameter("nper", nper, true);
            this.SetParameter("pmt", pmt, true);
            this.SetParameter("pv", pv, true);
            this.SetParameter("type", type, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsFvRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsFvRequest(functionUrl, this.Client, options);

            if (this.HasParameter("rate"))
            {
                request.RequestBody.Rate = this.GetParameter<System.Text.Json.JsonDocument>("rate");
            }

            if (this.HasParameter("nper"))
            {
                request.RequestBody.Nper = this.GetParameter<System.Text.Json.JsonDocument>("nper");
            }

            if (this.HasParameter("pmt"))
            {
                request.RequestBody.Pmt = this.GetParameter<System.Text.Json.JsonDocument>("pmt");
            }

            if (this.HasParameter("pv"))
            {
                request.RequestBody.Pv = this.GetParameter<System.Text.Json.JsonDocument>("pv");
            }

            if (this.HasParameter("type"))
            {
                request.RequestBody.Type = this.GetParameter<System.Text.Json.JsonDocument>("type");
            }

            return request;
        }
    }
}
