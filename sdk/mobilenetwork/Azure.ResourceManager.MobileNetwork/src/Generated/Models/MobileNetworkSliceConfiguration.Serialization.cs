// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class MobileNetworkSliceConfiguration : IUtf8JsonSerializable, IJsonModel<MobileNetworkSliceConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MobileNetworkSliceConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MobileNetworkSliceConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkSliceConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MobileNetworkSliceConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("slice"u8);
            JsonSerializer.Serialize(writer, Slice);
            writer.WritePropertyName("defaultDataNetwork"u8);
            JsonSerializer.Serialize(writer, DefaultDataNetwork);
            writer.WritePropertyName("dataNetworkConfigurations"u8);
            writer.WriteStartArray();
            foreach (var item in DataNetworkConfigurations)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        MobileNetworkSliceConfiguration IJsonModel<MobileNetworkSliceConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkSliceConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MobileNetworkSliceConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMobileNetworkSliceConfiguration(document.RootElement, options);
        }

        internal static MobileNetworkSliceConfiguration DeserializeMobileNetworkSliceConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WritableSubResource slice = default;
            WritableSubResource defaultDataNetwork = default;
            IList<DataNetworkConfiguration> dataNetworkConfigurations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("slice"u8))
                {
                    slice = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("defaultDataNetwork"u8))
                {
                    defaultDataNetwork = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("dataNetworkConfigurations"u8))
                {
                    List<DataNetworkConfiguration> array = new List<DataNetworkConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataNetworkConfiguration.DeserializeDataNetworkConfiguration(item));
                    }
                    dataNetworkConfigurations = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MobileNetworkSliceConfiguration(slice, defaultDataNetwork, dataNetworkConfigurations, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MobileNetworkSliceConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkSliceConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MobileNetworkSliceConfiguration)} does not support '{options.Format}' format.");
            }
        }

        MobileNetworkSliceConfiguration IPersistableModel<MobileNetworkSliceConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkSliceConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMobileNetworkSliceConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MobileNetworkSliceConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MobileNetworkSliceConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
