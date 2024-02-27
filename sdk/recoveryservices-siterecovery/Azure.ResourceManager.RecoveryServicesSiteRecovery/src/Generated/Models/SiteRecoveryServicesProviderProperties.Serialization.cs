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
    public partial class SiteRecoveryServicesProviderProperties : IUtf8JsonSerializable, IJsonModel<SiteRecoveryServicesProviderProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryServicesProviderProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteRecoveryServicesProviderProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryServicesProviderProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryServicesProviderProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (FabricType != null)
            {
                writer.WritePropertyName("fabricType"u8);
                writer.WriteStringValue(FabricType);
            }
            if (FriendlyName != null)
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (ProviderVersion != null)
            {
                writer.WritePropertyName("providerVersion"u8);
                writer.WriteStringValue(ProviderVersion);
            }
            if (ServerVersion != null)
            {
                writer.WritePropertyName("serverVersion"u8);
                writer.WriteStringValue(ServerVersion);
            }
            if (ProviderVersionState != null)
            {
                writer.WritePropertyName("providerVersionState"u8);
                writer.WriteStringValue(ProviderVersionState);
            }
            if (ProviderVersionExpireOn.HasValue)
            {
                writer.WritePropertyName("providerVersionExpiryDate"u8);
                writer.WriteStringValue(ProviderVersionExpireOn.Value, "O");
            }
            if (FabricFriendlyName != null)
            {
                writer.WritePropertyName("fabricFriendlyName"u8);
                writer.WriteStringValue(FabricFriendlyName);
            }
            if (LastHeartbeatReceivedOn.HasValue)
            {
                writer.WritePropertyName("lastHeartBeat"u8);
                writer.WriteStringValue(LastHeartbeatReceivedOn.Value, "O");
            }
            if (ConnectionStatus != null)
            {
                writer.WritePropertyName("connectionStatus"u8);
                writer.WriteStringValue(ConnectionStatus);
            }
            if (ProtectedItemCount.HasValue)
            {
                writer.WritePropertyName("protectedItemCount"u8);
                writer.WriteNumberValue(ProtectedItemCount.Value);
            }
            if (!(AllowedScenarios is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("allowedScenarios"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedScenarios)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(HealthErrorDetails is ChangeTrackingList<SiteRecoveryHealthError> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("healthErrorDetails"u8);
                writer.WriteStartArray();
                foreach (var item in HealthErrorDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (DraIdentifier != null)
            {
                writer.WritePropertyName("draIdentifier"u8);
                writer.WriteStringValue(DraIdentifier);
            }
            if (MachineId != null)
            {
                writer.WritePropertyName("machineId"u8);
                writer.WriteStringValue(MachineId);
            }
            if (MachineName != null)
            {
                writer.WritePropertyName("machineName"u8);
                writer.WriteStringValue(MachineName);
            }
            if (BiosId != null)
            {
                writer.WritePropertyName("biosId"u8);
                writer.WriteStringValue(BiosId);
            }
            if (AuthenticationIdentityDetails != null)
            {
                writer.WritePropertyName("authenticationIdentityDetails"u8);
                writer.WriteObjectValue(AuthenticationIdentityDetails);
            }
            if (ResourceAccessIdentityDetails != null)
            {
                writer.WritePropertyName("resourceAccessIdentityDetails"u8);
                writer.WriteObjectValue(ResourceAccessIdentityDetails);
            }
            if (DataPlaneAuthenticationIdentityDetails != null)
            {
                writer.WritePropertyName("dataPlaneAuthenticationIdentityDetails"u8);
                writer.WriteObjectValue(DataPlaneAuthenticationIdentityDetails);
            }
            if (ProviderVersionDetails != null)
            {
                writer.WritePropertyName("providerVersionDetails"u8);
                writer.WriteObjectValue(ProviderVersionDetails);
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

        SiteRecoveryServicesProviderProperties IJsonModel<SiteRecoveryServicesProviderProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryServicesProviderProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryServicesProviderProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryServicesProviderProperties(document.RootElement, options);
        }

        internal static SiteRecoveryServicesProviderProperties DeserializeSiteRecoveryServicesProviderProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> fabricType = default;
            Optional<string> friendlyName = default;
            Optional<string> providerVersion = default;
            Optional<string> serverVersion = default;
            Optional<string> providerVersionState = default;
            Optional<DateTimeOffset> providerVersionExpireOn = default;
            Optional<string> fabricFriendlyName = default;
            Optional<DateTimeOffset> lastHeartBeat = default;
            Optional<string> connectionStatus = default;
            Optional<int> protectedItemCount = default;
            IReadOnlyList<string> allowedScenarios = default;
            IReadOnlyList<SiteRecoveryHealthError> healthErrorDetails = default;
            Optional<string> draIdentifier = default;
            Optional<string> machineId = default;
            Optional<string> machineName = default;
            Optional<string> biosId = default;
            Optional<IdentityProviderDetails> authenticationIdentityDetails = default;
            Optional<IdentityProviderDetails> resourceAccessIdentityDetails = default;
            Optional<IdentityProviderDetails> dataPlaneAuthenticationIdentityDetails = default;
            Optional<SiteRecoveryVersionDetails> providerVersionDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fabricType"u8))
                {
                    fabricType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerVersion"u8))
                {
                    providerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverVersion"u8))
                {
                    serverVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerVersionState"u8))
                {
                    providerVersionState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerVersionExpiryDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerVersionExpireOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("fabricFriendlyName"u8))
                {
                    fabricFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastHeartBeat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastHeartBeat = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("connectionStatus"u8))
                {
                    connectionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedItemCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectedItemCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allowedScenarios"u8))
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
                    allowedScenarios = array;
                    continue;
                }
                if (property.NameEquals("healthErrorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryHealthError> array = new List<SiteRecoveryHealthError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryHealthError.DeserializeSiteRecoveryHealthError(item, options));
                    }
                    healthErrorDetails = array;
                    continue;
                }
                if (property.NameEquals("draIdentifier"u8))
                {
                    draIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("machineId"u8))
                {
                    machineId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("machineName"u8))
                {
                    machineName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("biosId"u8))
                {
                    biosId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authenticationIdentityDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationIdentityDetails = IdentityProviderDetails.DeserializeIdentityProviderDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("resourceAccessIdentityDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceAccessIdentityDetails = IdentityProviderDetails.DeserializeIdentityProviderDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dataPlaneAuthenticationIdentityDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataPlaneAuthenticationIdentityDetails = IdentityProviderDetails.DeserializeIdentityProviderDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("providerVersionDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerVersionDetails = SiteRecoveryVersionDetails.DeserializeSiteRecoveryVersionDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoveryServicesProviderProperties(
                fabricType.Value,
                friendlyName.Value,
                providerVersion.Value,
                serverVersion.Value,
                providerVersionState.Value,
                Optional.ToNullable(providerVersionExpireOn),
                fabricFriendlyName.Value,
                Optional.ToNullable(lastHeartBeat),
                connectionStatus.Value,
                Optional.ToNullable(protectedItemCount),
                allowedScenarios ?? new ChangeTrackingList<string>(),
                healthErrorDetails ?? new ChangeTrackingList<SiteRecoveryHealthError>(),
                draIdentifier.Value,
                machineId.Value,
                machineName.Value,
                biosId.Value,
                authenticationIdentityDetails.Value,
                resourceAccessIdentityDetails.Value,
                dataPlaneAuthenticationIdentityDetails.Value,
                providerVersionDetails.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteRecoveryServicesProviderProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryServicesProviderProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryServicesProviderProperties)} does not support '{options.Format}' format.");
            }
        }

        SiteRecoveryServicesProviderProperties IPersistableModel<SiteRecoveryServicesProviderProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryServicesProviderProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryServicesProviderProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryServicesProviderProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryServicesProviderProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
