// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class ConfigServerGitPatternRepository : IUtf8JsonSerializable, IJsonModel<ConfigServerGitPatternRepository>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConfigServerGitPatternRepository>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConfigServerGitPatternRepository>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigServerGitPatternRepository>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfigServerGitPatternRepository)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (!(Pattern is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("pattern"u8);
                writer.WriteStartArray();
                foreach (var item in Pattern)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("uri"u8);
            writer.WriteStringValue(Uri.AbsoluteUri);
            if (Label != null)
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
            }
            if (!(SearchPaths is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("searchPaths"u8);
                writer.WriteStartArray();
                foreach (var item in SearchPaths)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Username != null)
            {
                writer.WritePropertyName("username"u8);
                writer.WriteStringValue(Username);
            }
            if (Password != null)
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (HostKey != null)
            {
                writer.WritePropertyName("hostKey"u8);
                writer.WriteStringValue(HostKey);
            }
            if (HostKeyAlgorithm != null)
            {
                writer.WritePropertyName("hostKeyAlgorithm"u8);
                writer.WriteStringValue(HostKeyAlgorithm);
            }
            if (PrivateKey != null)
            {
                writer.WritePropertyName("privateKey"u8);
                writer.WriteStringValue(PrivateKey);
            }
            if (IsHostKeyCheckingStrict.HasValue)
            {
                writer.WritePropertyName("strictHostKeyChecking"u8);
                writer.WriteBooleanValue(IsHostKeyCheckingStrict.Value);
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

        ConfigServerGitPatternRepository IJsonModel<ConfigServerGitPatternRepository>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigServerGitPatternRepository>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfigServerGitPatternRepository)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConfigServerGitPatternRepository(document.RootElement, options);
        }

        internal static ConfigServerGitPatternRepository DeserializeConfigServerGitPatternRepository(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IList<string> pattern = default;
            Uri uri = default;
            Optional<string> label = default;
            IList<string> searchPaths = default;
            Optional<string> username = default;
            Optional<string> password = default;
            Optional<string> hostKey = default;
            Optional<string> hostKeyAlgorithm = default;
            Optional<string> privateKey = default;
            Optional<bool> strictHostKeyChecking = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pattern"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    pattern = array;
                    continue;
                }
                if (property.NameEquals("uri"u8))
                {
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("searchPaths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    searchPaths = array;
                    continue;
                }
                if (property.NameEquals("username"u8))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostKey"u8))
                {
                    hostKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostKeyAlgorithm"u8))
                {
                    hostKeyAlgorithm = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateKey"u8))
                {
                    privateKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("strictHostKeyChecking"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    strictHostKeyChecking = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConfigServerGitPatternRepository(
                name,
                pattern ?? new ChangeTrackingList<string>(),
                uri,
                label.Value,
                searchPaths ?? new ChangeTrackingList<string>(),
                username.Value,
                password.Value,
                hostKey.Value,
                hostKeyAlgorithm.Value,
                privateKey.Value,
                Optional.ToNullable(strictHostKeyChecking),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConfigServerGitPatternRepository>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigServerGitPatternRepository>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConfigServerGitPatternRepository)} does not support '{options.Format}' format.");
            }
        }

        ConfigServerGitPatternRepository IPersistableModel<ConfigServerGitPatternRepository>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigServerGitPatternRepository>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConfigServerGitPatternRepository(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConfigServerGitPatternRepository)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConfigServerGitPatternRepository>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
