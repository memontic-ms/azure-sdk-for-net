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
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation
{
    internal partial class TestJobStreamsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of TestJobStreamsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public TestJobStreamsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2018-06-30";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string automationAccountName, string runbookName, string jobStreamId)
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
            uri.AppendPath("/providers/Microsoft.Automation/automationAccounts/", false);
            uri.AppendPath(automationAccountName, true);
            uri.AppendPath("/runbooks/", false);
            uri.AppendPath(runbookName, true);
            uri.AppendPath("/draft/testJob/streams/", false);
            uri.AppendPath(jobStreamId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieve a test job stream of the test job identified by runbook name and stream id. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="runbookName"> The runbook name. </param>
        /// <param name="jobStreamId"> The job stream id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/>, <paramref name="runbookName"/> or <paramref name="jobStreamId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/>, <paramref name="runbookName"/> or <paramref name="jobStreamId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AutomationJobStream>> GetAsync(string subscriptionId, string resourceGroupName, string automationAccountName, string runbookName, string jobStreamId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(runbookName, nameof(runbookName));
            Argument.AssertNotNullOrEmpty(jobStreamId, nameof(jobStreamId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, automationAccountName, runbookName, jobStreamId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutomationJobStream value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AutomationJobStream.DeserializeAutomationJobStream(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieve a test job stream of the test job identified by runbook name and stream id. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="runbookName"> The runbook name. </param>
        /// <param name="jobStreamId"> The job stream id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/>, <paramref name="runbookName"/> or <paramref name="jobStreamId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/>, <paramref name="runbookName"/> or <paramref name="jobStreamId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AutomationJobStream> Get(string subscriptionId, string resourceGroupName, string automationAccountName, string runbookName, string jobStreamId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(runbookName, nameof(runbookName));
            Argument.AssertNotNullOrEmpty(jobStreamId, nameof(jobStreamId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, automationAccountName, runbookName, jobStreamId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutomationJobStream value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AutomationJobStream.DeserializeAutomationJobStream(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByTestJobRequest(string subscriptionId, string resourceGroupName, string automationAccountName, string runbookName, string filter)
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
            uri.AppendPath("/providers/Microsoft.Automation/automationAccounts/", false);
            uri.AppendPath(automationAccountName, true);
            uri.AppendPath("/runbooks/", false);
            uri.AppendPath(runbookName, true);
            uri.AppendPath("/draft/testJob/streams", false);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieve a list of test job streams identified by runbook name. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="runbookName"> The runbook name. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="runbookName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="runbookName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AutomationJobStreamListResult>> ListByTestJobAsync(string subscriptionId, string resourceGroupName, string automationAccountName, string runbookName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(runbookName, nameof(runbookName));

            using var message = CreateListByTestJobRequest(subscriptionId, resourceGroupName, automationAccountName, runbookName, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutomationJobStreamListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AutomationJobStreamListResult.DeserializeAutomationJobStreamListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieve a list of test job streams identified by runbook name. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="runbookName"> The runbook name. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="runbookName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="runbookName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AutomationJobStreamListResult> ListByTestJob(string subscriptionId, string resourceGroupName, string automationAccountName, string runbookName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(runbookName, nameof(runbookName));

            using var message = CreateListByTestJobRequest(subscriptionId, resourceGroupName, automationAccountName, runbookName, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutomationJobStreamListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AutomationJobStreamListResult.DeserializeAutomationJobStreamListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByTestJobNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string automationAccountName, string runbookName, string filter)
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

        /// <summary> Retrieve a list of test job streams identified by runbook name. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="runbookName"> The runbook name. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="runbookName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="runbookName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AutomationJobStreamListResult>> ListByTestJobNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string automationAccountName, string runbookName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(runbookName, nameof(runbookName));

            using var message = CreateListByTestJobNextPageRequest(nextLink, subscriptionId, resourceGroupName, automationAccountName, runbookName, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutomationJobStreamListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AutomationJobStreamListResult.DeserializeAutomationJobStreamListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieve a list of test job streams identified by runbook name. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="runbookName"> The runbook name. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="runbookName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="runbookName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AutomationJobStreamListResult> ListByTestJobNextPage(string nextLink, string subscriptionId, string resourceGroupName, string automationAccountName, string runbookName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(runbookName, nameof(runbookName));

            using var message = CreateListByTestJobNextPageRequest(nextLink, subscriptionId, resourceGroupName, automationAccountName, runbookName, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutomationJobStreamListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AutomationJobStreamListResult.DeserializeAutomationJobStreamListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
