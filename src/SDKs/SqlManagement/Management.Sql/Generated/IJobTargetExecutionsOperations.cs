// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// JobTargetExecutionsOperations operations.
    /// </summary>
    public partial interface IJobTargetExecutionsOperations
    {
        /// <summary>
        /// Lists target executions for all steps of a job execution.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='jobAgentName'>
        /// The name of the job agent.
        /// </param>
        /// <param name='jobName'>
        /// The name of the job to get.
        /// </param>
        /// <param name='jobExecutionId'>
        /// The id of the job execution
        /// </param>
        /// <param name='createTimeMin'>
        /// If specified, only job executions created at or after the specified
        /// time are included.
        /// </param>
        /// <param name='createTimeMax'>
        /// If specified, only job executions created before the specified time
        /// are included.
        /// </param>
        /// <param name='endTimeMin'>
        /// If specified, only job executions completed at or after the
        /// specified time are included.
        /// </param>
        /// <param name='endTimeMax'>
        /// If specified, only job executions completed before the specified
        /// time are included.
        /// </param>
        /// <param name='isActive'>
        /// If specified, only active or only completed job executions are
        /// included.
        /// </param>
        /// <param name='skip'>
        /// The number of elements in the collection to skip.
        /// </param>
        /// <param name='top'>
        /// The number of elements to return from the collection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<JobExecution>>> ListByJobExecutionWithHttpMessagesAsync(string resourceGroupName, string serverName, string jobAgentName, string jobName, System.Guid jobExecutionId, System.DateTime? createTimeMin = default(System.DateTime?), System.DateTime? createTimeMax = default(System.DateTime?), System.DateTime? endTimeMin = default(System.DateTime?), System.DateTime? endTimeMax = default(System.DateTime?), bool? isActive = default(bool?), int? skip = default(int?), int? top = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the target executions of a job step execution.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='jobAgentName'>
        /// The name of the job agent.
        /// </param>
        /// <param name='jobName'>
        /// The name of the job to get.
        /// </param>
        /// <param name='jobExecutionId'>
        /// The id of the job execution
        /// </param>
        /// <param name='stepName'>
        /// The name of the step.
        /// </param>
        /// <param name='createTimeMin'>
        /// If specified, only job executions created at or after the specified
        /// time are included.
        /// </param>
        /// <param name='createTimeMax'>
        /// If specified, only job executions created before the specified time
        /// are included.
        /// </param>
        /// <param name='endTimeMin'>
        /// If specified, only job executions completed at or after the
        /// specified time are included.
        /// </param>
        /// <param name='endTimeMax'>
        /// If specified, only job executions completed before the specified
        /// time are included.
        /// </param>
        /// <param name='isActive'>
        /// If specified, only active or only completed job executions are
        /// included.
        /// </param>
        /// <param name='skip'>
        /// The number of elements in the collection to skip.
        /// </param>
        /// <param name='top'>
        /// The number of elements to return from the collection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<JobExecution>>> ListByStepWithHttpMessagesAsync(string resourceGroupName, string serverName, string jobAgentName, string jobName, System.Guid jobExecutionId, string stepName, System.DateTime? createTimeMin = default(System.DateTime?), System.DateTime? createTimeMax = default(System.DateTime?), System.DateTime? endTimeMin = default(System.DateTime?), System.DateTime? endTimeMax = default(System.DateTime?), bool? isActive = default(bool?), int? skip = default(int?), int? top = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a target execution.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serverName'>
        /// The name of the server.
        /// </param>
        /// <param name='jobAgentName'>
        /// The name of the job agent.
        /// </param>
        /// <param name='jobName'>
        /// The name of the job to get.
        /// </param>
        /// <param name='jobExecutionId'>
        /// The unique id of the job execution
        /// </param>
        /// <param name='stepName'>
        /// The name of the step.
        /// </param>
        /// <param name='targetId'>
        /// The target id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<JobExecution>> GetWithHttpMessagesAsync(string resourceGroupName, string serverName, string jobAgentName, string jobName, System.Guid jobExecutionId, string stepName, System.Guid targetId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists target executions for all steps of a job execution.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<JobExecution>>> ListByJobExecutionNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the target executions of a job step execution.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<JobExecution>>> ListByStepNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}