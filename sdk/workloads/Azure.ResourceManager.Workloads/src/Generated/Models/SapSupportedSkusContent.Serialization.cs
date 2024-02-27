// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class SapSupportedSkusContent : IUtf8JsonSerializable, IJsonModel<SapSupportedSkusContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SapSupportedSkusContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SapSupportedSkusContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapSupportedSkusContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapSupportedSkusContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("appLocation"u8);
            writer.WriteStringValue(AppLocation);
            writer.WritePropertyName("environment"u8);
            writer.WriteStringValue(Environment.ToString());
            writer.WritePropertyName("sapProduct"u8);
            writer.WriteStringValue(SapProduct.ToString());
            writer.WritePropertyName("deploymentType"u8);
            writer.WriteStringValue(DeploymentType.ToString());
            writer.WritePropertyName("databaseType"u8);
            writer.WriteStringValue(DatabaseType.ToString());
            if (HighAvailabilityType.HasValue)
            {
                writer.WritePropertyName("highAvailabilityType"u8);
                writer.WriteStringValue(HighAvailabilityType.Value.ToString());
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

        SapSupportedSkusContent IJsonModel<SapSupportedSkusContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapSupportedSkusContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapSupportedSkusContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSapSupportedSkusContent(document.RootElement, options);
        }

        internal static SapSupportedSkusContent DeserializeSapSupportedSkusContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation appLocation = default;
            SapEnvironmentType environment = default;
            SapProductType sapProduct = default;
            SapDeploymentType deploymentType = default;
            SapDatabaseType databaseType = default;
            Optional<SapHighAvailabilityType> highAvailabilityType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appLocation"u8))
                {
                    appLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("environment"u8))
                {
                    environment = new SapEnvironmentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sapProduct"u8))
                {
                    sapProduct = new SapProductType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deploymentType"u8))
                {
                    deploymentType = new SapDeploymentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("databaseType"u8))
                {
                    databaseType = new SapDatabaseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("highAvailabilityType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    highAvailabilityType = new SapHighAvailabilityType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SapSupportedSkusContent(
                appLocation,
                environment,
                sapProduct,
                deploymentType,
                databaseType,
                Optional.ToNullable(highAvailabilityType),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SapSupportedSkusContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapSupportedSkusContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SapSupportedSkusContent)} does not support '{options.Format}' format.");
            }
        }

        SapSupportedSkusContent IPersistableModel<SapSupportedSkusContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapSupportedSkusContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSapSupportedSkusContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SapSupportedSkusContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SapSupportedSkusContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
