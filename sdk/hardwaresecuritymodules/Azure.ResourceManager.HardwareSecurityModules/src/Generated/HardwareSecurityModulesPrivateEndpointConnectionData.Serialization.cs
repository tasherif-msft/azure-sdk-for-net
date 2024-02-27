// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.HardwareSecurityModules.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.HardwareSecurityModules
{
    public partial class HardwareSecurityModulesPrivateEndpointConnectionData : IUtf8JsonSerializable, IJsonModel<HardwareSecurityModulesPrivateEndpointConnectionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HardwareSecurityModulesPrivateEndpointConnectionData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HardwareSecurityModulesPrivateEndpointConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HardwareSecurityModulesPrivateEndpointConnectionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HardwareSecurityModulesPrivateEndpointConnectionData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ETag.HasValue)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (PrivateEndpoint != null)
            {
                writer.WritePropertyName("privateEndpoint"u8);
                JsonSerializer.Serialize(writer, PrivateEndpoint);
            }
            if (ConnectionState != null)
            {
                writer.WritePropertyName("privateLinkServiceConnectionState"u8);
                writer.WriteObjectValue(ConnectionState);
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && !(GroupIds is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("groupIds"u8);
                writer.WriteStartArray();
                foreach (var item in GroupIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        HardwareSecurityModulesPrivateEndpointConnectionData IJsonModel<HardwareSecurityModulesPrivateEndpointConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HardwareSecurityModulesPrivateEndpointConnectionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HardwareSecurityModulesPrivateEndpointConnectionData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHardwareSecurityModulesPrivateEndpointConnectionData(document.RootElement, options);
        }

        internal static HardwareSecurityModulesPrivateEndpointConnectionData DeserializeHardwareSecurityModulesPrivateEndpointConnectionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<SubResource> privateEndpoint = default;
            Optional<HardwareSecurityModulesPrivateLinkServiceConnectionState> privateLinkServiceConnectionState = default;
            Optional<HardwareSecurityModulesPrivateEndpointConnectionProvisioningState> provisioningState = default;
            IReadOnlyList<string> groupIds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("privateEndpoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateEndpoint = JsonSerializer.Deserialize<SubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("privateLinkServiceConnectionState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateLinkServiceConnectionState = HardwareSecurityModulesPrivateLinkServiceConnectionState.DeserializeHardwareSecurityModulesPrivateLinkServiceConnectionState(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new HardwareSecurityModulesPrivateEndpointConnectionProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("groupIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            groupIds = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HardwareSecurityModulesPrivateEndpointConnectionData(
                id,
                name,
                type,
                systemData.Value,
                Optional.ToNullable(etag),
                privateEndpoint,
                privateLinkServiceConnectionState.Value,
                Optional.ToNullable(provisioningState),
                groupIds ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HardwareSecurityModulesPrivateEndpointConnectionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HardwareSecurityModulesPrivateEndpointConnectionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HardwareSecurityModulesPrivateEndpointConnectionData)} does not support '{options.Format}' format.");
            }
        }

        HardwareSecurityModulesPrivateEndpointConnectionData IPersistableModel<HardwareSecurityModulesPrivateEndpointConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HardwareSecurityModulesPrivateEndpointConnectionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHardwareSecurityModulesPrivateEndpointConnectionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HardwareSecurityModulesPrivateEndpointConnectionData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HardwareSecurityModulesPrivateEndpointConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
