// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing collection of DeploymentOperation and their operations over a DeploymentExtended. </summary>
    public partial class DeploymentOperationContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="DeploymentOperationContainer"/> class for mocking. </summary>
        protected DeploymentOperationContainer()
        {
        }

        /// <summary> Initializes a new instance of DeploymentOperationContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DeploymentOperationContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private DeploymentRestOperations _restClient => new DeploymentRestOperations(_clientDiagnostics, Pipeline, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => DeploymentExtendedOperations.ResourceType;

        // Container level operations.

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="operationId"> The ID of the operation to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<DeploymentOperation> Get(string operationId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentOperationContainer.Get");
            scope.Start();
            try
            {
                if (operationId == null)
                {
                    throw new ArgumentNullException(nameof(operationId));
                }

                var response = _restClient.GetAtScope(Id.Parent, Id.Name, operationId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeploymentOperation(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="operationId"> The ID of the operation to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<DeploymentOperation>> GetAsync(string operationId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentOperationContainer.Get");
            scope.Start();
            try
            {
                if (operationId == null)
                {
                    throw new ArgumentNullException(nameof(operationId));
                }

                var response = await _restClient.GetAtScopeAsync(Id.Parent, Id.Name, operationId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DeploymentOperation(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="operationId"> The ID of the operation to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<DeploymentOperation> GetIfExists(string operationId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentOperationContainer.GetIfExists");
            scope.Start();
            try
            {
                if (operationId == null)
                {
                    throw new ArgumentNullException(nameof(operationId));
                }

                var response = _restClient.GetAtScope(Id.Parent, Id.Name, operationId, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<DeploymentOperation>(null, response.GetRawResponse())
                    : Response.FromValue(new DeploymentOperation(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="operationId"> The ID of the operation to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<DeploymentOperation>> GetIfExistsAsync(string operationId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentOperationContainer.GetIfExists");
            scope.Start();
            try
            {
                if (operationId == null)
                {
                    throw new ArgumentNullException(nameof(operationId));
                }

                var response = await _restClient.GetAtScopeAsync(Id.Parent, Id.Name, operationId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<DeploymentOperation>(null, response.GetRawResponse())
                    : Response.FromValue(new DeploymentOperation(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="operationId"> The ID of the operation to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string operationId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentOperationContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (operationId == null)
                {
                    throw new ArgumentNullException(nameof(operationId));
                }

                var response = GetIfExists(operationId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="operationId"> The ID of the operation to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string operationId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentOperationContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (operationId == null)
                {
                    throw new ArgumentNullException(nameof(operationId));
                }

                var response = await GetIfExistsAsync(operationId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all deployments operations for a deployment. </summary>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeploymentOperation" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<DeploymentOperation> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            Page<DeploymentOperation> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentOperationContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAtScope(Id.Parent, Id.Name, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeploymentOperation(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DeploymentOperation> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentOperationContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAtScopeNextPage(nextLink, Id.Parent, Id.Name, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeploymentOperation(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all deployments operations for a deployment. </summary>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeploymentOperation" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<DeploymentOperation> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<DeploymentOperation>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentOperationContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAtScopeAsync(Id.Parent, Id.Name, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeploymentOperation(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DeploymentOperation>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentOperationContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAtScopeNextPageAsync(nextLink, Id.Parent, Id.Name, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeploymentOperation(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="DeploymentOperation" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentOperationContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DeploymentOperationOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="DeploymentOperation" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentOperationContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DeploymentOperationOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, DeploymentOperation, DeploymentOperationData> Construct() { }
    }
}
