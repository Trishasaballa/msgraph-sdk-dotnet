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
    /// The type WorkbookFunctionsCothRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsCothRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsCothRequest>, IWorkbookFunctionsCothRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsCothRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="number">A number parameter for the OData method call.</param>
        public WorkbookFunctionsCothRequestBuilder(
            string requestUrl,
            IBaseClient client,
            System.Text.Json.JsonDocument number)
            : base(requestUrl, client)
        {
            this.SetParameter("number", number, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsCothRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsCothRequest(functionUrl, this.Client, options);

            if (this.HasParameter("number"))
            {
                request.RequestBody.Number = this.GetParameter<System.Text.Json.JsonDocument>("number");
            }

            return request;
        }
    }
}
