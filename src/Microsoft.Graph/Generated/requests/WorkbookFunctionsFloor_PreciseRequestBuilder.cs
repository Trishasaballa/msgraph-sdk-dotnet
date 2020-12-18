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
    /// The type WorkbookFunctionsFloor_PreciseRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsFloor_PreciseRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsFloor_PreciseRequest>, IWorkbookFunctionsFloor_PreciseRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsFloor_PreciseRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="number">A number parameter for the OData method call.</param>
        /// <param name="significance">A significance parameter for the OData method call.</param>
        public WorkbookFunctionsFloor_PreciseRequestBuilder(
            string requestUrl,
            IBaseClient client,
            System.Text.Json.JsonDocument number,
            System.Text.Json.JsonDocument significance)
            : base(requestUrl, client)
        {
            this.SetParameter("number", number, true);
            this.SetParameter("significance", significance, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsFloor_PreciseRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsFloor_PreciseRequest(functionUrl, this.Client, options);

            if (this.HasParameter("number"))
            {
                request.RequestBody.Number = this.GetParameter<System.Text.Json.JsonDocument>("number");
            }

            if (this.HasParameter("significance"))
            {
                request.RequestBody.Significance = this.GetParameter<System.Text.Json.JsonDocument>("significance");
            }

            return request;
        }
    }
}
