// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type ChangeNotification.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ChangeNotification>))]
    public partial class ChangeNotification
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeNotification"/> class.
        /// </summary>
        public ChangeNotification()
        {
            this.ODataType = "microsoft.graph.changeNotification";
        }

        /// <summary>
        /// Gets or sets changeType.
        /// Indicates the type of change that will raise the change notification. The supported values are: created, updated, deleted. Required.
        /// </summary>
        [JsonPropertyName("changeType")]
        public ChangeType? ChangeType { get; set; }
    
        /// <summary>
        /// Gets or sets clientState.
        /// Value of the clientState property sent in the subscription request (if any). The maximum length is 255 characters. The client can check whether the change notification came from the service by comparing the values of the clientState property. The value of the clientState property sent with the subscription is compared with the value of the clientState property received with each change notification. Optional.
        /// </summary>
        [JsonPropertyName("clientState")]
        public string ClientState { get; set; }
    
        /// <summary>
        /// Gets or sets encryptedContent.
        /// (Preview) Encrypted content attached with the change notification. Only provided if encryptionCertificate and includeResourceData were defined during the subscription request and if the resource supports it. Optional.
        /// </summary>
        [JsonPropertyName("encryptedContent")]
        public ChangeNotificationEncryptedContent EncryptedContent { get; set; }
    
        /// <summary>
        /// Gets or sets id.
        /// Unique ID for the notification. Optional.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or sets lifecycleEvent.
        /// The type of lifecycle notification if the current notification is a lifecycle notification. Optional. Supported values are missed, removed, reauthorizationRequired.
        /// </summary>
        [JsonPropertyName("lifecycleEvent")]
        public LifecycleEventType? LifecycleEvent { get; set; }
    
        /// <summary>
        /// Gets or sets resource.
        /// The URI of the resource that emitted the change notification relative to https://graph.microsoft.com. Required.
        /// </summary>
        [JsonPropertyName("resource")]
        public string Resource { get; set; }
    
        /// <summary>
        /// Gets or sets resourceData.
        /// The content of this property depends on the type of resource being subscribed to. Required.
        /// </summary>
        [JsonPropertyName("resourceData")]
        public ResourceData ResourceData { get; set; }
    
        /// <summary>
        /// Gets or sets subscriptionExpirationDateTime.
        /// The expiration time for the subscription. Required.
        /// </summary>
        [JsonPropertyName("subscriptionExpirationDateTime")]
        public DateTimeOffset? SubscriptionExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets subscriptionId.
        /// The unique identifier of the subscription that generated the notification.
        /// </summary>
        [JsonPropertyName("subscriptionId")]
        public Guid? SubscriptionId { get; set; }
    
        /// <summary>
        /// Gets or sets tenantId.
        /// The unique identifier of the tenant from which the change notification originated.
        /// </summary>
        [JsonPropertyName("tenantId")]
        public Guid? TenantId { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
