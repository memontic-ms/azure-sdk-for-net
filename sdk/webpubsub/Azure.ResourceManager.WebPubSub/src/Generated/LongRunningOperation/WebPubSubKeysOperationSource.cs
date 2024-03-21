// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.WebPubSub.Models;

namespace Azure.ResourceManager.WebPubSub
{
    internal class WebPubSubKeysOperationSource : IOperationSource<WebPubSubKeys>
    {
        WebPubSubKeys IOperationSource<WebPubSubKeys>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return WebPubSubKeys.DeserializeWebPubSubKeys(document.RootElement);
        }

        async ValueTask<WebPubSubKeys> IOperationSource<WebPubSubKeys>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return WebPubSubKeys.DeserializeWebPubSubKeys(document.RootElement);
        }
    }
}
