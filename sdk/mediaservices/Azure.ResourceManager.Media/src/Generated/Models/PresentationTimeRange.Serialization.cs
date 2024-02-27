// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class PresentationTimeRange : IUtf8JsonSerializable, IJsonModel<PresentationTimeRange>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PresentationTimeRange>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PresentationTimeRange>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PresentationTimeRange>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PresentationTimeRange)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (StartTimestamp.HasValue)
            {
                writer.WritePropertyName("startTimestamp"u8);
                writer.WriteNumberValue(StartTimestamp.Value);
            }
            if (EndTimestamp.HasValue)
            {
                writer.WritePropertyName("endTimestamp"u8);
                writer.WriteNumberValue(EndTimestamp.Value);
            }
            if (PresentationWindowDuration.HasValue)
            {
                writer.WritePropertyName("presentationWindowDuration"u8);
                writer.WriteNumberValue(PresentationWindowDuration.Value);
            }
            if (LiveBackoffDuration.HasValue)
            {
                writer.WritePropertyName("liveBackoffDuration"u8);
                writer.WriteNumberValue(LiveBackoffDuration.Value);
            }
            if (Timescale.HasValue)
            {
                writer.WritePropertyName("timescale"u8);
                writer.WriteNumberValue(Timescale.Value);
            }
            if (ForceEndTimestamp.HasValue)
            {
                writer.WritePropertyName("forceEndTimestamp"u8);
                writer.WriteBooleanValue(ForceEndTimestamp.Value);
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

        PresentationTimeRange IJsonModel<PresentationTimeRange>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PresentationTimeRange>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PresentationTimeRange)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePresentationTimeRange(document.RootElement, options);
        }

        internal static PresentationTimeRange DeserializePresentationTimeRange(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> startTimestamp = default;
            Optional<long> endTimestamp = default;
            Optional<long> presentationWindowDuration = default;
            Optional<long> liveBackoffDuration = default;
            Optional<long> timescale = default;
            Optional<bool> forceEndTimestamp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTimestamp = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("endTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTimestamp = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("presentationWindowDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    presentationWindowDuration = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("liveBackoffDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    liveBackoffDuration = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("timescale"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timescale = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("forceEndTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    forceEndTimestamp = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PresentationTimeRange(
                Optional.ToNullable(startTimestamp),
                Optional.ToNullable(endTimestamp),
                Optional.ToNullable(presentationWindowDuration),
                Optional.ToNullable(liveBackoffDuration),
                Optional.ToNullable(timescale),
                Optional.ToNullable(forceEndTimestamp),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PresentationTimeRange>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PresentationTimeRange>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PresentationTimeRange)} does not support '{options.Format}' format.");
            }
        }

        PresentationTimeRange IPersistableModel<PresentationTimeRange>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PresentationTimeRange>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePresentationTimeRange(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PresentationTimeRange)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PresentationTimeRange>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
