// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningVirtualMachineCompute : IUtf8JsonSerializable, IJsonModel<MachineLearningVirtualMachineCompute>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningVirtualMachineCompute>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningVirtualMachineCompute>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningVirtualMachineCompute>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningVirtualMachineCompute)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Properties != null)
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue(Properties);
            }
            writer.WritePropertyName("computeType"u8);
            writer.WriteStringValue(ComputeType.ToString());
            if (ComputeLocation != null)
            {
                writer.WritePropertyName("computeLocation"u8);
                writer.WriteStringValue(ComputeLocation);
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Description != null)
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (options.Format != "W" && CreatedOn.HasValue)
            {
                writer.WritePropertyName("createdOn"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && ModifiedOn.HasValue)
            {
                writer.WritePropertyName("modifiedOn"u8);
                writer.WriteStringValue(ModifiedOn.Value, "O");
            }
            if (ResourceId != null)
            {
                if (ResourceId != null)
                {
                    writer.WritePropertyName("resourceId"u8);
                    writer.WriteStringValue(ResourceId);
                }
                else
                {
                    writer.WriteNull("resourceId");
                }
            }
            if (options.Format != "W" && !(ProvisioningErrors is ChangeTrackingList<MachineLearningError> collection && collection.IsUndefined))
            {
                if (ProvisioningErrors != null)
                {
                    writer.WritePropertyName("provisioningErrors"u8);
                    writer.WriteStartArray();
                    foreach (var item in ProvisioningErrors)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("provisioningErrors");
                }
            }
            if (options.Format != "W" && IsAttachedCompute.HasValue)
            {
                writer.WritePropertyName("isAttachedCompute"u8);
                writer.WriteBooleanValue(IsAttachedCompute.Value);
            }
            if (DisableLocalAuth.HasValue)
            {
                writer.WritePropertyName("disableLocalAuth"u8);
                writer.WriteBooleanValue(DisableLocalAuth.Value);
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

        MachineLearningVirtualMachineCompute IJsonModel<MachineLearningVirtualMachineCompute>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningVirtualMachineCompute>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningVirtualMachineCompute)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningVirtualMachineCompute(document.RootElement, options);
        }

        internal static MachineLearningVirtualMachineCompute DeserializeMachineLearningVirtualMachineCompute(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MachineLearningVirtualMachineProperties> properties = default;
            ComputeType computeType = default;
            Optional<string> computeLocation = default;
            Optional<MachineLearningProvisioningState> provisioningState = default;
            Optional<string> description = default;
            Optional<DateTimeOffset> createdOn = default;
            Optional<DateTimeOffset> modifiedOn = default;
            Optional<ResourceIdentifier> resourceId = default;
            IReadOnlyList<MachineLearningError> provisioningErrors = default;
            Optional<bool> isAttachedCompute = default;
            Optional<bool> disableLocalAuth = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = MachineLearningVirtualMachineProperties.DeserializeMachineLearningVirtualMachineProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("computeType"u8))
                {
                    computeType = new ComputeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("computeLocation"u8))
                {
                    computeLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new MachineLearningProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("modifiedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    modifiedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resourceId = null;
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        provisioningErrors = null;
                        continue;
                    }
                    List<MachineLearningError> array = new List<MachineLearningError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningError.DeserializeMachineLearningError(item, options));
                    }
                    provisioningErrors = array;
                    continue;
                }
                if (property.NameEquals("isAttachedCompute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAttachedCompute = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("disableLocalAuth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableLocalAuth = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningVirtualMachineCompute(
                computeType,
                computeLocation.Value,
                Optional.ToNullable(provisioningState),
                description.Value,
                Optional.ToNullable(createdOn),
                Optional.ToNullable(modifiedOn),
                resourceId.Value,
                provisioningErrors ?? new ChangeTrackingList<MachineLearningError>(),
                Optional.ToNullable(isAttachedCompute),
                Optional.ToNullable(disableLocalAuth),
                serializedAdditionalRawData,
                properties.Value);
        }

        BinaryData IPersistableModel<MachineLearningVirtualMachineCompute>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningVirtualMachineCompute>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningVirtualMachineCompute)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningVirtualMachineCompute IPersistableModel<MachineLearningVirtualMachineCompute>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningVirtualMachineCompute>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningVirtualMachineCompute(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningVirtualMachineCompute)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningVirtualMachineCompute>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
