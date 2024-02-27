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
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class VpnConnectionData : IUtf8JsonSerializable, IJsonModel<VpnConnectionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VpnConnectionData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VpnConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnConnectionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnConnectionData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ETag.HasValue)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && ResourceType.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (RemoteVpnSite != null)
            {
                writer.WritePropertyName("remoteVpnSite"u8);
                JsonSerializer.Serialize(writer, RemoteVpnSite);
            }
            if (RoutingWeight.HasValue)
            {
                writer.WritePropertyName("routingWeight"u8);
                writer.WriteNumberValue(RoutingWeight.Value);
            }
            if (DpdTimeoutSeconds.HasValue)
            {
                writer.WritePropertyName("dpdTimeoutSeconds"u8);
                writer.WriteNumberValue(DpdTimeoutSeconds.Value);
            }
            if (options.Format != "W" && ConnectionStatus.HasValue)
            {
                writer.WritePropertyName("connectionStatus"u8);
                writer.WriteStringValue(ConnectionStatus.Value.ToString());
            }
            if (VpnConnectionProtocolType.HasValue)
            {
                writer.WritePropertyName("vpnConnectionProtocolType"u8);
                writer.WriteStringValue(VpnConnectionProtocolType.Value.ToString());
            }
            if (options.Format != "W" && IngressBytesTransferred.HasValue)
            {
                writer.WritePropertyName("ingressBytesTransferred"u8);
                writer.WriteNumberValue(IngressBytesTransferred.Value);
            }
            if (options.Format != "W" && EgressBytesTransferred.HasValue)
            {
                writer.WritePropertyName("egressBytesTransferred"u8);
                writer.WriteNumberValue(EgressBytesTransferred.Value);
            }
            if (ConnectionBandwidth.HasValue)
            {
                writer.WritePropertyName("connectionBandwidth"u8);
                writer.WriteNumberValue(ConnectionBandwidth.Value);
            }
            if (SharedKey != null)
            {
                writer.WritePropertyName("sharedKey"u8);
                writer.WriteStringValue(SharedKey);
            }
            if (EnableBgp.HasValue)
            {
                writer.WritePropertyName("enableBgp"u8);
                writer.WriteBooleanValue(EnableBgp.Value);
            }
            if (UsePolicyBasedTrafficSelectors.HasValue)
            {
                writer.WritePropertyName("usePolicyBasedTrafficSelectors"u8);
                writer.WriteBooleanValue(UsePolicyBasedTrafficSelectors.Value);
            }
            if (!(IPsecPolicies is ChangeTrackingList<IPsecPolicy> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("ipsecPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in IPsecPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(TrafficSelectorPolicies is ChangeTrackingList<TrafficSelectorPolicy> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("trafficSelectorPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in TrafficSelectorPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (EnableRateLimiting.HasValue)
            {
                writer.WritePropertyName("enableRateLimiting"u8);
                writer.WriteBooleanValue(EnableRateLimiting.Value);
            }
            if (EnableInternetSecurity.HasValue)
            {
                writer.WritePropertyName("enableInternetSecurity"u8);
                writer.WriteBooleanValue(EnableInternetSecurity.Value);
            }
            if (UseLocalAzureIPAddress.HasValue)
            {
                writer.WritePropertyName("useLocalAzureIpAddress"u8);
                writer.WriteBooleanValue(UseLocalAzureIPAddress.Value);
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (!(VpnLinkConnections is ChangeTrackingList<VpnSiteLinkConnectionData> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("vpnLinkConnections"u8);
                writer.WriteStartArray();
                foreach (var item in VpnLinkConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (RoutingConfiguration != null)
            {
                writer.WritePropertyName("routingConfiguration"u8);
                writer.WriteObjectValue(RoutingConfiguration);
            }
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

        VpnConnectionData IJsonModel<VpnConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnConnectionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnConnectionData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVpnConnectionData(document.RootElement, options);
        }

        internal static VpnConnectionData DeserializeVpnConnectionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<WritableSubResource> remoteVpnSite = default;
            Optional<int> routingWeight = default;
            Optional<int> dpdTimeoutSeconds = default;
            Optional<VpnConnectionStatus> connectionStatus = default;
            Optional<VirtualNetworkGatewayConnectionProtocol> vpnConnectionProtocolType = default;
            Optional<long> ingressBytesTransferred = default;
            Optional<long> egressBytesTransferred = default;
            Optional<int> connectionBandwidth = default;
            Optional<string> sharedKey = default;
            Optional<bool> enableBgp = default;
            Optional<bool> usePolicyBasedTrafficSelectors = default;
            IList<IPsecPolicy> ipsecPolicies = default;
            IList<TrafficSelectorPolicy> trafficSelectorPolicies = default;
            Optional<bool> enableRateLimiting = default;
            Optional<bool> enableInternetSecurity = default;
            Optional<bool> useLocalAzureIPAddress = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            IList<VpnSiteLinkConnectionData> vpnLinkConnections = default;
            Optional<RoutingConfiguration> routingConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("remoteVpnSite"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            remoteVpnSite = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("routingWeight"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routingWeight = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("dpdTimeoutSeconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dpdTimeoutSeconds = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("connectionStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionStatus = new VpnConnectionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vpnConnectionProtocolType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vpnConnectionProtocolType = new VirtualNetworkGatewayConnectionProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ingressBytesTransferred"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ingressBytesTransferred = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("egressBytesTransferred"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            egressBytesTransferred = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("connectionBandwidth"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionBandwidth = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("sharedKey"u8))
                        {
                            sharedKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enableBgp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableBgp = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("usePolicyBasedTrafficSelectors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            usePolicyBasedTrafficSelectors = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("ipsecPolicies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IPsecPolicy> array = new List<IPsecPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IPsecPolicy.DeserializeIPsecPolicy(item, options));
                            }
                            ipsecPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("trafficSelectorPolicies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<TrafficSelectorPolicy> array = new List<TrafficSelectorPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TrafficSelectorPolicy.DeserializeTrafficSelectorPolicy(item, options));
                            }
                            trafficSelectorPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("enableRateLimiting"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableRateLimiting = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableInternetSecurity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableInternetSecurity = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("useLocalAzureIpAddress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            useLocalAzureIPAddress = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vpnLinkConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VpnSiteLinkConnectionData> array = new List<VpnSiteLinkConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnSiteLinkConnectionData.DeserializeVpnSiteLinkConnectionData(item, options));
                            }
                            vpnLinkConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("routingConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routingConfiguration = RoutingConfiguration.DeserializeRoutingConfiguration(property0.Value, options);
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
            return new VpnConnectionData(
                id.Value,
                name.Value,
                Optional.ToNullable(type),
                serializedAdditionalRawData,
                Optional.ToNullable(etag),
                remoteVpnSite,
                Optional.ToNullable(routingWeight),
                Optional.ToNullable(dpdTimeoutSeconds),
                Optional.ToNullable(connectionStatus),
                Optional.ToNullable(vpnConnectionProtocolType),
                Optional.ToNullable(ingressBytesTransferred),
                Optional.ToNullable(egressBytesTransferred),
                Optional.ToNullable(connectionBandwidth),
                sharedKey.Value,
                Optional.ToNullable(enableBgp),
                Optional.ToNullable(usePolicyBasedTrafficSelectors),
                ipsecPolicies ?? new ChangeTrackingList<IPsecPolicy>(),
                trafficSelectorPolicies ?? new ChangeTrackingList<TrafficSelectorPolicy>(),
                Optional.ToNullable(enableRateLimiting),
                Optional.ToNullable(enableInternetSecurity),
                Optional.ToNullable(useLocalAzureIPAddress),
                Optional.ToNullable(provisioningState),
                vpnLinkConnections ?? new ChangeTrackingList<VpnSiteLinkConnectionData>(),
                routingConfiguration.Value);
        }

        BinaryData IPersistableModel<VpnConnectionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnConnectionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VpnConnectionData)} does not support '{options.Format}' format.");
            }
        }

        VpnConnectionData IPersistableModel<VpnConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnConnectionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVpnConnectionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VpnConnectionData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VpnConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
