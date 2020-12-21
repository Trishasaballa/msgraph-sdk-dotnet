// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type EducationUserClassesCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class EducationUserClassesCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IEducationUserClassesCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new EducationUserClassesCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public EducationUserClassesCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IEducationUserClassesCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IEducationUserClassesCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new EducationUserClassesCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IEducationClassWithReferenceRequestBuilder"/> for the specified EducationUserEducationClass.
        /// </summary>
        /// <param name="id">The ID for the EducationUserEducationClass.</param>
        /// <returns>The <see cref="IEducationClassWithReferenceRequestBuilder"/>.</returns>
        public IEducationClassWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new EducationClassWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IEducationUserClassesCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IEducationUserClassesCollectionReferencesRequestBuilder"/>.</returns>
        public IEducationUserClassesCollectionReferencesRequestBuilder References
        {
            get
            {
                return new EducationUserClassesCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
