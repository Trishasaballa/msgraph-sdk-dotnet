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
    /// The type ScheduleShareRequestBuilder.
    /// </summary>
    public partial class ScheduleShareRequestBuilder : BaseActionMethodRequestBuilder<IScheduleShareRequest>, IScheduleShareRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="ScheduleShareRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="notifyTeam">A notifyTeam parameter for the OData method call.</param>
        /// <param name="startDateTime">A startDateTime parameter for the OData method call.</param>
        /// <param name="endDateTime">A endDateTime parameter for the OData method call.</param>
        public ScheduleShareRequestBuilder(
            string requestUrl,
            IBaseClient client,
            bool? notifyTeam,
            DateTimeOffset? startDateTime,
            DateTimeOffset? endDateTime)
            : base(requestUrl, client)
        {
            this.SetParameter("notifyTeam", notifyTeam, true);
            this.SetParameter("startDateTime", startDateTime, true);
            this.SetParameter("endDateTime", endDateTime, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IScheduleShareRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new ScheduleShareRequest(functionUrl, this.Client, options);

            if (this.HasParameter("notifyTeam"))
            {
                request.RequestBody.NotifyTeam = this.GetParameter<bool?>("notifyTeam");
            }

            if (this.HasParameter("startDateTime"))
            {
                request.RequestBody.StartDateTime = this.GetParameter<DateTimeOffset?>("startDateTime");
            }

            if (this.HasParameter("endDateTime"))
            {
                request.RequestBody.EndDateTime = this.GetParameter<DateTimeOffset?>("endDateTime");
            }

            return request;
        }
    }
}
