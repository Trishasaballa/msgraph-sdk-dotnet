// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DeviceManagementManagedDevicesCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementManagedDevicesCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementManagedDevicesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementManagedDevicesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementManagedDevicesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementManagedDevicesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementManagedDevicesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementManagedDevicesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IManagedDeviceRequestBuilder"/> for the specified DeviceManagementManagedDevice.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementManagedDevice.</param>
        /// <returns>The <see cref="IManagedDeviceRequestBuilder"/>.</returns>
        public IManagedDeviceRequestBuilder this[string id]
        {
            get
            {
                return new ManagedDeviceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
