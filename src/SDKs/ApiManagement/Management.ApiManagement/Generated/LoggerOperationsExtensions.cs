// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for LoggerOperations.
    /// </summary>
    public static partial class LoggerOperationsExtensions
    {
            /// <summary>
            /// Lists a collection of loggers in the specified service instance.
            /// <see href="https://docs.microsoft.com/en-us/azure/api-management/api-management-howto-log-event-hubs" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<LoggerContract> ListByService(this ILoggerOperations operations, string resourceGroupName, string serviceName, ODataQuery<LoggerContract> odataQuery = default(ODataQuery<LoggerContract>))
            {
                return ((ILoggerOperations)operations).ListByServiceAsync(resourceGroupName, serviceName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists a collection of loggers in the specified service instance.
            /// <see href="https://docs.microsoft.com/en-us/azure/api-management/api-management-howto-log-event-hubs" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<LoggerContract>> ListByServiceAsync(this ILoggerOperations operations, string resourceGroupName, string serviceName, ODataQuery<LoggerContract> odataQuery = default(ODataQuery<LoggerContract>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceWithHttpMessagesAsync(resourceGroupName, serviceName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the details of the logger specified by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='loggerid'>
            /// Logger identifier. Must be unique in the API Management service instance.
            /// </param>
            public static LoggerContract Get(this ILoggerOperations operations, string resourceGroupName, string serviceName, string loggerid)
            {
                return operations.GetAsync(resourceGroupName, serviceName, loggerid).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the details of the logger specified by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='loggerid'>
            /// Logger identifier. Must be unique in the API Management service instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LoggerContract> GetAsync(this ILoggerOperations operations, string resourceGroupName, string serviceName, string loggerid, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceName, loggerid, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or Updates a logger.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='loggerid'>
            /// Logger identifier. Must be unique in the API Management service instance.
            /// </param>
            /// <param name='parameters'>
            /// Create parameters.
            /// </param>
            public static LoggerContract CreateOrUpdate(this ILoggerOperations operations, string resourceGroupName, string serviceName, string loggerid, LoggerContract parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serviceName, loggerid, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or Updates a logger.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='loggerid'>
            /// Logger identifier. Must be unique in the API Management service instance.
            /// </param>
            /// <param name='parameters'>
            /// Create parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LoggerContract> CreateOrUpdateAsync(this ILoggerOperations operations, string resourceGroupName, string serviceName, string loggerid, LoggerContract parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, loggerid, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an existing logger.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='loggerid'>
            /// Logger identifier. Must be unique in the API Management service instance.
            /// </param>
            /// <param name='parameters'>
            /// Update parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// The entity state (Etag) version of the logger to update. A value of "*" can
            /// be used for If-Match to unconditionally apply the operation.
            /// </param>
            public static void Update(this ILoggerOperations operations, string resourceGroupName, string serviceName, string loggerid, LoggerUpdateContract parameters, string ifMatch)
            {
                operations.UpdateAsync(resourceGroupName, serviceName, loggerid, parameters, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing logger.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='loggerid'>
            /// Logger identifier. Must be unique in the API Management service instance.
            /// </param>
            /// <param name='parameters'>
            /// Update parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// The entity state (Etag) version of the logger to update. A value of "*" can
            /// be used for If-Match to unconditionally apply the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this ILoggerOperations operations, string resourceGroupName, string serviceName, string loggerid, LoggerUpdateContract parameters, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serviceName, loggerid, parameters, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Deletes the specified logger.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='loggerid'>
            /// Logger identifier. Must be unique in the API Management service instance.
            /// </param>
            /// <param name='ifMatch'>
            /// The entity state (Etag) version of the logger to delete. A value of "*" can
            /// be used for If-Match to unconditionally apply the operation.
            /// </param>
            public static void Delete(this ILoggerOperations operations, string resourceGroupName, string serviceName, string loggerid, string ifMatch)
            {
                operations.DeleteAsync(resourceGroupName, serviceName, loggerid, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified logger.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='loggerid'>
            /// Logger identifier. Must be unique in the API Management service instance.
            /// </param>
            /// <param name='ifMatch'>
            /// The entity state (Etag) version of the logger to delete. A value of "*" can
            /// be used for If-Match to unconditionally apply the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ILoggerOperations operations, string resourceGroupName, string serviceName, string loggerid, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceName, loggerid, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists a collection of loggers in the specified service instance.
            /// <see href="https://docs.microsoft.com/en-us/azure/api-management/api-management-howto-log-event-hubs" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<LoggerContract> ListByServiceNext(this ILoggerOperations operations, string nextPageLink)
            {
                return operations.ListByServiceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists a collection of loggers in the specified service instance.
            /// <see href="https://docs.microsoft.com/en-us/azure/api-management/api-management-howto-log-event-hubs" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<LoggerContract>> ListByServiceNextAsync(this ILoggerOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}