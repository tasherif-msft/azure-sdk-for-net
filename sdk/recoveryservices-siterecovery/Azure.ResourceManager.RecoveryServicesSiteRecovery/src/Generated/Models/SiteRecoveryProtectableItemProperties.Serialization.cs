// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryProtectableItemProperties : IUtf8JsonSerializable, IJsonModel<SiteRecoveryProtectableItemProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryProtectableItemProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteRecoveryProtectableItemProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryProtectableItemProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryProtectableItemProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (FriendlyName != null)
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (ProtectionStatus != null)
            {
                writer.WritePropertyName("protectionStatus"u8);
                writer.WriteStringValue(ProtectionStatus);
            }
            if (ReplicationProtectedItemId != null)
            {
                writer.WritePropertyName("replicationProtectedItemId"u8);
                writer.WriteStringValue(ReplicationProtectedItemId);
            }
            if (RecoveryServicesProviderId != null)
            {
                writer.WritePropertyName("recoveryServicesProviderId"u8);
                writer.WriteStringValue(RecoveryServicesProviderId);
            }
            if (!(ProtectionReadinessErrors is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("protectionReadinessErrors"u8);
                writer.WriteStartArray();
                foreach (var item in ProtectionReadinessErrors)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(SupportedReplicationProviders is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("supportedReplicationProviders"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedReplicationProviders)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (CustomDetails != null)
            {
                writer.WritePropertyName("customDetails"u8);
                writer.WriteObjectValue(CustomDetails);
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

        SiteRecoveryProtectableItemProperties IJsonModel<SiteRecoveryProtectableItemProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryProtectableItemProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryProtectableItemProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryProtectableItemProperties(document.RootElement, options);
        }

        internal static SiteRecoveryProtectableItemProperties DeserializeSiteRecoveryProtectableItemProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> friendlyName = default;
            Optional<string> protectionStatus = default;
            Optional<ResourceIdentifier> replicationProtectedItemId = default;
            Optional<ResourceIdentifier> recoveryServicesProviderId = default;
            IReadOnlyList<string> protectionReadinessErrors = default;
            IReadOnlyList<string> supportedReplicationProviders = default;
            Optional<SiteRecoveryReplicationProviderSettings> customDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionStatus"u8))
                {
                    protectionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replicationProtectedItemId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicationProtectedItemId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryServicesProviderId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryServicesProviderId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protectionReadinessErrors"u8))
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
                    protectionReadinessErrors = array;
                    continue;
                }
                if (property.NameEquals("supportedReplicationProviders"u8))
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
                    supportedReplicationProviders = array;
                    continue;
                }
                if (property.NameEquals("customDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customDetails = SiteRecoveryReplicationProviderSettings.DeserializeSiteRecoveryReplicationProviderSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoveryProtectableItemProperties(
                friendlyName.Value,
                protectionStatus.Value,
                replicationProtectedItemId.Value,
                recoveryServicesProviderId.Value,
                protectionReadinessErrors ?? new ChangeTrackingList<string>(),
                supportedReplicationProviders ?? new ChangeTrackingList<string>(),
                customDetails.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteRecoveryProtectableItemProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryProtectableItemProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryProtectableItemProperties)} does not support '{options.Format}' format.");
            }
        }

        SiteRecoveryProtectableItemProperties IPersistableModel<SiteRecoveryProtectableItemProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryProtectableItemProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryProtectableItemProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryProtectableItemProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryProtectableItemProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
