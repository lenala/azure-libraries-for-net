// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ServerCommunicationLinksOperations.
    /// </summary>
    public static partial class ServerCommunicationLinksOperationsExtensions
    {
            /// <summary>
            /// Deletes a server communication link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='communicationLinkName'>
            /// The name of the server communication link.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IServerCommunicationLinksOperations operations, string resourceGroupName, string serverName, string communicationLinkName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serverName, communicationLinkName, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns a server communication link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='communicationLinkName'>
            /// The name of the server communication link.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServerCommunicationLinkInner> GetAsync(this IServerCommunicationLinksOperations operations, string resourceGroupName, string serverName, string communicationLinkName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, communicationLinkName, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a server communication link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='communicationLinkName'>
            /// The name of the server communication link.
            /// </param>
            /// <param name='partnerServer'>
            /// The name of the partner server.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServerCommunicationLinkInner> CreateOrUpdateAsync(this IServerCommunicationLinksOperations operations, string resourceGroupName, string serverName, string communicationLinkName, string partnerServer, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, communicationLinkName, partnerServer, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of server communication links.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<ServerCommunicationLinkInner>> ListByServerAsync(this IServerCommunicationLinksOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerWithHttpMessagesAsync(resourceGroupName, serverName, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a server communication link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='communicationLinkName'>
            /// The name of the server communication link.
            /// </param>
            /// <param name='partnerServer'>
            /// The name of the partner server.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServerCommunicationLinkInner> BeginCreateOrUpdateAsync(this IServerCommunicationLinksOperations operations, string resourceGroupName, string serverName, string communicationLinkName, string partnerServer, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, communicationLinkName, partnerServer, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
