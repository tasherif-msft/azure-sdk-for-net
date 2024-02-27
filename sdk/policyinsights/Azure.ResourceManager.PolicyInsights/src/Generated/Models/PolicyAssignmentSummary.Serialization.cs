// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class PolicyAssignmentSummary : IUtf8JsonSerializable, IJsonModel<PolicyAssignmentSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicyAssignmentSummary>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PolicyAssignmentSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyAssignmentSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyAssignmentSummary)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (PolicyAssignmentId != null)
            {
                writer.WritePropertyName("policyAssignmentId"u8);
                writer.WriteStringValue(PolicyAssignmentId);
            }
            if (PolicySetDefinitionId != null)
            {
                writer.WritePropertyName("policySetDefinitionId"u8);
                writer.WriteStringValue(PolicySetDefinitionId);
            }
            if (Results != null)
            {
                writer.WritePropertyName("results"u8);
                writer.WriteObjectValue(Results);
            }
            if (!(PolicyDefinitions is ChangeTrackingList<PolicyDefinitionSummary> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("policyDefinitions"u8);
                writer.WriteStartArray();
                foreach (var item in PolicyDefinitions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(PolicyGroups is ChangeTrackingList<PolicyGroupSummary> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("policyGroups"u8);
                writer.WriteStartArray();
                foreach (var item in PolicyGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        PolicyAssignmentSummary IJsonModel<PolicyAssignmentSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyAssignmentSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyAssignmentSummary)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyAssignmentSummary(document.RootElement, options);
        }

        internal static PolicyAssignmentSummary DeserializePolicyAssignmentSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> policyAssignmentId = default;
            Optional<ResourceIdentifier> policySetDefinitionId = default;
            Optional<PolicySummaryResults> results = default;
            IReadOnlyList<PolicyDefinitionSummary> policyDefinitions = default;
            IReadOnlyList<PolicyGroupSummary> policyGroups = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policyAssignmentId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    policyAssignmentId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policySetDefinitionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    policySetDefinitionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("results"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    results = PolicySummaryResults.DeserializePolicySummaryResults(property.Value, options);
                    continue;
                }
                if (property.NameEquals("policyDefinitions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PolicyDefinitionSummary> array = new List<PolicyDefinitionSummary>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PolicyDefinitionSummary.DeserializePolicyDefinitionSummary(item, options));
                    }
                    policyDefinitions = array;
                    continue;
                }
                if (property.NameEquals("policyGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PolicyGroupSummary> array = new List<PolicyGroupSummary>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PolicyGroupSummary.DeserializePolicyGroupSummary(item, options));
                    }
                    policyGroups = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PolicyAssignmentSummary(
                policyAssignmentId.Value,
                policySetDefinitionId.Value,
                results.Value,
                policyDefinitions ?? new ChangeTrackingList<PolicyDefinitionSummary>(),
                policyGroups ?? new ChangeTrackingList<PolicyGroupSummary>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PolicyAssignmentSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyAssignmentSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PolicyAssignmentSummary)} does not support '{options.Format}' format.");
            }
        }

        PolicyAssignmentSummary IPersistableModel<PolicyAssignmentSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyAssignmentSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePolicyAssignmentSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PolicyAssignmentSummary)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolicyAssignmentSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
