// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ResourceDeleteFailureEventDataConverter))]
    public partial class ResourceDeleteFailureEventData
    {
        internal static ResourceDeleteFailureEventData DeserializeResourceDeleteFailureEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> tenantId = default;
            Optional<string> subscriptionId = default;
            Optional<string> resourceGroup = default;
            Optional<string> resourceProvider = default;
            Optional<string> resourceUri = default;
            Optional<string> operationName = default;
            Optional<string> status = default;
            Optional<JsonElement> authorization = default;
            Optional<JsonElement> claims = default;
            Optional<string> correlationId = default;
            Optional<JsonElement> httpRequest = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tenantId"u8))
                {
                    tenantId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroup"u8))
                {
                    resourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceProvider"u8))
                {
                    resourceProvider = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceUri"u8))
                {
                    resourceUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationName"u8))
                {
                    operationName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authorization"u8))
                {
                    authorization = property.Value.Clone();
                    continue;
                }
                if (property.NameEquals("claims"u8))
                {
                    claims = property.Value.Clone();
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpRequest"u8))
                {
                    httpRequest = property.Value.Clone();
                    continue;
                }
            }
            return new ResourceDeleteFailureEventData(
                tenantId.Value,
                subscriptionId.Value,
                resourceGroup.Value,
                resourceProvider.Value,
                resourceUri.Value,
                operationName.Value,
                status.Value,
                authorization,
                claims,
                correlationId.Value,
                httpRequest);
        }

        internal partial class ResourceDeleteFailureEventDataConverter : JsonConverter<ResourceDeleteFailureEventData>
        {
            public override void Write(Utf8JsonWriter writer, ResourceDeleteFailureEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override ResourceDeleteFailureEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeResourceDeleteFailureEventData(document.RootElement);
            }
        }
    }
}
