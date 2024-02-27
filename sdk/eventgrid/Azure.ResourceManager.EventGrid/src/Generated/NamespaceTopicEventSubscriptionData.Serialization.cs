// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    public partial class NamespaceTopicEventSubscriptionData : IUtf8JsonSerializable, IJsonModel<NamespaceTopicEventSubscriptionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NamespaceTopicEventSubscriptionData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NamespaceTopicEventSubscriptionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NamespaceTopicEventSubscriptionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NamespaceTopicEventSubscriptionData)} does not support '{format}' format.");
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
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (DeliveryConfiguration != null)
            {
                writer.WritePropertyName("deliveryConfiguration"u8);
                writer.WriteObjectValue(DeliveryConfiguration);
            }
            if (EventDeliverySchema.HasValue)
            {
                writer.WritePropertyName("eventDeliverySchema"u8);
                writer.WriteStringValue(EventDeliverySchema.Value.ToString());
            }
            if (FiltersConfiguration != null)
            {
                writer.WritePropertyName("filtersConfiguration"u8);
                writer.WriteObjectValue(FiltersConfiguration);
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

        NamespaceTopicEventSubscriptionData IJsonModel<NamespaceTopicEventSubscriptionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NamespaceTopicEventSubscriptionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NamespaceTopicEventSubscriptionData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNamespaceTopicEventSubscriptionData(document.RootElement, options);
        }

        internal static NamespaceTopicEventSubscriptionData DeserializeNamespaceTopicEventSubscriptionData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<SubscriptionProvisioningState> provisioningState = default;
            Optional<DeliveryConfiguration> deliveryConfiguration = default;
            Optional<DeliverySchema> eventDeliverySchema = default;
            Optional<FiltersConfiguration> filtersConfiguration = default;
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new SubscriptionProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("deliveryConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deliveryConfiguration = DeliveryConfiguration.DeserializeDeliveryConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("eventDeliverySchema"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventDeliverySchema = new DeliverySchema(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("filtersConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            filtersConfiguration = FiltersConfiguration.DeserializeFiltersConfiguration(property0.Value, options);
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
            return new NamespaceTopicEventSubscriptionData(
                id,
                name,
                type,
                systemData.Value,
                Optional.ToNullable(provisioningState),
                deliveryConfiguration.Value,
                Optional.ToNullable(eventDeliverySchema),
                filtersConfiguration.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NamespaceTopicEventSubscriptionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NamespaceTopicEventSubscriptionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NamespaceTopicEventSubscriptionData)} does not support '{options.Format}' format.");
            }
        }

        NamespaceTopicEventSubscriptionData IPersistableModel<NamespaceTopicEventSubscriptionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NamespaceTopicEventSubscriptionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNamespaceTopicEventSubscriptionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NamespaceTopicEventSubscriptionData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NamespaceTopicEventSubscriptionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
