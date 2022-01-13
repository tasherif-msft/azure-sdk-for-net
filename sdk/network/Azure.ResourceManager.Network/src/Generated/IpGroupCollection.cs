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
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of IpGroup and their operations over its parent. </summary>
    public partial class IpGroupCollection : ArmCollection, IEnumerable<IpGroup>, IAsyncEnumerable<IpGroup>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly IpGroupsRestOperations _ipGroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="IpGroupCollection"/> class for mocking. </summary>
        protected IpGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of IpGroupCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal IpGroupCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _ipGroupsRestClient = new IpGroupsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates or updates an ipGroups in a specified resource group. </summary>
        /// <param name="ipGroupsName"> The name of the ipGroups. </param>
        /// <param name="parameters"> Parameters supplied to the create or update IpGroups operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ipGroupsName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual IpGroupCreateOrUpdateOperation CreateOrUpdate(string ipGroupsName, IpGroupData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (ipGroupsName == null)
            {
                throw new ArgumentNullException(nameof(ipGroupsName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("IpGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _ipGroupsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, parameters, cancellationToken);
                var operation = new IpGroupCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _ipGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, parameters).Request, response);
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

        /// <summary> Creates or updates an ipGroups in a specified resource group. </summary>
        /// <param name="ipGroupsName"> The name of the ipGroups. </param>
        /// <param name="parameters"> Parameters supplied to the create or update IpGroups operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ipGroupsName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<IpGroupCreateOrUpdateOperation> CreateOrUpdateAsync(string ipGroupsName, IpGroupData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (ipGroupsName == null)
            {
                throw new ArgumentNullException(nameof(ipGroupsName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("IpGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _ipGroupsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new IpGroupCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _ipGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, parameters).Request, response);
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

        /// <summary> Gets the specified ipGroups. </summary>
        /// <param name="ipGroupsName"> The name of the ipGroups. </param>
        /// <param name="expand"> Expands resourceIds (of Firewalls/Network Security Groups etc.) back referenced by the IpGroups resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ipGroupsName"/> is null. </exception>
        public virtual Response<IpGroup> Get(string ipGroupsName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (ipGroupsName == null)
            {
                throw new ArgumentNullException(nameof(ipGroupsName));
            }

            using var scope = _clientDiagnostics.CreateScope("IpGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _ipGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IpGroup(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified ipGroups. </summary>
        /// <param name="ipGroupsName"> The name of the ipGroups. </param>
        /// <param name="expand"> Expands resourceIds (of Firewalls/Network Security Groups etc.) back referenced by the IpGroups resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ipGroupsName"/> is null. </exception>
        public async virtual Task<Response<IpGroup>> GetAsync(string ipGroupsName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (ipGroupsName == null)
            {
                throw new ArgumentNullException(nameof(ipGroupsName));
            }

            using var scope = _clientDiagnostics.CreateScope("IpGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _ipGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new IpGroup(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ipGroupsName"> The name of the ipGroups. </param>
        /// <param name="expand"> Expands resourceIds (of Firewalls/Network Security Groups etc.) back referenced by the IpGroups resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ipGroupsName"/> is null. </exception>
        public virtual Response<IpGroup> GetIfExists(string ipGroupsName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (ipGroupsName == null)
            {
                throw new ArgumentNullException(nameof(ipGroupsName));
            }

            using var scope = _clientDiagnostics.CreateScope("IpGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _ipGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, expand, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<IpGroup>(null, response.GetRawResponse())
                    : Response.FromValue(new IpGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ipGroupsName"> The name of the ipGroups. </param>
        /// <param name="expand"> Expands resourceIds (of Firewalls/Network Security Groups etc.) back referenced by the IpGroups resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ipGroupsName"/> is null. </exception>
        public async virtual Task<Response<IpGroup>> GetIfExistsAsync(string ipGroupsName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (ipGroupsName == null)
            {
                throw new ArgumentNullException(nameof(ipGroupsName));
            }

            using var scope = _clientDiagnostics.CreateScope("IpGroupCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _ipGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<IpGroup>(null, response.GetRawResponse())
                    : Response.FromValue(new IpGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ipGroupsName"> The name of the ipGroups. </param>
        /// <param name="expand"> Expands resourceIds (of Firewalls/Network Security Groups etc.) back referenced by the IpGroups resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ipGroupsName"/> is null. </exception>
        public virtual Response<bool> Exists(string ipGroupsName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (ipGroupsName == null)
            {
                throw new ArgumentNullException(nameof(ipGroupsName));
            }

            using var scope = _clientDiagnostics.CreateScope("IpGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(ipGroupsName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ipGroupsName"> The name of the ipGroups. </param>
        /// <param name="expand"> Expands resourceIds (of Firewalls/Network Security Groups etc.) back referenced by the IpGroups resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ipGroupsName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string ipGroupsName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (ipGroupsName == null)
            {
                throw new ArgumentNullException(nameof(ipGroupsName));
            }

            using var scope = _clientDiagnostics.CreateScope("IpGroupCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(ipGroupsName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all IpGroups in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IpGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IpGroup> GetAll(CancellationToken cancellationToken = default)
        {
            Page<IpGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("IpGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _ipGroupsRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new IpGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<IpGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("IpGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _ipGroupsRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new IpGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all IpGroups in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IpGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IpGroup> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<IpGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("IpGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _ipGroupsRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new IpGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<IpGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("IpGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _ipGroupsRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new IpGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="IpGroup" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("IpGroupCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(IpGroup.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="IpGroup" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("IpGroupCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(IpGroup.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<IpGroup> IEnumerable<IpGroup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<IpGroup> IAsyncEnumerable<IpGroup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, IpGroup, IpGroupData> Construct() { }
    }
}
