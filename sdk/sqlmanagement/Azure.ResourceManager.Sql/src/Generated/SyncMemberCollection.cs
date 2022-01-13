// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of SyncMember and their operations over its parent. </summary>
    public partial class SyncMemberCollection : ArmCollection, IEnumerable<SyncMember>, IAsyncEnumerable<SyncMember>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly SyncMembersRestOperations _syncMembersRestClient;

        /// <summary> Initializes a new instance of the <see cref="SyncMemberCollection"/> class for mocking. </summary>
        protected SyncMemberCollection()
        {
        }

        /// <summary> Initializes a new instance of SyncMemberCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SyncMemberCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _syncMembersRestClient = new SyncMembersRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SyncGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SyncGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers/{syncMemberName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}
        /// OperationId: SyncMembers_CreateOrUpdate
        /// <summary> Creates or updates a sync member. </summary>
        /// <param name="syncMemberName"> The name of the sync member. </param>
        /// <param name="parameters"> The requested sync member resource state. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="syncMemberName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual SyncMemberCreateOrUpdateOperation CreateOrUpdate(string syncMemberName, SyncMemberData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (syncMemberName == null)
            {
                throw new ArgumentNullException(nameof(syncMemberName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SyncMemberCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _syncMembersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, syncMemberName, parameters, cancellationToken);
                var operation = new SyncMemberCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _syncMembersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, syncMemberName, parameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers/{syncMemberName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}
        /// OperationId: SyncMembers_CreateOrUpdate
        /// <summary> Creates or updates a sync member. </summary>
        /// <param name="syncMemberName"> The name of the sync member. </param>
        /// <param name="parameters"> The requested sync member resource state. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="syncMemberName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<SyncMemberCreateOrUpdateOperation> CreateOrUpdateAsync(string syncMemberName, SyncMemberData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (syncMemberName == null)
            {
                throw new ArgumentNullException(nameof(syncMemberName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SyncMemberCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _syncMembersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, syncMemberName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SyncMemberCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _syncMembersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, syncMemberName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers/{syncMemberName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}
        /// OperationId: SyncMembers_Get
        /// <summary> Gets a sync member. </summary>
        /// <param name="syncMemberName"> The name of the sync member. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="syncMemberName"/> is null. </exception>
        public virtual Response<SyncMember> Get(string syncMemberName, CancellationToken cancellationToken = default)
        {
            if (syncMemberName == null)
            {
                throw new ArgumentNullException(nameof(syncMemberName));
            }

            using var scope = _clientDiagnostics.CreateScope("SyncMemberCollection.Get");
            scope.Start();
            try
            {
                var response = _syncMembersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, syncMemberName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SyncMember(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers/{syncMemberName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}
        /// OperationId: SyncMembers_Get
        /// <summary> Gets a sync member. </summary>
        /// <param name="syncMemberName"> The name of the sync member. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="syncMemberName"/> is null. </exception>
        public async virtual Task<Response<SyncMember>> GetAsync(string syncMemberName, CancellationToken cancellationToken = default)
        {
            if (syncMemberName == null)
            {
                throw new ArgumentNullException(nameof(syncMemberName));
            }

            using var scope = _clientDiagnostics.CreateScope("SyncMemberCollection.Get");
            scope.Start();
            try
            {
                var response = await _syncMembersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, syncMemberName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SyncMember(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="syncMemberName"> The name of the sync member. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="syncMemberName"/> is null. </exception>
        public virtual Response<SyncMember> GetIfExists(string syncMemberName, CancellationToken cancellationToken = default)
        {
            if (syncMemberName == null)
            {
                throw new ArgumentNullException(nameof(syncMemberName));
            }

            using var scope = _clientDiagnostics.CreateScope("SyncMemberCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _syncMembersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, syncMemberName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SyncMember>(null, response.GetRawResponse())
                    : Response.FromValue(new SyncMember(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="syncMemberName"> The name of the sync member. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="syncMemberName"/> is null. </exception>
        public async virtual Task<Response<SyncMember>> GetIfExistsAsync(string syncMemberName, CancellationToken cancellationToken = default)
        {
            if (syncMemberName == null)
            {
                throw new ArgumentNullException(nameof(syncMemberName));
            }

            using var scope = _clientDiagnostics.CreateScope("SyncMemberCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _syncMembersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, syncMemberName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SyncMember>(null, response.GetRawResponse())
                    : Response.FromValue(new SyncMember(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="syncMemberName"> The name of the sync member. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="syncMemberName"/> is null. </exception>
        public virtual Response<bool> Exists(string syncMemberName, CancellationToken cancellationToken = default)
        {
            if (syncMemberName == null)
            {
                throw new ArgumentNullException(nameof(syncMemberName));
            }

            using var scope = _clientDiagnostics.CreateScope("SyncMemberCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(syncMemberName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="syncMemberName"> The name of the sync member. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="syncMemberName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string syncMemberName, CancellationToken cancellationToken = default)
        {
            if (syncMemberName == null)
            {
                throw new ArgumentNullException(nameof(syncMemberName));
            }

            using var scope = _clientDiagnostics.CreateScope("SyncMemberCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(syncMemberName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}
        /// OperationId: SyncMembers_ListBySyncGroup
        /// <summary> Lists sync members in the given sync group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SyncMember" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SyncMember> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SyncMember> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SyncMemberCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _syncMembersRestClient.ListBySyncGroup(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SyncMember(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SyncMember> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SyncMemberCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _syncMembersRestClient.ListBySyncGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SyncMember(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}
        /// OperationId: SyncMembers_ListBySyncGroup
        /// <summary> Lists sync members in the given sync group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SyncMember" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SyncMember> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SyncMember>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SyncMemberCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _syncMembersRestClient.ListBySyncGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SyncMember(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SyncMember>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SyncMemberCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _syncMembersRestClient.ListBySyncGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SyncMember(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SyncMember> IEnumerable<SyncMember>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SyncMember> IAsyncEnumerable<SyncMember>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SyncMember, SyncMemberData> Construct() { }
    }
}
