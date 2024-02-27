// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageAccountMicrosoftEndpoints : IUtf8JsonSerializable, IJsonModel<StorageAccountMicrosoftEndpoints>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageAccountMicrosoftEndpoints>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageAccountMicrosoftEndpoints>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountMicrosoftEndpoints>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageAccountMicrosoftEndpoints)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && BlobUri != null)
            {
                writer.WritePropertyName("blob"u8);
                writer.WriteStringValue(BlobUri.AbsoluteUri);
            }
            if (options.Format != "W" && QueueUri != null)
            {
                writer.WritePropertyName("queue"u8);
                writer.WriteStringValue(QueueUri.AbsoluteUri);
            }
            if (options.Format != "W" && TableUri != null)
            {
                writer.WritePropertyName("table"u8);
                writer.WriteStringValue(TableUri.AbsoluteUri);
            }
            if (options.Format != "W" && FileUri != null)
            {
                writer.WritePropertyName("file"u8);
                writer.WriteStringValue(FileUri.AbsoluteUri);
            }
            if (options.Format != "W" && WebUri != null)
            {
                writer.WritePropertyName("web"u8);
                writer.WriteStringValue(WebUri.AbsoluteUri);
            }
            if (options.Format != "W" && DfsUri != null)
            {
                writer.WritePropertyName("dfs"u8);
                writer.WriteStringValue(DfsUri.AbsoluteUri);
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

        StorageAccountMicrosoftEndpoints IJsonModel<StorageAccountMicrosoftEndpoints>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountMicrosoftEndpoints>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageAccountMicrosoftEndpoints)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageAccountMicrosoftEndpoints(document.RootElement, options);
        }

        internal static StorageAccountMicrosoftEndpoints DeserializeStorageAccountMicrosoftEndpoints(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> blob = default;
            Optional<Uri> queue = default;
            Optional<Uri> table = default;
            Optional<Uri> file = default;
            Optional<Uri> web = default;
            Optional<Uri> dfs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blob"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blob = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("queue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queue = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("table"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    table = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("file"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    file = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("web"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    web = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dfs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dfs = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageAccountMicrosoftEndpoints(
                blob.Value,
                queue.Value,
                table.Value,
                file.Value,
                web.Value,
                dfs.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageAccountMicrosoftEndpoints>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountMicrosoftEndpoints>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageAccountMicrosoftEndpoints)} does not support '{options.Format}' format.");
            }
        }

        StorageAccountMicrosoftEndpoints IPersistableModel<StorageAccountMicrosoftEndpoints>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountMicrosoftEndpoints>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageAccountMicrosoftEndpoints(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageAccountMicrosoftEndpoints)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageAccountMicrosoftEndpoints>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
