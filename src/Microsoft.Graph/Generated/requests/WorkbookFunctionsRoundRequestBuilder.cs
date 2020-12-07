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
    /// The type WorkbookFunctionsRoundRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsRoundRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsRoundRequest>, IWorkbookFunctionsRoundRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsRoundRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="number">A number parameter for the OData method call.</param>
        /// <param name="numDigits">A numDigits parameter for the OData method call.</param>
        public WorkbookFunctionsRoundRequestBuilder(
            string requestUrl,
            IBaseClient client,
            System.Text.Json.JsonDocument number,
            System.Text.Json.JsonDocument numDigits)
            : base(requestUrl, client)
        {
            this.SetParameter("number", number, true);
            this.SetParameter("numDigits", numDigits, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsRoundRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsRoundRequest(functionUrl, this.Client, options);

            if (this.HasParameter("number"))
            {
                request.RequestBody.Number = this.GetParameter<System.Text.Json.JsonDocument>("number");
            }

            if (this.HasParameter("numDigits"))
            {
                request.RequestBody.NumDigits = this.GetParameter<System.Text.Json.JsonDocument>("numDigits");
            }

            return request;
        }
    }
}
