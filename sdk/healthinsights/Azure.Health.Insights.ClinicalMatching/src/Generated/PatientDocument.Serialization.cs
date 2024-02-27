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

namespace Azure.Health.Insights.ClinicalMatching
{
    public partial class PatientDocument : IUtf8JsonSerializable, IJsonModel<PatientDocument>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PatientDocument>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PatientDocument>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PatientDocument>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PatientDocument)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            if (ClinicalType.HasValue)
            {
                writer.WritePropertyName("clinicalType"u8);
                writer.WriteStringValue(ClinicalType.Value.ToString());
            }
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Language != null)
            {
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(Language);
            }
            if (CreatedDateTime.HasValue)
            {
                writer.WritePropertyName("createdDateTime"u8);
                writer.WriteStringValue(CreatedDateTime.Value, "O");
            }
            writer.WritePropertyName("content"u8);
            writer.WriteObjectValue(Content);
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

        PatientDocument IJsonModel<PatientDocument>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PatientDocument>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PatientDocument)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePatientDocument(document.RootElement, options);
        }

        internal static PatientDocument DeserializePatientDocument(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DocumentType type = default;
            Optional<ClinicalDocumentType> clinicalType = default;
            string id = default;
            Optional<string> language = default;
            Optional<DateTimeOffset> createdDateTime = default;
            DocumentContent content = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new DocumentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("clinicalType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clinicalType = new ClinicalDocumentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("language"u8))
                {
                    language = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("content"u8))
                {
                    content = DocumentContent.DeserializeDocumentContent(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PatientDocument(
                type,
                Optional.ToNullable(clinicalType),
                id,
                language.Value,
                Optional.ToNullable(createdDateTime),
                content,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PatientDocument>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PatientDocument>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PatientDocument)} does not support '{options.Format}' format.");
            }
        }

        PatientDocument IPersistableModel<PatientDocument>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PatientDocument>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePatientDocument(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PatientDocument)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PatientDocument>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static PatientDocument FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializePatientDocument(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
