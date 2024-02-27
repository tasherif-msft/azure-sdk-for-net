// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class EventHubsAccessKeys : IUtf8JsonSerializable, IJsonModel<EventHubsAccessKeys>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventHubsAccessKeys>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EventHubsAccessKeys>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsAccessKeys>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventHubsAccessKeys)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && PrimaryConnectionString != null)
            {
                writer.WritePropertyName("primaryConnectionString"u8);
                writer.WriteStringValue(PrimaryConnectionString);
            }
            if (options.Format != "W" && SecondaryConnectionString != null)
            {
                writer.WritePropertyName("secondaryConnectionString"u8);
                writer.WriteStringValue(SecondaryConnectionString);
            }
            if (options.Format != "W" && AliasPrimaryConnectionString != null)
            {
                writer.WritePropertyName("aliasPrimaryConnectionString"u8);
                writer.WriteStringValue(AliasPrimaryConnectionString);
            }
            if (options.Format != "W" && AliasSecondaryConnectionString != null)
            {
                writer.WritePropertyName("aliasSecondaryConnectionString"u8);
                writer.WriteStringValue(AliasSecondaryConnectionString);
            }
            if (options.Format != "W" && PrimaryKey != null)
            {
                writer.WritePropertyName("primaryKey"u8);
                writer.WriteStringValue(PrimaryKey);
            }
            if (options.Format != "W" && SecondaryKey != null)
            {
                writer.WritePropertyName("secondaryKey"u8);
                writer.WriteStringValue(SecondaryKey);
            }
            if (options.Format != "W" && KeyName != null)
            {
                writer.WritePropertyName("keyName"u8);
                writer.WriteStringValue(KeyName);
            }
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

        EventHubsAccessKeys IJsonModel<EventHubsAccessKeys>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsAccessKeys>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventHubsAccessKeys)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventHubsAccessKeys(document.RootElement, options);
        }

        internal static EventHubsAccessKeys DeserializeEventHubsAccessKeys(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> primaryConnectionString = default;
            Optional<string> secondaryConnectionString = default;
            Optional<string> aliasPrimaryConnectionString = default;
            Optional<string> aliasSecondaryConnectionString = default;
            Optional<string> primaryKey = default;
            Optional<string> secondaryKey = default;
            Optional<string> keyName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryConnectionString"u8))
                {
                    primaryConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryConnectionString"u8))
                {
                    secondaryConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aliasPrimaryConnectionString"u8))
                {
                    aliasPrimaryConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aliasSecondaryConnectionString"u8))
                {
                    aliasSecondaryConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryKey"u8))
                {
                    primaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryKey"u8))
                {
                    secondaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyName"u8))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EventHubsAccessKeys(
                primaryConnectionString.Value,
                secondaryConnectionString.Value,
                aliasPrimaryConnectionString.Value,
                aliasSecondaryConnectionString.Value,
                primaryKey.Value,
                secondaryKey.Value,
                keyName.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EventHubsAccessKeys>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsAccessKeys>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EventHubsAccessKeys)} does not support '{options.Format}' format.");
            }
        }

        EventHubsAccessKeys IPersistableModel<EventHubsAccessKeys>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsAccessKeys>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEventHubsAccessKeys(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EventHubsAccessKeys)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventHubsAccessKeys>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
