// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookFunctionsChiSq_InvRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsChiSq_InvRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsChiSq_InvRequest>, IWorkbookFunctionsChiSq_InvRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsChiSq_InvRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="probability">A probability parameter for the OData method call.</param>
        /// <param name="degFreedom">A degFreedom parameter for the OData method call.</param>
        public WorkbookFunctionsChiSq_InvRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken probability,
            Newtonsoft.Json.Linq.JToken degFreedom)
            : base(requestUrl, client)
        {
            this.SetParameter("probability", probability, true);
            this.SetParameter("degFreedom", degFreedom, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsChiSq_InvRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsChiSq_InvRequest(functionUrl, this.Client, options);

            if (this.HasParameter("probability"))
            {
                request.RequestBody.Probability = this.GetParameter<Newtonsoft.Json.Linq.JToken>("probability");
            }

            if (this.HasParameter("degFreedom"))
            {
                request.RequestBody.DegFreedom = this.GetParameter<Newtonsoft.Json.Linq.JToken>("degFreedom");
            }

            return request;
        }
    }
}
