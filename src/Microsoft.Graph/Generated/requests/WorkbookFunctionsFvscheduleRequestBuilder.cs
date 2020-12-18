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
    /// The type WorkbookFunctionsFvscheduleRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsFvscheduleRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsFvscheduleRequest>, IWorkbookFunctionsFvscheduleRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsFvscheduleRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="principal">A principal parameter for the OData method call.</param>
        /// <param name="schedule">A schedule parameter for the OData method call.</param>
        public WorkbookFunctionsFvscheduleRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken principal,
            Newtonsoft.Json.Linq.JToken schedule)
            : base(requestUrl, client)
        {
            this.SetParameter("principal", principal, true);
            this.SetParameter("schedule", schedule, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsFvscheduleRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsFvscheduleRequest(functionUrl, this.Client, options);

            if (this.HasParameter("principal"))
            {
                request.RequestBody.Principal = this.GetParameter<Newtonsoft.Json.Linq.JToken>("principal");
            }

            if (this.HasParameter("schedule"))
            {
                request.RequestBody.Schedule = this.GetParameter<Newtonsoft.Json.Linq.JToken>("schedule");
            }

            return request;
        }
    }
}
