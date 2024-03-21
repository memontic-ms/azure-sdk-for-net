// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.DataLakeStore.Models;

namespace Azure.ResourceManager.DataLakeStore
{
    internal partial class TrustedIdProvidersRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of TrustedIdProvidersRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public TrustedIdProvidersRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2016-11-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListByAccountRequest(string subscriptionId, string resourceGroupName, string accountName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DataLakeStore/accounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/trustedIdProviders", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the Data Lake Store trusted identity providers within the specified Data Lake Store account. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the Azure resource group. </param>
        /// <param name="accountName"> The name of the Data Lake Store account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DataLakeStoreTrustedIdProviderListResult>> ListByAccountAsync(string subscriptionId, string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var message = CreateListByAccountRequest(subscriptionId, resourceGroupName, accountName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataLakeStoreTrustedIdProviderListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataLakeStoreTrustedIdProviderListResult.DeserializeDataLakeStoreTrustedIdProviderListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the Data Lake Store trusted identity providers within the specified Data Lake Store account. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the Azure resource group. </param>
        /// <param name="accountName"> The name of the Data Lake Store account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DataLakeStoreTrustedIdProviderListResult> ListByAccount(string subscriptionId, string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var message = CreateListByAccountRequest(subscriptionId, resourceGroupName, accountName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataLakeStoreTrustedIdProviderListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataLakeStoreTrustedIdProviderListResult.DeserializeDataLakeStoreTrustedIdProviderListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string accountName, string trustedIdProviderName, DataLakeStoreTrustedIdProviderCreateOrUpdateContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DataLakeStore/accounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/trustedIdProviders/", false);
            uri.AppendPath(trustedIdProviderName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates or updates the specified trusted identity provider. During update, the trusted identity provider with the specified name will be replaced with this new provider. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the Azure resource group. </param>
        /// <param name="accountName"> The name of the Data Lake Store account. </param>
        /// <param name="trustedIdProviderName"> The name of the trusted identity provider. This is used for differentiation of providers in the account. </param>
        /// <param name="content"> Parameters supplied to create or replace the trusted identity provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="trustedIdProviderName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="trustedIdProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DataLakeStoreTrustedIdProviderData>> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string accountName, string trustedIdProviderName, DataLakeStoreTrustedIdProviderCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(trustedIdProviderName, nameof(trustedIdProviderName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, accountName, trustedIdProviderName, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataLakeStoreTrustedIdProviderData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataLakeStoreTrustedIdProviderData.DeserializeDataLakeStoreTrustedIdProviderData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates or updates the specified trusted identity provider. During update, the trusted identity provider with the specified name will be replaced with this new provider. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the Azure resource group. </param>
        /// <param name="accountName"> The name of the Data Lake Store account. </param>
        /// <param name="trustedIdProviderName"> The name of the trusted identity provider. This is used for differentiation of providers in the account. </param>
        /// <param name="content"> Parameters supplied to create or replace the trusted identity provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="trustedIdProviderName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="trustedIdProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DataLakeStoreTrustedIdProviderData> CreateOrUpdate(string subscriptionId, string resourceGroupName, string accountName, string trustedIdProviderName, DataLakeStoreTrustedIdProviderCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(trustedIdProviderName, nameof(trustedIdProviderName));
            Argument.AssertNotNull(content, nameof(content));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, accountName, trustedIdProviderName, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataLakeStoreTrustedIdProviderData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataLakeStoreTrustedIdProviderData.DeserializeDataLakeStoreTrustedIdProviderData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string accountName, string trustedIdProviderName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DataLakeStore/accounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/trustedIdProviders/", false);
            uri.AppendPath(trustedIdProviderName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the specified Data Lake Store trusted identity provider. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the Azure resource group. </param>
        /// <param name="accountName"> The name of the Data Lake Store account. </param>
        /// <param name="trustedIdProviderName"> The name of the trusted identity provider to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="trustedIdProviderName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="trustedIdProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DataLakeStoreTrustedIdProviderData>> GetAsync(string subscriptionId, string resourceGroupName, string accountName, string trustedIdProviderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(trustedIdProviderName, nameof(trustedIdProviderName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, accountName, trustedIdProviderName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataLakeStoreTrustedIdProviderData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataLakeStoreTrustedIdProviderData.DeserializeDataLakeStoreTrustedIdProviderData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DataLakeStoreTrustedIdProviderData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the specified Data Lake Store trusted identity provider. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the Azure resource group. </param>
        /// <param name="accountName"> The name of the Data Lake Store account. </param>
        /// <param name="trustedIdProviderName"> The name of the trusted identity provider to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="trustedIdProviderName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="trustedIdProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DataLakeStoreTrustedIdProviderData> Get(string subscriptionId, string resourceGroupName, string accountName, string trustedIdProviderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(trustedIdProviderName, nameof(trustedIdProviderName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, accountName, trustedIdProviderName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataLakeStoreTrustedIdProviderData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataLakeStoreTrustedIdProviderData.DeserializeDataLakeStoreTrustedIdProviderData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DataLakeStoreTrustedIdProviderData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string subscriptionId, string resourceGroupName, string accountName, string trustedIdProviderName, DataLakeStoreTrustedIdProviderPatch patch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DataLakeStore/accounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/trustedIdProviders/", false);
            uri.AppendPath(trustedIdProviderName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(patch);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Updates the specified trusted identity provider. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the Azure resource group. </param>
        /// <param name="accountName"> The name of the Data Lake Store account. </param>
        /// <param name="trustedIdProviderName"> The name of the trusted identity provider. This is used for differentiation of providers in the account. </param>
        /// <param name="patch"> Parameters supplied to update the trusted identity provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="trustedIdProviderName"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="trustedIdProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DataLakeStoreTrustedIdProviderData>> UpdateAsync(string subscriptionId, string resourceGroupName, string accountName, string trustedIdProviderName, DataLakeStoreTrustedIdProviderPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(trustedIdProviderName, nameof(trustedIdProviderName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, accountName, trustedIdProviderName, patch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataLakeStoreTrustedIdProviderData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataLakeStoreTrustedIdProviderData.DeserializeDataLakeStoreTrustedIdProviderData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Updates the specified trusted identity provider. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the Azure resource group. </param>
        /// <param name="accountName"> The name of the Data Lake Store account. </param>
        /// <param name="trustedIdProviderName"> The name of the trusted identity provider. This is used for differentiation of providers in the account. </param>
        /// <param name="patch"> Parameters supplied to update the trusted identity provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="trustedIdProviderName"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="trustedIdProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DataLakeStoreTrustedIdProviderData> Update(string subscriptionId, string resourceGroupName, string accountName, string trustedIdProviderName, DataLakeStoreTrustedIdProviderPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(trustedIdProviderName, nameof(trustedIdProviderName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, accountName, trustedIdProviderName, patch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataLakeStoreTrustedIdProviderData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataLakeStoreTrustedIdProviderData.DeserializeDataLakeStoreTrustedIdProviderData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string accountName, string trustedIdProviderName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DataLakeStore/accounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/trustedIdProviders/", false);
            uri.AppendPath(trustedIdProviderName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes the specified trusted identity provider from the specified Data Lake Store account. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the Azure resource group. </param>
        /// <param name="accountName"> The name of the Data Lake Store account. </param>
        /// <param name="trustedIdProviderName"> The name of the trusted identity provider to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="trustedIdProviderName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="trustedIdProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string accountName, string trustedIdProviderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(trustedIdProviderName, nameof(trustedIdProviderName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, accountName, trustedIdProviderName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes the specified trusted identity provider from the specified Data Lake Store account. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the Azure resource group. </param>
        /// <param name="accountName"> The name of the Data Lake Store account. </param>
        /// <param name="trustedIdProviderName"> The name of the trusted identity provider to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="trustedIdProviderName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="trustedIdProviderName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string accountName, string trustedIdProviderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(trustedIdProviderName, nameof(trustedIdProviderName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, accountName, trustedIdProviderName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByAccountNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string accountName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the Data Lake Store trusted identity providers within the specified Data Lake Store account. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the Azure resource group. </param>
        /// <param name="accountName"> The name of the Data Lake Store account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DataLakeStoreTrustedIdProviderListResult>> ListByAccountNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var message = CreateListByAccountNextPageRequest(nextLink, subscriptionId, resourceGroupName, accountName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataLakeStoreTrustedIdProviderListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataLakeStoreTrustedIdProviderListResult.DeserializeDataLakeStoreTrustedIdProviderListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the Data Lake Store trusted identity providers within the specified Data Lake Store account. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the Azure resource group. </param>
        /// <param name="accountName"> The name of the Data Lake Store account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DataLakeStoreTrustedIdProviderListResult> ListByAccountNextPage(string nextLink, string subscriptionId, string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var message = CreateListByAccountNextPageRequest(nextLink, subscriptionId, resourceGroupName, accountName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataLakeStoreTrustedIdProviderListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataLakeStoreTrustedIdProviderListResult.DeserializeDataLakeStoreTrustedIdProviderListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
