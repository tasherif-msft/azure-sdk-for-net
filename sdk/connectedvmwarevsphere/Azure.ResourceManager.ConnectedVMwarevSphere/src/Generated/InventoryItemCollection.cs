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
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary> A class representing collection of InventoryItem and their operations over its parent. </summary>
    public partial class InventoryItemCollection : ArmCollection, IEnumerable<InventoryItem>, IAsyncEnumerable<InventoryItem>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly InventoryItemsRestOperations _inventoryItemsRestClient;

        /// <summary> Initializes a new instance of the <see cref="InventoryItemCollection"/> class for mocking. </summary>
        protected InventoryItemCollection()
        {
        }

        /// <summary> Initializes a new instance of InventoryItemCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal InventoryItemCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _inventoryItemsRestClient = new InventoryItemsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VCenter.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VCenter.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters/{vcenterName}/inventoryItems/{inventoryItemName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters/{vcenterName}
        /// OperationId: InventoryItems_Create
        /// <summary> Create Or Update InventoryItem. </summary>
        /// <param name="inventoryItemName"> Name of the inventoryItem. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inventoryItemName"/> is null. </exception>
        public virtual InventoryItemCreateOperation CreateOrUpdate(string inventoryItemName, InventoryItemData body = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (inventoryItemName == null)
            {
                throw new ArgumentNullException(nameof(inventoryItemName));
            }

            using var scope = _clientDiagnostics.CreateScope("InventoryItemCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _inventoryItemsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inventoryItemName, body, cancellationToken);
                var operation = new InventoryItemCreateOperation(Parent, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters/{vcenterName}/inventoryItems/{inventoryItemName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters/{vcenterName}
        /// OperationId: InventoryItems_Create
        /// <summary> Create Or Update InventoryItem. </summary>
        /// <param name="inventoryItemName"> Name of the inventoryItem. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inventoryItemName"/> is null. </exception>
        public async virtual Task<InventoryItemCreateOperation> CreateOrUpdateAsync(string inventoryItemName, InventoryItemData body = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (inventoryItemName == null)
            {
                throw new ArgumentNullException(nameof(inventoryItemName));
            }

            using var scope = _clientDiagnostics.CreateScope("InventoryItemCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _inventoryItemsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inventoryItemName, body, cancellationToken).ConfigureAwait(false);
                var operation = new InventoryItemCreateOperation(Parent, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters/{vcenterName}/inventoryItems/{inventoryItemName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters/{vcenterName}
        /// OperationId: InventoryItems_Get
        /// <summary> Implements InventoryItem GET method. </summary>
        /// <param name="inventoryItemName"> Name of the inventoryItem. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inventoryItemName"/> is null. </exception>
        public virtual Response<InventoryItem> Get(string inventoryItemName, CancellationToken cancellationToken = default)
        {
            if (inventoryItemName == null)
            {
                throw new ArgumentNullException(nameof(inventoryItemName));
            }

            using var scope = _clientDiagnostics.CreateScope("InventoryItemCollection.Get");
            scope.Start();
            try
            {
                var response = _inventoryItemsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inventoryItemName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new InventoryItem(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters/{vcenterName}/inventoryItems/{inventoryItemName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters/{vcenterName}
        /// OperationId: InventoryItems_Get
        /// <summary> Implements InventoryItem GET method. </summary>
        /// <param name="inventoryItemName"> Name of the inventoryItem. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inventoryItemName"/> is null. </exception>
        public async virtual Task<Response<InventoryItem>> GetAsync(string inventoryItemName, CancellationToken cancellationToken = default)
        {
            if (inventoryItemName == null)
            {
                throw new ArgumentNullException(nameof(inventoryItemName));
            }

            using var scope = _clientDiagnostics.CreateScope("InventoryItemCollection.Get");
            scope.Start();
            try
            {
                var response = await _inventoryItemsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inventoryItemName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new InventoryItem(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="inventoryItemName"> Name of the inventoryItem. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inventoryItemName"/> is null. </exception>
        public virtual Response<InventoryItem> GetIfExists(string inventoryItemName, CancellationToken cancellationToken = default)
        {
            if (inventoryItemName == null)
            {
                throw new ArgumentNullException(nameof(inventoryItemName));
            }

            using var scope = _clientDiagnostics.CreateScope("InventoryItemCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _inventoryItemsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inventoryItemName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<InventoryItem>(null, response.GetRawResponse())
                    : Response.FromValue(new InventoryItem(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="inventoryItemName"> Name of the inventoryItem. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inventoryItemName"/> is null. </exception>
        public async virtual Task<Response<InventoryItem>> GetIfExistsAsync(string inventoryItemName, CancellationToken cancellationToken = default)
        {
            if (inventoryItemName == null)
            {
                throw new ArgumentNullException(nameof(inventoryItemName));
            }

            using var scope = _clientDiagnostics.CreateScope("InventoryItemCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _inventoryItemsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inventoryItemName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<InventoryItem>(null, response.GetRawResponse())
                    : Response.FromValue(new InventoryItem(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="inventoryItemName"> Name of the inventoryItem. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inventoryItemName"/> is null. </exception>
        public virtual Response<bool> Exists(string inventoryItemName, CancellationToken cancellationToken = default)
        {
            if (inventoryItemName == null)
            {
                throw new ArgumentNullException(nameof(inventoryItemName));
            }

            using var scope = _clientDiagnostics.CreateScope("InventoryItemCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(inventoryItemName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="inventoryItemName"> Name of the inventoryItem. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inventoryItemName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string inventoryItemName, CancellationToken cancellationToken = default)
        {
            if (inventoryItemName == null)
            {
                throw new ArgumentNullException(nameof(inventoryItemName));
            }

            using var scope = _clientDiagnostics.CreateScope("InventoryItemCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(inventoryItemName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters/{vcenterName}/inventoryItems
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters/{vcenterName}
        /// OperationId: InventoryItems_ListByVCenter
        /// <summary> Returns the list of inventoryItems of the given vCenter. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="InventoryItem" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<InventoryItem> GetAll(CancellationToken cancellationToken = default)
        {
            Page<InventoryItem> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InventoryItemCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _inventoryItemsRestClient.ListByVCenter(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new InventoryItem(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<InventoryItem> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InventoryItemCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _inventoryItemsRestClient.ListByVCenterNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new InventoryItem(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters/{vcenterName}/inventoryItems
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters/{vcenterName}
        /// OperationId: InventoryItems_ListByVCenter
        /// <summary> Returns the list of inventoryItems of the given vCenter. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="InventoryItem" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<InventoryItem> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<InventoryItem>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InventoryItemCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _inventoryItemsRestClient.ListByVCenterAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new InventoryItem(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<InventoryItem>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InventoryItemCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _inventoryItemsRestClient.ListByVCenterNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new InventoryItem(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<InventoryItem> IEnumerable<InventoryItem>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<InventoryItem> IAsyncEnumerable<InventoryItem>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, InventoryItem, InventoryItemData> Construct() { }
    }
}
