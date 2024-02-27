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
    public partial class PremierAddOnOffer : IUtf8JsonSerializable, IJsonModel<PremierAddOnOffer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PremierAddOnOffer>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PremierAddOnOffer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PremierAddOnOffer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PremierAddOnOffer)} does not support '{format}' format.");
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
            if (Sku != null)
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteStringValue(Sku);
            }
            if (Product != null)
            {
                writer.WritePropertyName("product"u8);
                writer.WriteStringValue(Product);
            }
            if (Vendor != null)
            {
                writer.WritePropertyName("vendor"u8);
                writer.WriteStringValue(Vendor);
            }
            if (IsPromoCodeRequired.HasValue)
            {
                writer.WritePropertyName("promoCodeRequired"u8);
                writer.WriteBooleanValue(IsPromoCodeRequired.Value);
            }
            if (Quota.HasValue)
            {
                writer.WritePropertyName("quota"u8);
                writer.WriteNumberValue(Quota.Value);
            }
            if (WebHostingPlanRestrictions.HasValue)
            {
                writer.WritePropertyName("webHostingPlanRestrictions"u8);
                writer.WriteStringValue(WebHostingPlanRestrictions.Value.ToSerialString());
            }
            if (PrivacyPolicyUri != null)
            {
                writer.WritePropertyName("privacyPolicyUrl"u8);
                writer.WriteStringValue(PrivacyPolicyUri.AbsoluteUri);
            }
            if (LegalTermsUri != null)
            {
                writer.WritePropertyName("legalTermsUrl"u8);
                writer.WriteStringValue(LegalTermsUri.AbsoluteUri);
            }
            if (MarketplacePublisher != null)
            {
                writer.WritePropertyName("marketplacePublisher"u8);
                writer.WriteStringValue(MarketplacePublisher);
            }
            if (MarketplaceOffer != null)
            {
                writer.WritePropertyName("marketplaceOffer"u8);
                writer.WriteStringValue(MarketplaceOffer);
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

        PremierAddOnOffer IJsonModel<PremierAddOnOffer>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PremierAddOnOffer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PremierAddOnOffer)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePremierAddOnOffer(document.RootElement, options);
        }

        internal static PremierAddOnOffer DeserializePremierAddOnOffer(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<string> sku = default;
            Optional<string> product = default;
            Optional<string> vendor = default;
            Optional<bool> promoCodeRequired = default;
            Optional<int> quota = default;
            Optional<AppServicePlanRestriction> webHostingPlanRestrictions = default;
            Optional<Uri> privacyPolicyUrl = default;
            Optional<Uri> legalTermsUrl = default;
            Optional<string> marketplacePublisher = default;
            Optional<string> marketplaceOffer = default;
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
                        if (property0.NameEquals("sku"u8))
                        {
                            sku = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("product"u8))
                        {
                            product = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vendor"u8))
                        {
                            vendor = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("promoCodeRequired"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            promoCodeRequired = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("quota"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            quota = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("webHostingPlanRestrictions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            webHostingPlanRestrictions = property0.Value.GetString().ToAppServicePlanRestriction();
                            continue;
                        }
                        if (property0.NameEquals("privacyPolicyUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privacyPolicyUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("legalTermsUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            legalTermsUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("marketplacePublisher"u8))
                        {
                            marketplacePublisher = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("marketplaceOffer"u8))
                        {
                            marketplaceOffer = property0.Value.GetString();
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
            return new PremierAddOnOffer(
                id,
                name,
                type,
                systemData.Value,
                sku.Value,
                product.Value,
                vendor.Value,
                Optional.ToNullable(promoCodeRequired),
                Optional.ToNullable(quota),
                Optional.ToNullable(webHostingPlanRestrictions),
                privacyPolicyUrl.Value,
                legalTermsUrl.Value,
                marketplacePublisher.Value,
                marketplaceOffer.Value,
                kind.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PremierAddOnOffer>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PremierAddOnOffer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PremierAddOnOffer)} does not support '{options.Format}' format.");
            }
        }

        PremierAddOnOffer IPersistableModel<PremierAddOnOffer>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PremierAddOnOffer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePremierAddOnOffer(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PremierAddOnOffer)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PremierAddOnOffer>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
