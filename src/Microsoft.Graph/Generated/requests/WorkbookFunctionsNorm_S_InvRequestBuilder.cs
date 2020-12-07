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
    /// The type WorkbookFunctionsNorm_S_InvRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsNorm_S_InvRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsNorm_S_InvRequest>, IWorkbookFunctionsNorm_S_InvRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsNorm_S_InvRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="probability">A probability parameter for the OData method call.</param>
        public WorkbookFunctionsNorm_S_InvRequestBuilder(
            string requestUrl,
            IBaseClient client,
            System.Text.Json.JsonDocument probability)
            : base(requestUrl, client)
        {
            this.SetParameter("probability", probability, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsNorm_S_InvRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsNorm_S_InvRequest(functionUrl, this.Client, options);

            if (this.HasParameter("probability"))
            {
                request.RequestBody.Probability = this.GetParameter<System.Text.Json.JsonDocument>("probability");
            }

            return request;
        }
    }
}
