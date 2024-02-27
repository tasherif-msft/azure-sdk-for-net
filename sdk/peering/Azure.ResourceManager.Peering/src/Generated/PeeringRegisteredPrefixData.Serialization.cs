// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Peering.Models;

namespace Azure.ResourceManager.Peering
{
    public partial class PeeringRegisteredPrefixData : IUtf8JsonSerializable, IJsonModel<PeeringRegisteredPrefixData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PeeringRegisteredPrefixData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PeeringRegisteredPrefixData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeeringRegisteredPrefixData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PeeringRegisteredPrefixData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (Prefix != null)
            {
                writer.WritePropertyName("prefix"u8);
                writer.WriteStringValue(Prefix);
            }
            if (options.Format != "W" && PrefixValidationState.HasValue)
            {
                writer.WritePropertyName("prefixValidationState"u8);
                writer.WriteStringValue(PrefixValidationState.Value.ToString());
            }
            if (options.Format != "W" && PeeringServicePrefixKey != null)
            {
                writer.WritePropertyName("peeringServicePrefixKey"u8);
                writer.WriteStringValue(PeeringServicePrefixKey);
            }
            if (options.Format != "W" && ErrorMessage != null)
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        PeeringRegisteredPrefixData IJsonModel<PeeringRegisteredPrefixData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeeringRegisteredPrefixData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PeeringRegisteredPrefixData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePeeringRegisteredPrefixData(document.RootElement, options);
        }

        internal static PeeringRegisteredPrefixData DeserializePeeringRegisteredPrefixData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> prefix = default;
            Optional<PeeringPrefixValidationState> prefixValidationState = default;
            Optional<string> peeringServicePrefixKey = default;
            Optional<string> errorMessage = default;
            Optional<PeeringProvisioningState> provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("prefix"u8))
                        {
                            prefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("prefixValidationState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            prefixValidationState = new PeeringPrefixValidationState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("peeringServicePrefixKey"u8))
                        {
                            peeringServicePrefixKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("errorMessage"u8))
                        {
                            errorMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new PeeringProvisioningState(property0.Value.GetString());
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
            return new PeeringRegisteredPrefixData(
                id,
                name,
                type,
                systemData.Value,
                prefix.Value,
                Optional.ToNullable(prefixValidationState),
                peeringServicePrefixKey.Value,
                errorMessage.Value,
                Optional.ToNullable(provisioningState),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PeeringRegisteredPrefixData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeeringRegisteredPrefixData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PeeringRegisteredPrefixData)} does not support '{options.Format}' format.");
            }
        }

        PeeringRegisteredPrefixData IPersistableModel<PeeringRegisteredPrefixData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeeringRegisteredPrefixData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePeeringRegisteredPrefixData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PeeringRegisteredPrefixData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PeeringRegisteredPrefixData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
