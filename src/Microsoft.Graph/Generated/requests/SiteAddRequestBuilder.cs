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
    /// The type SiteAddRequestBuilder.
    /// </summary>
    public partial class SiteAddRequestBuilder : BaseActionMethodRequestBuilder<ISiteAddRequest>, ISiteAddRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="SiteAddRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="value">A value parameter for the OData method call.</param>
        public SiteAddRequestBuilder(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Site> value)
            : base(requestUrl, client)
        {
            this.SetParameter("value", value, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override ISiteAddRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new SiteAddRequest(functionUrl, this.Client, options);

            if (this.HasParameter("value"))
            {
                request.RequestBody.Value = this.GetParameter<IEnumerable<Site>>("value");
            }

            return request;
        }
    }
}
