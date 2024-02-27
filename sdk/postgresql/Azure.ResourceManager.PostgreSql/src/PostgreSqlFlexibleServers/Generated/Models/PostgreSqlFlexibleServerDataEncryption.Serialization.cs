// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlFlexibleServerDataEncryption : IUtf8JsonSerializable, IJsonModel<PostgreSqlFlexibleServerDataEncryption>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlFlexibleServerDataEncryption>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PostgreSqlFlexibleServerDataEncryption>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerDataEncryption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerDataEncryption)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (PrimaryKeyUri != null)
            {
                writer.WritePropertyName("primaryKeyURI"u8);
                writer.WriteStringValue(PrimaryKeyUri.AbsoluteUri);
            }
            if (PrimaryUserAssignedIdentityId != null)
            {
                writer.WritePropertyName("primaryUserAssignedIdentityId"u8);
                writer.WriteStringValue(PrimaryUserAssignedIdentityId);
            }
            if (GeoBackupKeyUri != null)
            {
                writer.WritePropertyName("geoBackupKeyURI"u8);
                writer.WriteStringValue(GeoBackupKeyUri.AbsoluteUri);
            }
            if (GeoBackupUserAssignedIdentityId != null)
            {
                writer.WritePropertyName("geoBackupUserAssignedIdentityId"u8);
                writer.WriteStringValue(GeoBackupUserAssignedIdentityId);
            }
            if (KeyType.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(KeyType.Value.ToString());
            }
            if (PrimaryEncryptionKeyStatus.HasValue)
            {
                writer.WritePropertyName("primaryEncryptionKeyStatus"u8);
                writer.WriteStringValue(PrimaryEncryptionKeyStatus.Value.ToString());
            }
            if (GeoBackupEncryptionKeyStatus.HasValue)
            {
                writer.WritePropertyName("geoBackupEncryptionKeyStatus"u8);
                writer.WriteStringValue(GeoBackupEncryptionKeyStatus.Value.ToString());
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

        PostgreSqlFlexibleServerDataEncryption IJsonModel<PostgreSqlFlexibleServerDataEncryption>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerDataEncryption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerDataEncryption)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlFlexibleServerDataEncryption(document.RootElement, options);
        }

        internal static PostgreSqlFlexibleServerDataEncryption DeserializePostgreSqlFlexibleServerDataEncryption(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> primaryKeyUri = default;
            Optional<ResourceIdentifier> primaryUserAssignedIdentityId = default;
            Optional<Uri> geoBackupKeyUri = default;
            Optional<string> geoBackupUserAssignedIdentityId = default;
            Optional<PostgreSqlFlexibleServerKeyType> type = default;
            Optional<PostgreSqlKeyStatus> primaryEncryptionKeyStatus = default;
            Optional<PostgreSqlKeyStatus> geoBackupEncryptionKeyStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryKeyURI"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryKeyUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryUserAssignedIdentityId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryUserAssignedIdentityId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("geoBackupKeyURI"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    geoBackupKeyUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("geoBackupUserAssignedIdentityId"u8))
                {
                    geoBackupUserAssignedIdentityId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new PostgreSqlFlexibleServerKeyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryEncryptionKeyStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryEncryptionKeyStatus = new PostgreSqlKeyStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("geoBackupEncryptionKeyStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    geoBackupEncryptionKeyStatus = new PostgreSqlKeyStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PostgreSqlFlexibleServerDataEncryption(
                primaryKeyUri.Value,
                primaryUserAssignedIdentityId.Value,
                geoBackupKeyUri.Value,
                geoBackupUserAssignedIdentityId.Value,
                Optional.ToNullable(type),
                Optional.ToNullable(primaryEncryptionKeyStatus),
                Optional.ToNullable(geoBackupEncryptionKeyStatus),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PostgreSqlFlexibleServerDataEncryption>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerDataEncryption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerDataEncryption)} does not support '{options.Format}' format.");
            }
        }

        PostgreSqlFlexibleServerDataEncryption IPersistableModel<PostgreSqlFlexibleServerDataEncryption>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerDataEncryption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePostgreSqlFlexibleServerDataEncryption(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerDataEncryption)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PostgreSqlFlexibleServerDataEncryption>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
