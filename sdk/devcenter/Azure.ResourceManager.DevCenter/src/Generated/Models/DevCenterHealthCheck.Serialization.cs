// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevCenter.Models
{
    public partial class DevCenterHealthCheck : IUtf8JsonSerializable, IJsonModel<DevCenterHealthCheck>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevCenterHealthCheck>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DevCenterHealthCheck>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterHealthCheck>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevCenterHealthCheck)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && DisplayName != null)
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && StartOn.HasValue)
            {
                writer.WritePropertyName("startDateTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && EndOn.HasValue)
            {
                writer.WritePropertyName("endDateTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (options.Format != "W" && ErrorType != null)
            {
                writer.WritePropertyName("errorType"u8);
                writer.WriteStringValue(ErrorType);
            }
            if (options.Format != "W" && RecommendedAction != null)
            {
                writer.WritePropertyName("recommendedAction"u8);
                writer.WriteStringValue(RecommendedAction);
            }
            if (options.Format != "W" && AdditionalDetails != null)
            {
                writer.WritePropertyName("additionalDetails"u8);
                writer.WriteStringValue(AdditionalDetails);
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

        DevCenterHealthCheck IJsonModel<DevCenterHealthCheck>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterHealthCheck>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevCenterHealthCheck)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevCenterHealthCheck(document.RootElement, options);
        }

        internal static DevCenterHealthCheck DeserializeDevCenterHealthCheck(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DevCenterHealthCheckStatus> status = default;
            Optional<string> displayName = default;
            Optional<DateTimeOffset> startDateTime = default;
            Optional<DateTimeOffset> endDateTime = default;
            Optional<string> errorType = default;
            Optional<string> recommendedAction = default;
            Optional<string> additionalDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new DevCenterHealthCheckStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("errorType"u8))
                {
                    errorType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recommendedAction"u8))
                {
                    recommendedAction = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("additionalDetails"u8))
                {
                    additionalDetails = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DevCenterHealthCheck(
                Optional.ToNullable(status),
                displayName.Value,
                Optional.ToNullable(startDateTime),
                Optional.ToNullable(endDateTime),
                errorType.Value,
                recommendedAction.Value,
                additionalDetails.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevCenterHealthCheck>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterHealthCheck>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevCenterHealthCheck)} does not support '{options.Format}' format.");
            }
        }

        DevCenterHealthCheck IPersistableModel<DevCenterHealthCheck>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterHealthCheck>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevCenterHealthCheck(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevCenterHealthCheck)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevCenterHealthCheck>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
