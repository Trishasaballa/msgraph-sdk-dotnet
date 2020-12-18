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
    /// The type WorkbookFunctionsImCosRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsImCosRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsImCosRequest>, IWorkbookFunctionsImCosRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsImCosRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="inumber">A inumber parameter for the OData method call.</param>
        public WorkbookFunctionsImCosRequestBuilder(
            string requestUrl,
            IBaseClient client,
            System.Text.Json.JsonDocument inumber)
            : base(requestUrl, client)
        {
            this.SetParameter("inumber", inumber, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsImCosRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsImCosRequest(functionUrl, this.Client, options);

            if (this.HasParameter("inumber"))
            {
                request.RequestBody.Inumber = this.GetParameter<System.Text.Json.JsonDocument>("inumber");
            }

            return request;
        }
    }
}
