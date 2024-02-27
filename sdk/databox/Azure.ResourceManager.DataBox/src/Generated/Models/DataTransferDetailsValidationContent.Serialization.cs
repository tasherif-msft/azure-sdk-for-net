// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataTransferDetailsValidationContent : IUtf8JsonSerializable, IJsonModel<DataTransferDetailsValidationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataTransferDetailsValidationContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataTransferDetailsValidationContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataTransferDetailsValidationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataTransferDetailsValidationContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(DataExportDetails is ChangeTrackingList<DataExportDetails> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("dataExportDetails"u8);
                writer.WriteStartArray();
                foreach (var item in DataExportDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(DataImportDetails is ChangeTrackingList<DataImportDetails> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("dataImportDetails"u8);
                writer.WriteStartArray();
                foreach (var item in DataImportDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("deviceType"u8);
            writer.WriteStringValue(DeviceType.ToSerialString());
            writer.WritePropertyName("transferType"u8);
            writer.WriteStringValue(TransferType.ToSerialString());
            writer.WritePropertyName("validationType"u8);
            writer.WriteStringValue(ValidationType.ToSerialString());
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

        DataTransferDetailsValidationContent IJsonModel<DataTransferDetailsValidationContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataTransferDetailsValidationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataTransferDetailsValidationContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataTransferDetailsValidationContent(document.RootElement, options);
        }

        internal static DataTransferDetailsValidationContent DeserializeDataTransferDetailsValidationContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<DataExportDetails> dataExportDetails = default;
            IList<DataImportDetails> dataImportDetails = default;
            DataBoxSkuName deviceType = default;
            DataBoxJobTransferType transferType = default;
            DataBoxValidationInputDiscriminator validationType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataExportDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataExportDetails> array = new List<DataExportDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.DataExportDetails.DeserializeDataExportDetails(item, options));
                    }
                    dataExportDetails = array;
                    continue;
                }
                if (property.NameEquals("dataImportDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataImportDetails> array = new List<DataImportDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.DataImportDetails.DeserializeDataImportDetails(item, options));
                    }
                    dataImportDetails = array;
                    continue;
                }
                if (property.NameEquals("deviceType"u8))
                {
                    deviceType = property.Value.GetString().ToDataBoxSkuName();
                    continue;
                }
                if (property.NameEquals("transferType"u8))
                {
                    transferType = property.Value.GetString().ToDataBoxJobTransferType();
                    continue;
                }
                if (property.NameEquals("validationType"u8))
                {
                    validationType = property.Value.GetString().ToDataBoxValidationInputDiscriminator();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataTransferDetailsValidationContent(
                validationType,
                serializedAdditionalRawData,
                dataExportDetails ?? new ChangeTrackingList<DataExportDetails>(),
                dataImportDetails ?? new ChangeTrackingList<DataImportDetails>(),
                deviceType,
                transferType);
        }

        BinaryData IPersistableModel<DataTransferDetailsValidationContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataTransferDetailsValidationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataTransferDetailsValidationContent)} does not support '{options.Format}' format.");
            }
        }

        DataTransferDetailsValidationContent IPersistableModel<DataTransferDetailsValidationContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataTransferDetailsValidationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataTransferDetailsValidationContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataTransferDetailsValidationContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataTransferDetailsValidationContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
