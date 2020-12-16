// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodCollectionPage.cs.tt

namespace Microsoft.Graph
{
    /// <summary>
    /// The type UserGetManagedAppPoliciesCollectionPage.
    /// </summary>
    public partial class UserGetManagedAppPoliciesCollectionPage : CollectionPage<ManagedAppPolicy>, IUserGetManagedAppPoliciesCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="IUserGetManagedAppPoliciesRequest"/> instance.
        /// </summary>
        public IUserGetManagedAppPoliciesRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new UserGetManagedAppPoliciesRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
