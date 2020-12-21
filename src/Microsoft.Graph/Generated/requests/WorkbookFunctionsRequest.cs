// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type WorkbookFunctionsRequest.
    /// </summary>
    public partial class WorkbookFunctionsRequest : BaseRequest, IWorkbookFunctionsRequest
    {
        /// <summary>
        /// Constructs a new WorkbookFunctionsRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WorkbookFunctionsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WorkbookFunctions using POST.
        /// </summary>
        /// <param name="workbookFunctionsToCreate">The WorkbookFunctions to create.</param>
        /// <returns>The created WorkbookFunctions.</returns>
        public System.Threading.Tasks.Task<WorkbookFunctions> CreateAsync(WorkbookFunctions workbookFunctionsToCreate)
        {
            return this.CreateAsync(workbookFunctionsToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WorkbookFunctions using POST.
        /// </summary>
        /// <param name="workbookFunctionsToCreate">The WorkbookFunctions to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookFunctions.</returns>
        public async System.Threading.Tasks.Task<WorkbookFunctions> CreateAsync(WorkbookFunctions workbookFunctionsToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WorkbookFunctions>(workbookFunctionsToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified WorkbookFunctions.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookFunctions.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<WorkbookFunctions>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WorkbookFunctions.
        /// </summary>
        /// <returns>The WorkbookFunctions.</returns>
        public System.Threading.Tasks.Task<WorkbookFunctions> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WorkbookFunctions.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookFunctions.</returns>
        public async System.Threading.Tasks.Task<WorkbookFunctions> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WorkbookFunctions>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified WorkbookFunctions using PATCH.
        /// </summary>
        /// <param name="workbookFunctionsToUpdate">The WorkbookFunctions to update.</param>
        /// <returns>The updated WorkbookFunctions.</returns>
        public System.Threading.Tasks.Task<WorkbookFunctions> UpdateAsync(WorkbookFunctions workbookFunctionsToUpdate)
        {
            return this.UpdateAsync(workbookFunctionsToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WorkbookFunctions using PATCH.
        /// </summary>
        /// <param name="workbookFunctionsToUpdate">The WorkbookFunctions to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookFunctions.</returns>
        public async System.Threading.Tasks.Task<WorkbookFunctions> UpdateAsync(WorkbookFunctions workbookFunctionsToUpdate, CancellationToken cancellationToken)
        {
			if (workbookFunctionsToUpdate.AdditionalData != null)
			{
				if (workbookFunctionsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					workbookFunctionsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookFunctionsToUpdate.GetType().Name)
						});
				}
			}
            if (workbookFunctionsToUpdate.AdditionalData != null)
            {
                if (workbookFunctionsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    workbookFunctionsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookFunctionsToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WorkbookFunctions>(workbookFunctionsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookFunctionsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookFunctionsRequest Expand(Expression<Func<WorkbookFunctions, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookFunctionsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookFunctionsRequest Select(Expression<Func<WorkbookFunctions, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="workbookFunctionsToInitialize">The <see cref="WorkbookFunctions"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WorkbookFunctions workbookFunctionsToInitialize)
        {

        }
    }
}
