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
    /// The type WorkbookFunctionsEffectRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsEffectRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsEffectRequest>, IWorkbookFunctionsEffectRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsEffectRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="nominalRate">A nominalRate parameter for the OData method call.</param>
        /// <param name="npery">A npery parameter for the OData method call.</param>
        public WorkbookFunctionsEffectRequestBuilder(
            string requestUrl,
            IBaseClient client,
            System.Text.Json.JsonDocument nominalRate,
            System.Text.Json.JsonDocument npery)
            : base(requestUrl, client)
        {
            this.SetParameter("nominalRate", nominalRate, true);
            this.SetParameter("npery", npery, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsEffectRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsEffectRequest(functionUrl, this.Client, options);

            if (this.HasParameter("nominalRate"))
            {
                request.RequestBody.NominalRate = this.GetParameter<System.Text.Json.JsonDocument>("nominalRate");
            }

            if (this.HasParameter("npery"))
            {
                request.RequestBody.Npery = this.GetParameter<System.Text.Json.JsonDocument>("npery");
            }

            return request;
        }
    }
}
