// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class DscReportResource : IUtf8JsonSerializable, IJsonModel<DscReportResource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DscReportResource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DscReportResource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscReportResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DscReportResource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ResourceId != null)
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (SourceInfo != null)
            {
                writer.WritePropertyName("sourceInfo"u8);
                writer.WriteStringValue(SourceInfo);
            }
            if (!(DependsOn is ChangeTrackingList<DscReportResourceNavigation> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("dependsOn"u8);
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ModuleName != null)
            {
                writer.WritePropertyName("moduleName"u8);
                writer.WriteStringValue(ModuleName);
            }
            if (ModuleVersion != null)
            {
                writer.WritePropertyName("moduleVersion"u8);
                writer.WriteStringValue(ModuleVersion);
            }
            if (ResourceName != null)
            {
                writer.WritePropertyName("resourceName"u8);
                writer.WriteStringValue(ResourceName);
            }
            if (Error != null)
            {
                writer.WritePropertyName("error"u8);
                writer.WriteStringValue(Error);
            }
            if (Status != null)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (DurationInSeconds.HasValue)
            {
                writer.WritePropertyName("durationInSeconds"u8);
                writer.WriteNumberValue(DurationInSeconds.Value);
            }
            if (StartOn.HasValue)
            {
                writer.WritePropertyName("startDate"u8);
                writer.WriteStringValue(StartOn.Value, "O");
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

        DscReportResource IJsonModel<DscReportResource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscReportResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DscReportResource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDscReportResource(document.RootElement, options);
        }

        internal static DscReportResource DeserializeDscReportResource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> resourceId = default;
            Optional<string> sourceInfo = default;
            IReadOnlyList<DscReportResourceNavigation> dependsOn = default;
            Optional<string> moduleName = default;
            Optional<string> moduleVersion = default;
            Optional<string> resourceName = default;
            Optional<string> error = default;
            Optional<string> status = default;
            Optional<double> durationInSeconds = default;
            Optional<DateTimeOffset> startDate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceInfo"u8))
                {
                    sourceInfo = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependsOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DscReportResourceNavigation> array = new List<DscReportResourceNavigation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DscReportResourceNavigation.DeserializeDscReportResourceNavigation(item, options));
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("moduleName"u8))
                {
                    moduleName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("moduleVersion"u8))
                {
                    moduleVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceName"u8))
                {
                    resourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    error = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("durationInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    durationInSeconds = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("startDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DscReportResource(
                resourceId.Value,
                sourceInfo.Value,
                dependsOn ?? new ChangeTrackingList<DscReportResourceNavigation>(),
                moduleName.Value,
                moduleVersion.Value,
                resourceName.Value,
                error.Value,
                status.Value,
                Optional.ToNullable(durationInSeconds),
                Optional.ToNullable(startDate),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DscReportResource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscReportResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DscReportResource)} does not support '{options.Format}' format.");
            }
        }

        DscReportResource IPersistableModel<DscReportResource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscReportResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDscReportResource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DscReportResource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DscReportResource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
