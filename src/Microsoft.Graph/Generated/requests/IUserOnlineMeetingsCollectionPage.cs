// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionPage.cs.tt

namespace Microsoft.Graph
{
    using System;

    using Newtonsoft.Json;

    /// <summary>
    /// The interface IUserOnlineMeetingsCollectionPage.
    /// </summary>
    [JsonConverter(typeof(InterfaceConverter<UserOnlineMeetingsCollectionPage>))]
    public interface IUserOnlineMeetingsCollectionPage : ICollectionPage<OnlineMeeting>
    {
        /// <summary>
        /// Gets the next page <see cref="IUserOnlineMeetingsCollectionRequest"/> instance.
        /// </summary>
        IUserOnlineMeetingsCollectionRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
