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
    public partial class VideoLayer : IUtf8JsonSerializable, IJsonModel<VideoLayer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VideoLayer>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VideoLayer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VideoLayer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VideoLayer)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("bitrate"u8);
            writer.WriteNumberValue(Bitrate);
            if (MaxBitrate.HasValue)
            {
                writer.WritePropertyName("maxBitrate"u8);
                writer.WriteNumberValue(MaxBitrate.Value);
            }
            if (BFrames.HasValue)
            {
                writer.WritePropertyName("bFrames"u8);
                writer.WriteNumberValue(BFrames.Value);
            }
            if (FrameRate != null)
            {
                writer.WritePropertyName("frameRate"u8);
                writer.WriteStringValue(FrameRate);
            }
            if (Slices.HasValue)
            {
                writer.WritePropertyName("slices"u8);
                writer.WriteNumberValue(Slices.Value);
            }
            if (UseAdaptiveBFrame.HasValue)
            {
                writer.WritePropertyName("adaptiveBFrame"u8);
                writer.WriteBooleanValue(UseAdaptiveBFrame.Value);
            }
            if (Width != null)
            {
                writer.WritePropertyName("width"u8);
                writer.WriteStringValue(Width);
            }
            if (Height != null)
            {
                writer.WritePropertyName("height"u8);
                writer.WriteStringValue(Height);
            }
            if (Label != null)
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
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

        VideoLayer IJsonModel<VideoLayer>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VideoLayer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VideoLayer)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVideoLayer(document.RootElement, options);
        }

        internal static VideoLayer DeserializeVideoLayer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int bitrate = default;
            Optional<int> maxBitrate = default;
            Optional<int> bFrames = default;
            Optional<string> frameRate = default;
            Optional<int> slices = default;
            Optional<bool> adaptiveBFrame = default;
            Optional<string> width = default;
            Optional<string> height = default;
            Optional<string> label = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bitrate"u8))
                {
                    bitrate = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxBitrate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxBitrate = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("bFrames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bFrames = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("frameRate"u8))
                {
                    frameRate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("slices"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    slices = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("adaptiveBFrame"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    adaptiveBFrame = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("width"u8))
                {
                    width = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("height"u8))
                {
                    height = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VideoLayer(
                width.Value,
                height.Value,
                label.Value,
                serializedAdditionalRawData,
                bitrate,
                Optional.ToNullable(maxBitrate),
                Optional.ToNullable(bFrames),
                frameRate.Value,
                Optional.ToNullable(slices),
                Optional.ToNullable(adaptiveBFrame));
        }

        BinaryData IPersistableModel<VideoLayer>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VideoLayer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VideoLayer)} does not support '{options.Format}' format.");
            }
        }

        VideoLayer IPersistableModel<VideoLayer>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VideoLayer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVideoLayer(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VideoLayer)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VideoLayer>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
