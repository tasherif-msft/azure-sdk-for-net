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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of AzureWebCategory and their operations over its parent. </summary>
    public partial class AzureWebCategoryCollection : ArmCollection, IEnumerable<AzureWebCategory>, IAsyncEnumerable<AzureWebCategory>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebCategoriesRestOperations _webCategoriesRestClient;

        /// <summary> Initializes a new instance of the <see cref="AzureWebCategoryCollection"/> class for mocking. </summary>
        protected AzureWebCategoryCollection()
        {
        }

        /// <summary> Initializes a new instance of AzureWebCategoryCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal AzureWebCategoryCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _webCategoriesRestClient = new WebCategoriesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Subscription.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Subscription.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Gets the specified Azure Web Category. </summary>
        /// <param name="name"> The name of the azureWebCategory. </param>
        /// <param name="expand"> Expands resourceIds back referenced by the azureWebCategory resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<AzureWebCategory> Get(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("AzureWebCategoryCollection.Get");
            scope.Start();
            try
            {
                var response = _webCategoriesRestClient.Get(Id.SubscriptionId, name, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AzureWebCategory(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified Azure Web Category. </summary>
        /// <param name="name"> The name of the azureWebCategory. </param>
        /// <param name="expand"> Expands resourceIds back referenced by the azureWebCategory resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<AzureWebCategory>> GetAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("AzureWebCategoryCollection.Get");
            scope.Start();
            try
            {
                var response = await _webCategoriesRestClient.GetAsync(Id.SubscriptionId, name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AzureWebCategory(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> The name of the azureWebCategory. </param>
        /// <param name="expand"> Expands resourceIds back referenced by the azureWebCategory resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<AzureWebCategory> GetIfExists(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("AzureWebCategoryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webCategoriesRestClient.Get(Id.SubscriptionId, name, expand, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<AzureWebCategory>(null, response.GetRawResponse())
                    : Response.FromValue(new AzureWebCategory(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> The name of the azureWebCategory. </param>
        /// <param name="expand"> Expands resourceIds back referenced by the azureWebCategory resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<AzureWebCategory>> GetIfExistsAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("AzureWebCategoryCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _webCategoriesRestClient.GetAsync(Id.SubscriptionId, name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<AzureWebCategory>(null, response.GetRawResponse())
                    : Response.FromValue(new AzureWebCategory(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> The name of the azureWebCategory. </param>
        /// <param name="expand"> Expands resourceIds back referenced by the azureWebCategory resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("AzureWebCategoryCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(name, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> The name of the azureWebCategory. </param>
        /// <param name="expand"> Expands resourceIds back referenced by the azureWebCategory resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("AzureWebCategoryCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the Azure Web Categories in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AzureWebCategory" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AzureWebCategory> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AzureWebCategory> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AzureWebCategoryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webCategoriesRestClient.ListBySubscription(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AzureWebCategory(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AzureWebCategory> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AzureWebCategoryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webCategoriesRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AzureWebCategory(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the Azure Web Categories in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AzureWebCategory" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AzureWebCategory> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AzureWebCategory>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AzureWebCategoryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webCategoriesRestClient.ListBySubscriptionAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AzureWebCategory(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AzureWebCategory>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AzureWebCategoryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webCategoriesRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AzureWebCategory(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="AzureWebCategory" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AzureWebCategoryCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(AzureWebCategory.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="AzureWebCategory" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AzureWebCategoryCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(AzureWebCategory.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AzureWebCategory> IEnumerable<AzureWebCategory>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AzureWebCategory> IAsyncEnumerable<AzureWebCategory>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, AzureWebCategory, AzureWebCategoryData> Construct() { }
    }
}
