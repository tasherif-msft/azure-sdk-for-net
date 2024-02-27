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

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    internal partial class UnknownInputProperties : IUtf8JsonSerializable, IJsonModel<StreamingJobInputProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamingJobInputProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StreamingJobInputProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobInputProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingJobInputProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(InputPropertiesType);
            if (Serialization != null)
            {
                writer.WritePropertyName("serialization"u8);
                writer.WriteObjectValue(Serialization);
            }
            if (options.Format != "W" && Diagnostics != null)
            {
                writer.WritePropertyName("diagnostics"u8);
                writer.WriteObjectValue(Diagnostics);
            }
            if (options.Format != "W" && ETag.HasValue)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Compression != null)
            {
                writer.WritePropertyName("compression"u8);
                writer.WriteObjectValue(Compression);
            }
            if (PartitionKey != null)
            {
                writer.WritePropertyName("partitionKey"u8);
                writer.WriteStringValue(PartitionKey);
            }
            if (WatermarkSettings != null)
            {
                writer.WritePropertyName("watermarkSettings"u8);
                writer.WriteObjectValue(WatermarkSettings);
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

        StreamingJobInputProperties IJsonModel<StreamingJobInputProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobInputProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingJobInputProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingJobInputProperties(document.RootElement, options);
        }

        internal static UnknownInputProperties DeserializeUnknownInputProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = "Unknown";
            Optional<StreamAnalyticsDataSerialization> serialization = default;
            Optional<StreamingJobDiagnostics> diagnostics = default;
            Optional<ETag> etag = default;
            Optional<StreamingCompression> compression = default;
            Optional<string> partitionKey = default;
            Optional<StreamingJobInputWatermarkProperties> watermarkSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serialization"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serialization = StreamAnalyticsDataSerialization.DeserializeStreamAnalyticsDataSerialization(property.Value, options);
                    continue;
                }
                if (property.NameEquals("diagnostics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diagnostics = StreamingJobDiagnostics.DeserializeStreamingJobDiagnostics(property.Value, options);
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("compression"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    compression = StreamingCompression.DeserializeStreamingCompression(property.Value, options);
                    continue;
                }
                if (property.NameEquals("partitionKey"u8))
                {
                    partitionKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("watermarkSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    watermarkSettings = StreamingJobInputWatermarkProperties.DeserializeStreamingJobInputWatermarkProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownInputProperties(
                type,
                serialization.Value,
                diagnostics.Value,
                Optional.ToNullable(etag),
                compression.Value,
                partitionKey.Value,
                watermarkSettings.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StreamingJobInputProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobInputProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StreamingJobInputProperties)} does not support '{options.Format}' format.");
            }
        }

        StreamingJobInputProperties IPersistableModel<StreamingJobInputProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobInputProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStreamingJobInputProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamingJobInputProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamingJobInputProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
