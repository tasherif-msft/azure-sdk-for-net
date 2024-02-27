// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Hci.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci
{
    public partial class ArcExtensionData : IUtf8JsonSerializable, IJsonModel<ArcExtensionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArcExtensionData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ArcExtensionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArcExtensionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArcExtensionData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && AggregateState.HasValue)
            {
                writer.WritePropertyName("aggregateState"u8);
                writer.WriteStringValue(AggregateState.Value.ToString());
            }
            if (options.Format != "W" && !(PerNodeExtensionDetails is ChangeTrackingList<PerNodeExtensionState> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("perNodeExtensionDetails"u8);
                writer.WriteStartArray();
                foreach (var item in PerNodeExtensionDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("extensionParameters"u8);
            writer.WriteStartObject();
            if (ForceUpdateTag != null)
            {
                writer.WritePropertyName("forceUpdateTag"u8);
                writer.WriteStringValue(ForceUpdateTag);
            }
            if (Publisher != null)
            {
                writer.WritePropertyName("publisher"u8);
                writer.WriteStringValue(Publisher);
            }
            if (ArcExtensionType != null)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ArcExtensionType);
            }
            if (TypeHandlerVersion != null)
            {
                writer.WritePropertyName("typeHandlerVersion"u8);
                writer.WriteStringValue(TypeHandlerVersion);
            }
            if (ShouldAutoUpgradeMinorVersion.HasValue)
            {
                writer.WritePropertyName("autoUpgradeMinorVersion"u8);
                writer.WriteBooleanValue(ShouldAutoUpgradeMinorVersion.Value);
            }
            if (Settings != null)
            {
                writer.WritePropertyName("settings"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Settings);
#else
                using (JsonDocument document = JsonDocument.Parse(Settings))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (ProtectedSettings != null)
            {
                writer.WritePropertyName("protectedSettings"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ProtectedSettings);
#else
                using (JsonDocument document = JsonDocument.Parse(ProtectedSettings))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (EnableAutomaticUpgrade.HasValue)
            {
                writer.WritePropertyName("enableAutomaticUpgrade"u8);
                writer.WriteBooleanValue(EnableAutomaticUpgrade.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
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

        ArcExtensionData IJsonModel<ArcExtensionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArcExtensionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArcExtensionData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArcExtensionData(document.RootElement, options);
        }

        internal static ArcExtensionData DeserializeArcExtensionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<HciProvisioningState> provisioningState = default;
            Optional<ArcExtensionAggregateState> aggregateState = default;
            IReadOnlyList<PerNodeExtensionState> perNodeExtensionDetails = default;
            Optional<string> forceUpdateTag = default;
            Optional<string> publisher = default;
            Optional<string> type0 = default;
            Optional<string> typeHandlerVersion = default;
            Optional<bool> autoUpgradeMinorVersion = default;
            Optional<BinaryData> settings = default;
            Optional<BinaryData> protectedSettings = default;
            Optional<bool> enableAutomaticUpgrade = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new HciProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("aggregateState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aggregateState = new ArcExtensionAggregateState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("perNodeExtensionDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PerNodeExtensionState> array = new List<PerNodeExtensionState>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PerNodeExtensionState.DeserializePerNodeExtensionState(item, options));
                            }
                            perNodeExtensionDetails = array;
                            continue;
                        }
                        if (property0.NameEquals("extensionParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.NameEquals("forceUpdateTag"u8))
                                {
                                    forceUpdateTag = property1.Value.GetString();
                                    continue;
                                }
                                if (property1.NameEquals("publisher"u8))
                                {
                                    publisher = property1.Value.GetString();
                                    continue;
                                }
                                if (property1.NameEquals("type"u8))
                                {
                                    type0 = property1.Value.GetString();
                                    continue;
                                }
                                if (property1.NameEquals("typeHandlerVersion"u8))
                                {
                                    typeHandlerVersion = property1.Value.GetString();
                                    continue;
                                }
                                if (property1.NameEquals("autoUpgradeMinorVersion"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    autoUpgradeMinorVersion = property1.Value.GetBoolean();
                                    continue;
                                }
                                if (property1.NameEquals("settings"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    settings = BinaryData.FromString(property1.Value.GetRawText());
                                    continue;
                                }
                                if (property1.NameEquals("protectedSettings"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    protectedSettings = BinaryData.FromString(property1.Value.GetRawText());
                                    continue;
                                }
                                if (property1.NameEquals("enableAutomaticUpgrade"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    enableAutomaticUpgrade = property1.Value.GetBoolean();
                                    continue;
                                }
                            }
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ArcExtensionData(
                id,
                name,
                type,
                systemData.Value,
                Optional.ToNullable(provisioningState),
                Optional.ToNullable(aggregateState),
                perNodeExtensionDetails ?? new ChangeTrackingList<PerNodeExtensionState>(),
                forceUpdateTag.Value,
                publisher.Value,
                type0.Value,
                typeHandlerVersion.Value,
                Optional.ToNullable(autoUpgradeMinorVersion),
                settings.Value,
                protectedSettings.Value,
                Optional.ToNullable(enableAutomaticUpgrade),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ArcExtensionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArcExtensionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ArcExtensionData)} does not support '{options.Format}' format.");
            }
        }

        ArcExtensionData IPersistableModel<ArcExtensionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArcExtensionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeArcExtensionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ArcExtensionData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ArcExtensionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
