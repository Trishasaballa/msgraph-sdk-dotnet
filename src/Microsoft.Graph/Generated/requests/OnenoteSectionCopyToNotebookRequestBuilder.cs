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
    /// The type OnenoteSectionCopyToNotebookRequestBuilder.
    /// </summary>
    public partial class OnenoteSectionCopyToNotebookRequestBuilder : BaseActionMethodRequestBuilder<IOnenoteSectionCopyToNotebookRequest>, IOnenoteSectionCopyToNotebookRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="OnenoteSectionCopyToNotebookRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="id">A id parameter for the OData method call.</param>
        /// <param name="groupId">A groupId parameter for the OData method call.</param>
        /// <param name="renameAs">A renameAs parameter for the OData method call.</param>
        /// <param name="siteCollectionId">A siteCollectionId parameter for the OData method call.</param>
        /// <param name="siteId">A siteId parameter for the OData method call.</param>
        public OnenoteSectionCopyToNotebookRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string id,
            string groupId,
            string renameAs,
            string siteCollectionId,
            string siteId)
            : base(requestUrl, client)
        {
            this.SetParameter("id", id, true);
            this.SetParameter("groupId", groupId, true);
            this.SetParameter("renameAs", renameAs, true);
            this.SetParameter("siteCollectionId", siteCollectionId, true);
            this.SetParameter("siteId", siteId, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IOnenoteSectionCopyToNotebookRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new OnenoteSectionCopyToNotebookRequest(functionUrl, this.Client, options);

            if (this.HasParameter("id"))
            {
                request.RequestBody.Id = this.GetParameter<string>("id");
            }

            if (this.HasParameter("groupId"))
            {
                request.RequestBody.GroupId = this.GetParameter<string>("groupId");
            }

            if (this.HasParameter("renameAs"))
            {
                request.RequestBody.RenameAs = this.GetParameter<string>("renameAs");
            }

            if (this.HasParameter("siteCollectionId"))
            {
                request.RequestBody.SiteCollectionId = this.GetParameter<string>("siteCollectionId");
            }

            if (this.HasParameter("siteId"))
            {
                request.RequestBody.SiteId = this.GetParameter<string>("siteId");
            }

            return request;
        }
    }
}
