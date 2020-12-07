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
    /// The type WorkbookFunctionsT_Dist_RTRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsT_Dist_RTRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsT_Dist_RTRequest>, IWorkbookFunctionsT_Dist_RTRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsT_Dist_RTRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="x">A x parameter for the OData method call.</param>
        /// <param name="degFreedom">A degFreedom parameter for the OData method call.</param>
        public WorkbookFunctionsT_Dist_RTRequestBuilder(
            string requestUrl,
            IBaseClient client,
            System.Text.Json.JsonDocument x,
            System.Text.Json.JsonDocument degFreedom)
            : base(requestUrl, client)
        {
            this.SetParameter("x", x, true);
            this.SetParameter("degFreedom", degFreedom, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsT_Dist_RTRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsT_Dist_RTRequest(functionUrl, this.Client, options);

            if (this.HasParameter("x"))
            {
                request.RequestBody.X = this.GetParameter<System.Text.Json.JsonDocument>("x");
            }

            if (this.HasParameter("degFreedom"))
            {
                request.RequestBody.DegFreedom = this.GetParameter<System.Text.Json.JsonDocument>("degFreedom");
            }

            return request;
        }
    }
}
