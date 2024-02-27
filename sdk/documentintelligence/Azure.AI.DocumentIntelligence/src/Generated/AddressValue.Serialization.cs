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

namespace Azure.AI.DocumentIntelligence
{
    public partial class AddressValue : IUtf8JsonSerializable, IJsonModel<AddressValue>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AddressValue>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AddressValue>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AddressValue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AddressValue)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (HouseNumber != null)
            {
                writer.WritePropertyName("houseNumber"u8);
                writer.WriteStringValue(HouseNumber);
            }
            if (PoBox != null)
            {
                writer.WritePropertyName("poBox"u8);
                writer.WriteStringValue(PoBox);
            }
            if (Road != null)
            {
                writer.WritePropertyName("road"u8);
                writer.WriteStringValue(Road);
            }
            if (City != null)
            {
                writer.WritePropertyName("city"u8);
                writer.WriteStringValue(City);
            }
            if (State != null)
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
            }
            if (PostalCode != null)
            {
                writer.WritePropertyName("postalCode"u8);
                writer.WriteStringValue(PostalCode);
            }
            if (CountryRegion != null)
            {
                writer.WritePropertyName("countryRegion"u8);
                writer.WriteStringValue(CountryRegion);
            }
            if (StreetAddress != null)
            {
                writer.WritePropertyName("streetAddress"u8);
                writer.WriteStringValue(StreetAddress);
            }
            if (Unit != null)
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit);
            }
            if (CityDistrict != null)
            {
                writer.WritePropertyName("cityDistrict"u8);
                writer.WriteStringValue(CityDistrict);
            }
            if (StateDistrict != null)
            {
                writer.WritePropertyName("stateDistrict"u8);
                writer.WriteStringValue(StateDistrict);
            }
            if (Suburb != null)
            {
                writer.WritePropertyName("suburb"u8);
                writer.WriteStringValue(Suburb);
            }
            if (House != null)
            {
                writer.WritePropertyName("house"u8);
                writer.WriteStringValue(House);
            }
            if (Level != null)
            {
                writer.WritePropertyName("level"u8);
                writer.WriteStringValue(Level);
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

        AddressValue IJsonModel<AddressValue>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AddressValue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AddressValue)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAddressValue(document.RootElement, options);
        }

        internal static AddressValue DeserializeAddressValue(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> houseNumber = default;
            Optional<string> poBox = default;
            Optional<string> road = default;
            Optional<string> city = default;
            Optional<string> state = default;
            Optional<string> postalCode = default;
            Optional<string> countryRegion = default;
            Optional<string> streetAddress = default;
            Optional<string> unit = default;
            Optional<string> cityDistrict = default;
            Optional<string> stateDistrict = default;
            Optional<string> suburb = default;
            Optional<string> house = default;
            Optional<string> level = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("houseNumber"u8))
                {
                    houseNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("poBox"u8))
                {
                    poBox = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("road"u8))
                {
                    road = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("city"u8))
                {
                    city = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("postalCode"u8))
                {
                    postalCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("countryRegion"u8))
                {
                    countryRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("streetAddress"u8))
                {
                    streetAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cityDistrict"u8))
                {
                    cityDistrict = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stateDistrict"u8))
                {
                    stateDistrict = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("suburb"u8))
                {
                    suburb = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("house"u8))
                {
                    house = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("level"u8))
                {
                    level = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AddressValue(
                houseNumber.Value,
                poBox.Value,
                road.Value,
                city.Value,
                state.Value,
                postalCode.Value,
                countryRegion.Value,
                streetAddress.Value,
                unit.Value,
                cityDistrict.Value,
                stateDistrict.Value,
                suburb.Value,
                house.Value,
                level.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AddressValue>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AddressValue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AddressValue)} does not support '{options.Format}' format.");
            }
        }

        AddressValue IPersistableModel<AddressValue>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AddressValue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAddressValue(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AddressValue)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AddressValue>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AddressValue FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAddressValue(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
