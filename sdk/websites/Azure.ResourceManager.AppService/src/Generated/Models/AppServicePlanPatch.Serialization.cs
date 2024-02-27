// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServicePlanPatch : IUtf8JsonSerializable, IJsonModel<AppServicePlanPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppServicePlanPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppServicePlanPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServicePlanPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServicePlanPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Kind != null)
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
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
            if (WorkerTierName != null)
            {
                writer.WritePropertyName("workerTierName"u8);
                writer.WriteStringValue(WorkerTierName);
            }
            if (options.Format != "W" && Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (options.Format != "W" && Subscription != null)
            {
                writer.WritePropertyName("subscription"u8);
                writer.WriteStringValue(Subscription);
            }
            if (HostingEnvironmentProfile != null)
            {
                writer.WritePropertyName("hostingEnvironmentProfile"u8);
                writer.WriteObjectValue(HostingEnvironmentProfile);
            }
            if (options.Format != "W" && MaximumNumberOfWorkers.HasValue)
            {
                writer.WritePropertyName("maximumNumberOfWorkers"u8);
                writer.WriteNumberValue(MaximumNumberOfWorkers.Value);
            }
            if (options.Format != "W" && GeoRegion != null)
            {
                writer.WritePropertyName("geoRegion"u8);
                writer.WriteStringValue(GeoRegion);
            }
            if (IsPerSiteScaling.HasValue)
            {
                writer.WritePropertyName("perSiteScaling"u8);
                writer.WriteBooleanValue(IsPerSiteScaling.Value);
            }
            if (IsElasticScaleEnabled.HasValue)
            {
                writer.WritePropertyName("elasticScaleEnabled"u8);
                writer.WriteBooleanValue(IsElasticScaleEnabled.Value);
            }
            if (MaximumElasticWorkerCount.HasValue)
            {
                writer.WritePropertyName("maximumElasticWorkerCount"u8);
                writer.WriteNumberValue(MaximumElasticWorkerCount.Value);
            }
            if (options.Format != "W" && NumberOfSites.HasValue)
            {
                writer.WritePropertyName("numberOfSites"u8);
                writer.WriteNumberValue(NumberOfSites.Value);
            }
            if (IsSpot.HasValue)
            {
                writer.WritePropertyName("isSpot"u8);
                writer.WriteBooleanValue(IsSpot.Value);
            }
            if (SpotExpirationOn.HasValue)
            {
                writer.WritePropertyName("spotExpirationTime"u8);
                writer.WriteStringValue(SpotExpirationOn.Value, "O");
            }
            if (FreeOfferExpirationOn.HasValue)
            {
                writer.WritePropertyName("freeOfferExpirationTime"u8);
                writer.WriteStringValue(FreeOfferExpirationOn.Value, "O");
            }
            if (options.Format != "W" && ResourceGroup != null)
            {
                writer.WritePropertyName("resourceGroup"u8);
                writer.WriteStringValue(ResourceGroup);
            }
            if (IsReserved.HasValue)
            {
                writer.WritePropertyName("reserved"u8);
                writer.WriteBooleanValue(IsReserved.Value);
            }
            if (IsXenon.HasValue)
            {
                writer.WritePropertyName("isXenon"u8);
                writer.WriteBooleanValue(IsXenon.Value);
            }
            if (IsHyperV.HasValue)
            {
                writer.WritePropertyName("hyperV"u8);
                writer.WriteBooleanValue(IsHyperV.Value);
            }
            if (TargetWorkerCount.HasValue)
            {
                writer.WritePropertyName("targetWorkerCount"u8);
                writer.WriteNumberValue(TargetWorkerCount.Value);
            }
            if (TargetWorkerSizeId.HasValue)
            {
                writer.WritePropertyName("targetWorkerSizeId"u8);
                writer.WriteNumberValue(TargetWorkerSizeId.Value);
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToSerialString());
            }
            if (KubeEnvironmentProfile != null)
            {
                writer.WritePropertyName("kubeEnvironmentProfile"u8);
                writer.WriteObjectValue(KubeEnvironmentProfile);
            }
            if (IsZoneRedundant.HasValue)
            {
                writer.WritePropertyName("zoneRedundant"u8);
                writer.WriteBooleanValue(IsZoneRedundant.Value);
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

        AppServicePlanPatch IJsonModel<AppServicePlanPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServicePlanPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServicePlanPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServicePlanPatch(document.RootElement, options);
        }

        internal static AppServicePlanPatch DeserializeAppServicePlanPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> workerTierName = default;
            Optional<AppServicePlanStatus> status = default;
            Optional<string> subscription = default;
            Optional<HostingEnvironmentProfile> hostingEnvironmentProfile = default;
            Optional<int> maximumNumberOfWorkers = default;
            Optional<string> geoRegion = default;
            Optional<bool> perSiteScaling = default;
            Optional<bool> elasticScaleEnabled = default;
            Optional<int> maximumElasticWorkerCount = default;
            Optional<int> numberOfSites = default;
            Optional<bool> isSpot = default;
            Optional<DateTimeOffset> spotExpirationTime = default;
            Optional<DateTimeOffset> freeOfferExpirationTime = default;
            Optional<string> resourceGroup = default;
            Optional<bool> reserved = default;
            Optional<bool> isXenon = default;
            Optional<bool> hyperV = default;
            Optional<int> targetWorkerCount = default;
            Optional<int> targetWorkerSizeId = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<KubeEnvironmentProfile> kubeEnvironmentProfile = default;
            Optional<bool> zoneRedundant = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
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
                        if (property0.NameEquals("workerTierName"u8))
                        {
                            workerTierName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = property0.Value.GetString().ToAppServicePlanStatus();
                            continue;
                        }
                        if (property0.NameEquals("subscription"u8))
                        {
                            subscription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostingEnvironmentProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hostingEnvironmentProfile = HostingEnvironmentProfile.DeserializeHostingEnvironmentProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("maximumNumberOfWorkers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maximumNumberOfWorkers = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("geoRegion"u8))
                        {
                            geoRegion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("perSiteScaling"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            perSiteScaling = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("elasticScaleEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            elasticScaleEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("maximumElasticWorkerCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maximumElasticWorkerCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("numberOfSites"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfSites = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("isSpot"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isSpot = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("spotExpirationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            spotExpirationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("freeOfferExpirationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            freeOfferExpirationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("resourceGroup"u8))
                        {
                            resourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reserved"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reserved = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isXenon"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isXenon = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("hyperV"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hyperV = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("targetWorkerCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetWorkerCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("targetWorkerSizeId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetWorkerSizeId = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("kubeEnvironmentProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            kubeEnvironmentProfile = KubeEnvironmentProfile.DeserializeKubeEnvironmentProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("zoneRedundant"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            zoneRedundant = property0.Value.GetBoolean();
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
            return new AppServicePlanPatch(
                id,
                name,
                type,
                systemData.Value,
                workerTierName.Value,
                Optional.ToNullable(status),
                subscription.Value,
                hostingEnvironmentProfile.Value,
                Optional.ToNullable(maximumNumberOfWorkers),
                geoRegion.Value,
                Optional.ToNullable(perSiteScaling),
                Optional.ToNullable(elasticScaleEnabled),
                Optional.ToNullable(maximumElasticWorkerCount),
                Optional.ToNullable(numberOfSites),
                Optional.ToNullable(isSpot),
                Optional.ToNullable(spotExpirationTime),
                Optional.ToNullable(freeOfferExpirationTime),
                resourceGroup.Value,
                Optional.ToNullable(reserved),
                Optional.ToNullable(isXenon),
                Optional.ToNullable(hyperV),
                Optional.ToNullable(targetWorkerCount),
                Optional.ToNullable(targetWorkerSizeId),
                Optional.ToNullable(provisioningState),
                kubeEnvironmentProfile.Value,
                Optional.ToNullable(zoneRedundant),
                kind.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppServicePlanPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServicePlanPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppServicePlanPatch)} does not support '{options.Format}' format.");
            }
        }

        AppServicePlanPatch IPersistableModel<AppServicePlanPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServicePlanPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppServicePlanPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppServicePlanPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppServicePlanPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
