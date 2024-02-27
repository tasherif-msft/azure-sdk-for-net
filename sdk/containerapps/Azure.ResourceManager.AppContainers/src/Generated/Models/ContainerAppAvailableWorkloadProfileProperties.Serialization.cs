// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppAvailableWorkloadProfileProperties : IUtf8JsonSerializable, IJsonModel<ContainerAppAvailableWorkloadProfileProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppAvailableWorkloadProfileProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppAvailableWorkloadProfileProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppAvailableWorkloadProfileProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppAvailableWorkloadProfileProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Category != null)
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category);
            }
            if (Applicability.HasValue)
            {
                writer.WritePropertyName("applicability"u8);
                writer.WriteStringValue(Applicability.Value.ToString());
            }
            if (Cores.HasValue)
            {
                writer.WritePropertyName("cores"u8);
                writer.WriteNumberValue(Cores.Value);
            }
            if (MemoryInGiB.HasValue)
            {
                writer.WritePropertyName("memoryGiB"u8);
                writer.WriteNumberValue(MemoryInGiB.Value);
            }
            if (DisplayName != null)
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
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

        ContainerAppAvailableWorkloadProfileProperties IJsonModel<ContainerAppAvailableWorkloadProfileProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppAvailableWorkloadProfileProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppAvailableWorkloadProfileProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppAvailableWorkloadProfileProperties(document.RootElement, options);
        }

        internal static ContainerAppAvailableWorkloadProfileProperties DeserializeContainerAppAvailableWorkloadProfileProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> category = default;
            Optional<ContainerAppAvailableWorkloadProfileApplicability> applicability = default;
            Optional<int> cores = default;
            Optional<int> memoryGiB = default;
            Optional<string> displayName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("applicability"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applicability = new ContainerAppAvailableWorkloadProfileApplicability(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cores"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cores = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("memoryGiB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memoryGiB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppAvailableWorkloadProfileProperties(
                category.Value,
                Optional.ToNullable(applicability),
                Optional.ToNullable(cores),
                Optional.ToNullable(memoryGiB),
                displayName.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppAvailableWorkloadProfileProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppAvailableWorkloadProfileProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppAvailableWorkloadProfileProperties)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppAvailableWorkloadProfileProperties IPersistableModel<ContainerAppAvailableWorkloadProfileProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppAvailableWorkloadProfileProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppAvailableWorkloadProfileProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppAvailableWorkloadProfileProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppAvailableWorkloadProfileProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
