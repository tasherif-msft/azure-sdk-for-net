// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Automation.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation
{
    public partial class HybridRunbookWorkerData : IUtf8JsonSerializable, IJsonModel<HybridRunbookWorkerData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HybridRunbookWorkerData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HybridRunbookWorkerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridRunbookWorkerData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridRunbookWorkerData)} does not support '{format}' format.");
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
            if (IP != null)
            {
                writer.WritePropertyName("ip"u8);
                writer.WriteStringValue(IP);
            }
            if (RegisteredOn.HasValue)
            {
                writer.WritePropertyName("registeredDateTime"u8);
                writer.WriteStringValue(RegisteredOn.Value, "O");
            }
            if (LastSeenOn.HasValue)
            {
                writer.WritePropertyName("lastSeenDateTime"u8);
                writer.WriteStringValue(LastSeenOn.Value, "O");
            }
            if (VmResourceId != null)
            {
                writer.WritePropertyName("vmResourceId"u8);
                writer.WriteStringValue(VmResourceId);
            }
            if (WorkerType.HasValue)
            {
                writer.WritePropertyName("workerType"u8);
                writer.WriteStringValue(WorkerType.Value.ToString());
            }
            if (WorkerName != null)
            {
                writer.WritePropertyName("workerName"u8);
                writer.WriteStringValue(WorkerName);
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

        HybridRunbookWorkerData IJsonModel<HybridRunbookWorkerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridRunbookWorkerData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridRunbookWorkerData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHybridRunbookWorkerData(document.RootElement, options);
        }

        internal static HybridRunbookWorkerData DeserializeHybridRunbookWorkerData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<string> ip = default;
            Optional<DateTimeOffset> registeredDateTime = default;
            Optional<DateTimeOffset> lastSeenDateTime = default;
            Optional<ResourceIdentifier> vmResourceId = default;
            Optional<HybridWorkerType> workerType = default;
            Optional<string> workerName = default;
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
                        if (property0.NameEquals("ip"u8))
                        {
                            ip = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("registeredDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            registeredDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastSeenDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastSeenDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("vmResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vmResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("workerType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            workerType = new HybridWorkerType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("workerName"u8))
                        {
                            workerName = property0.Value.GetString();
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
            return new HybridRunbookWorkerData(
                id,
                name,
                type,
                systemData.Value,
                ip.Value,
                Optional.ToNullable(registeredDateTime),
                Optional.ToNullable(lastSeenDateTime),
                vmResourceId.Value,
                Optional.ToNullable(workerType),
                workerName.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HybridRunbookWorkerData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridRunbookWorkerData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HybridRunbookWorkerData)} does not support '{options.Format}' format.");
            }
        }

        HybridRunbookWorkerData IPersistableModel<HybridRunbookWorkerData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridRunbookWorkerData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHybridRunbookWorkerData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HybridRunbookWorkerData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HybridRunbookWorkerData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
