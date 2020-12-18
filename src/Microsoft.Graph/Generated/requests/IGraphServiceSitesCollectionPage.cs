// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionPage.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The interface IGraphServiceSitesCollectionPage.
    /// </summary>
    [InterfaceConverter(typeof(InterfaceConverter<GraphServiceSitesCollectionPage>))]
    public interface IGraphServiceSitesCollectionPage : ICollectionPage<Site>
    {
        /// <summary>
        /// Gets the next page <see cref="IGraphServiceSitesCollectionRequest"/> instance.
        /// </summary>
        IGraphServiceSitesCollectionRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
