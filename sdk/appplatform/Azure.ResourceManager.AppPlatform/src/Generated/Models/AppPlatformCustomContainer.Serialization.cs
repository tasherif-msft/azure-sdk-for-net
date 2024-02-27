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
    public partial class AppPlatformCustomContainer : IUtf8JsonSerializable, IJsonModel<AppPlatformCustomContainer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformCustomContainer>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppPlatformCustomContainer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformCustomContainer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformCustomContainer)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Server != null)
            {
                writer.WritePropertyName("server"u8);
                writer.WriteStringValue(Server);
            }
            if (ContainerImage != null)
            {
                writer.WritePropertyName("containerImage"u8);
                writer.WriteStringValue(ContainerImage);
            }
            if (!(Command is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("command"u8);
                writer.WriteStartArray();
                foreach (var item in Command)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Args is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("args"u8);
                writer.WriteStartArray();
                foreach (var item in Args)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (ImageRegistryCredential != null)
            {
                writer.WritePropertyName("imageRegistryCredential"u8);
                writer.WriteObjectValue(ImageRegistryCredential);
            }
            if (LanguageFramework != null)
            {
                writer.WritePropertyName("languageFramework"u8);
                writer.WriteStringValue(LanguageFramework);
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

        AppPlatformCustomContainer IJsonModel<AppPlatformCustomContainer>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformCustomContainer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformCustomContainer)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformCustomContainer(document.RootElement, options);
        }

        internal static AppPlatformCustomContainer DeserializeAppPlatformCustomContainer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> server = default;
            Optional<string> containerImage = default;
            IList<string> command = default;
            IList<string> args = default;
            Optional<AppPlatformImageRegistryCredential> imageRegistryCredential = default;
            Optional<string> languageFramework = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("server"u8))
                {
                    server = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerImage"u8))
                {
                    containerImage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("command"u8))
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
                    command = array;
                    continue;
                }
                if (property.NameEquals("args"u8))
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
                    args = array;
                    continue;
                }
                if (property.NameEquals("imageRegistryCredential"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageRegistryCredential = AppPlatformImageRegistryCredential.DeserializeAppPlatformImageRegistryCredential(property.Value, options);
                    continue;
                }
                if (property.NameEquals("languageFramework"u8))
                {
                    languageFramework = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppPlatformCustomContainer(
                server.Value,
                containerImage.Value,
                command ?? new ChangeTrackingList<string>(),
                args ?? new ChangeTrackingList<string>(),
                imageRegistryCredential.Value,
                languageFramework.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppPlatformCustomContainer>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformCustomContainer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformCustomContainer)} does not support '{options.Format}' format.");
            }
        }

        AppPlatformCustomContainer IPersistableModel<AppPlatformCustomContainer>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformCustomContainer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppPlatformCustomContainer(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformCustomContainer)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformCustomContainer>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
