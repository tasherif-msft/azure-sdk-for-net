// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Billing.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Billing
{
    public partial class BillingPaymentMethodData : IUtf8JsonSerializable, IJsonModel<BillingPaymentMethodData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BillingPaymentMethodData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BillingPaymentMethodData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingPaymentMethodData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingPaymentMethodData)} does not support '{format}' format.");
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
            if (Family.HasValue)
            {
                writer.WritePropertyName("family"u8);
                writer.WriteStringValue(Family.Value.ToString());
            }
            if (options.Format != "W" && PaymentMethodType != null)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(PaymentMethodType);
            }
            if (options.Format != "W" && AccountHolderName != null)
            {
                writer.WritePropertyName("accountHolderName"u8);
                writer.WriteStringValue(AccountHolderName);
            }
            if (options.Format != "W" && Expiration != null)
            {
                writer.WritePropertyName("expiration"u8);
                writer.WriteStringValue(Expiration);
            }
            if (options.Format != "W" && LastFourDigits != null)
            {
                writer.WritePropertyName("lastFourDigits"u8);
                writer.WriteStringValue(LastFourDigits);
            }
            if (options.Format != "W" && DisplayName != null)
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (!(Logos is ChangeTrackingList<PaymentMethodLogo> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("logos"u8);
                writer.WriteStartArray();
                foreach (var item in Logos)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
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

        BillingPaymentMethodData IJsonModel<BillingPaymentMethodData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingPaymentMethodData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingPaymentMethodData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingPaymentMethodData(document.RootElement, options);
        }

        internal static BillingPaymentMethodData DeserializeBillingPaymentMethodData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<PaymentMethodFamily> family = default;
            Optional<string> type0 = default;
            Optional<string> accountHolderName = default;
            Optional<string> expiration = default;
            Optional<string> lastFourDigits = default;
            Optional<string> displayName = default;
            IList<PaymentMethodLogo> logos = default;
            Optional<PaymentMethodStatus> status = default;
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
                        if (property0.NameEquals("family"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            family = new PaymentMethodFamily(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("type"u8))
                        {
                            type0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accountHolderName"u8))
                        {
                            accountHolderName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("expiration"u8))
                        {
                            expiration = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastFourDigits"u8))
                        {
                            lastFourDigits = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("logos"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PaymentMethodLogo> array = new List<PaymentMethodLogo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PaymentMethodLogo.DeserializePaymentMethodLogo(item, options));
                            }
                            logos = array;
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new PaymentMethodStatus(property0.Value.GetString());
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
            return new BillingPaymentMethodData(
                id,
                name,
                type,
                systemData.Value,
                Optional.ToNullable(family),
                type0.Value,
                accountHolderName.Value,
                expiration.Value,
                lastFourDigits.Value,
                displayName.Value,
                logos ?? new ChangeTrackingList<PaymentMethodLogo>(),
                Optional.ToNullable(status),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BillingPaymentMethodData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingPaymentMethodData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BillingPaymentMethodData)} does not support '{options.Format}' format.");
            }
        }

        BillingPaymentMethodData IPersistableModel<BillingPaymentMethodData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingPaymentMethodData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBillingPaymentMethodData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BillingPaymentMethodData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BillingPaymentMethodData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
