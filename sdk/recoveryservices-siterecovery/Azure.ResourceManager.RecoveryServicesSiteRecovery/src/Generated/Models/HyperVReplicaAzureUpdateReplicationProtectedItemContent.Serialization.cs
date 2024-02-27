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
    public partial class HyperVReplicaAzureUpdateReplicationProtectedItemContent : IUtf8JsonSerializable, IJsonModel<HyperVReplicaAzureUpdateReplicationProtectedItemContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HyperVReplicaAzureUpdateReplicationProtectedItemContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HyperVReplicaAzureUpdateReplicationProtectedItemContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaAzureUpdateReplicationProtectedItemContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HyperVReplicaAzureUpdateReplicationProtectedItemContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (RecoveryAzureV1ResourceGroupId != null)
            {
                writer.WritePropertyName("recoveryAzureV1ResourceGroupId"u8);
                writer.WriteStringValue(RecoveryAzureV1ResourceGroupId);
            }
            if (RecoveryAzureV2ResourceGroupId != null)
            {
                writer.WritePropertyName("recoveryAzureV2ResourceGroupId"u8);
                writer.WriteStringValue(RecoveryAzureV2ResourceGroupId);
            }
            if (UseManagedDisks != null)
            {
                writer.WritePropertyName("useManagedDisks"u8);
                writer.WriteStringValue(UseManagedDisks);
            }
            if (!(DiskIdToDiskEncryptionMap is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("diskIdToDiskEncryptionMap"u8);
                writer.WriteStartObject();
                foreach (var item in DiskIdToDiskEncryptionMap)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (TargetProximityPlacementGroupId != null)
            {
                writer.WritePropertyName("targetProximityPlacementGroupId"u8);
                writer.WriteStringValue(TargetProximityPlacementGroupId);
            }
            if (TargetAvailabilityZone != null)
            {
                writer.WritePropertyName("targetAvailabilityZone"u8);
                writer.WriteStringValue(TargetAvailabilityZone);
            }
            if (!(TargetVmTags is ChangeTrackingDictionary<string, string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("targetVmTags"u8);
                writer.WriteStartObject();
                foreach (var item in TargetVmTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(TargetManagedDiskTags is ChangeTrackingDictionary<string, string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("targetManagedDiskTags"u8);
                writer.WriteStartObject();
                foreach (var item in TargetManagedDiskTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(TargetNicTags is ChangeTrackingDictionary<string, string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("targetNicTags"u8);
                writer.WriteStartObject();
                foreach (var item in TargetNicTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (SqlServerLicenseType.HasValue)
            {
                writer.WritePropertyName("sqlServerLicenseType"u8);
                writer.WriteStringValue(SqlServerLicenseType.Value.ToString());
            }
            if (!(VmDisks is ChangeTrackingList<UpdateDiskContent> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("vmDisks"u8);
                writer.WriteStartArray();
                foreach (var item in VmDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        HyperVReplicaAzureUpdateReplicationProtectedItemContent IJsonModel<HyperVReplicaAzureUpdateReplicationProtectedItemContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaAzureUpdateReplicationProtectedItemContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HyperVReplicaAzureUpdateReplicationProtectedItemContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHyperVReplicaAzureUpdateReplicationProtectedItemContent(document.RootElement, options);
        }

        internal static HyperVReplicaAzureUpdateReplicationProtectedItemContent DeserializeHyperVReplicaAzureUpdateReplicationProtectedItemContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> recoveryAzureV1ResourceGroupId = default;
            Optional<ResourceIdentifier> recoveryAzureV2ResourceGroupId = default;
            Optional<string> useManagedDisks = default;
            IDictionary<string, string> diskIdToDiskEncryptionMap = default;
            Optional<ResourceIdentifier> targetProximityPlacementGroupId = default;
            Optional<string> targetAvailabilityZone = default;
            IDictionary<string, string> targetVmTags = default;
            IDictionary<string, string> targetManagedDiskTags = default;
            IDictionary<string, string> targetNicTags = default;
            Optional<SiteRecoverySqlServerLicenseType> sqlServerLicenseType = default;
            IList<UpdateDiskContent> vmDisks = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryAzureV1ResourceGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryAzureV1ResourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryAzureV2ResourceGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryAzureV2ResourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("useManagedDisks"u8))
                {
                    useManagedDisks = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskIdToDiskEncryptionMap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    diskIdToDiskEncryptionMap = dictionary;
                    continue;
                }
                if (property.NameEquals("targetProximityPlacementGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetProximityPlacementGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetAvailabilityZone"u8))
                {
                    targetAvailabilityZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetVmTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    targetVmTags = dictionary;
                    continue;
                }
                if (property.NameEquals("targetManagedDiskTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    targetManagedDiskTags = dictionary;
                    continue;
                }
                if (property.NameEquals("targetNicTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    targetNicTags = dictionary;
                    continue;
                }
                if (property.NameEquals("sqlServerLicenseType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlServerLicenseType = new SiteRecoverySqlServerLicenseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vmDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UpdateDiskContent> array = new List<UpdateDiskContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UpdateDiskContent.DeserializeUpdateDiskContent(item, options));
                    }
                    vmDisks = array;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HyperVReplicaAzureUpdateReplicationProtectedItemContent(
                instanceType,
                serializedAdditionalRawData,
                recoveryAzureV1ResourceGroupId.Value,
                recoveryAzureV2ResourceGroupId.Value,
                useManagedDisks.Value,
                diskIdToDiskEncryptionMap ?? new ChangeTrackingDictionary<string, string>(),
                targetProximityPlacementGroupId.Value,
                targetAvailabilityZone.Value,
                targetVmTags ?? new ChangeTrackingDictionary<string, string>(),
                targetManagedDiskTags ?? new ChangeTrackingDictionary<string, string>(),
                targetNicTags ?? new ChangeTrackingDictionary<string, string>(),
                Optional.ToNullable(sqlServerLicenseType),
                vmDisks ?? new ChangeTrackingList<UpdateDiskContent>());
        }

        BinaryData IPersistableModel<HyperVReplicaAzureUpdateReplicationProtectedItemContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaAzureUpdateReplicationProtectedItemContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HyperVReplicaAzureUpdateReplicationProtectedItemContent)} does not support '{options.Format}' format.");
            }
        }

        HyperVReplicaAzureUpdateReplicationProtectedItemContent IPersistableModel<HyperVReplicaAzureUpdateReplicationProtectedItemContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaAzureUpdateReplicationProtectedItemContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHyperVReplicaAzureUpdateReplicationProtectedItemContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HyperVReplicaAzureUpdateReplicationProtectedItemContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HyperVReplicaAzureUpdateReplicationProtectedItemContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
