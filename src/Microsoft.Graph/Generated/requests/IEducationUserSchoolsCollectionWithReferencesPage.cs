// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionWithReferencesPage.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The interface IEducationUserSchoolsCollectionWithReferencesPage.
    /// </summary>
    [InterfaceConverter(typeof(InterfaceConverter<EducationUserSchoolsCollectionWithReferencesPage>))]
    public interface IEducationUserSchoolsCollectionWithReferencesPage : ICollectionPage<EducationSchool>
    {
        /// <summary>
        /// Gets the next page <see cref="IEducationUserSchoolsCollectionWithReferencesRequest"/> instance.
        /// </summary>
        IEducationUserSchoolsCollectionWithReferencesRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
