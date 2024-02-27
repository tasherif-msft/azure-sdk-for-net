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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class RecommendedActionData : IUtf8JsonSerializable, IJsonModel<RecommendedActionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecommendedActionData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RecommendedActionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecommendedActionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecommendedActionData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Kind != null)
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (options.Format != "W" && Location.HasValue)
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
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
            if (options.Format != "W" && RecommendationReason != null)
            {
                writer.WritePropertyName("recommendationReason"u8);
                writer.WriteStringValue(RecommendationReason);
            }
            if (options.Format != "W" && ValidSince.HasValue)
            {
                writer.WritePropertyName("validSince"u8);
                writer.WriteStringValue(ValidSince.Value, "O");
            }
            if (options.Format != "W" && LastRefresh.HasValue)
            {
                writer.WritePropertyName("lastRefresh"u8);
                writer.WriteStringValue(LastRefresh.Value, "O");
            }
            if (State != null)
            {
                writer.WritePropertyName("state"u8);
                writer.WriteObjectValue(State);
            }
            if (options.Format != "W" && IsExecutableAction.HasValue)
            {
                writer.WritePropertyName("isExecutableAction"u8);
                writer.WriteBooleanValue(IsExecutableAction.Value);
            }
            if (options.Format != "W" && IsRevertableAction.HasValue)
            {
                writer.WritePropertyName("isRevertableAction"u8);
                writer.WriteBooleanValue(IsRevertableAction.Value);
            }
            if (options.Format != "W" && IsArchivedAction.HasValue)
            {
                writer.WritePropertyName("isArchivedAction"u8);
                writer.WriteBooleanValue(IsArchivedAction.Value);
            }
            if (options.Format != "W" && ExecuteActionStartOn.HasValue)
            {
                writer.WritePropertyName("executeActionStartTime"u8);
                writer.WriteStringValue(ExecuteActionStartOn.Value, "O");
            }
            if (options.Format != "W" && ExecuteActionDuration.HasValue)
            {
                writer.WritePropertyName("executeActionDuration"u8);
                writer.WriteStringValue(ExecuteActionDuration.Value, "P");
            }
            if (options.Format != "W" && RevertActionStartOn.HasValue)
            {
                writer.WritePropertyName("revertActionStartTime"u8);
                writer.WriteStringValue(RevertActionStartOn.Value, "O");
            }
            if (options.Format != "W" && RevertActionDuration.HasValue)
            {
                writer.WritePropertyName("revertActionDuration"u8);
                writer.WriteStringValue(RevertActionDuration.Value, "P");
            }
            if (options.Format != "W" && ExecuteActionInitiatedBy.HasValue)
            {
                writer.WritePropertyName("executeActionInitiatedBy"u8);
                writer.WriteStringValue(ExecuteActionInitiatedBy.Value.ToSerialString());
            }
            if (options.Format != "W" && ExecuteActionInitiatedOn.HasValue)
            {
                writer.WritePropertyName("executeActionInitiatedTime"u8);
                writer.WriteStringValue(ExecuteActionInitiatedOn.Value, "O");
            }
            if (options.Format != "W" && RevertActionInitiatedBy.HasValue)
            {
                writer.WritePropertyName("revertActionInitiatedBy"u8);
                writer.WriteStringValue(RevertActionInitiatedBy.Value.ToSerialString());
            }
            if (options.Format != "W" && RevertActionInitiatedOn.HasValue)
            {
                writer.WritePropertyName("revertActionInitiatedTime"u8);
                writer.WriteStringValue(RevertActionInitiatedOn.Value, "O");
            }
            if (options.Format != "W" && Score.HasValue)
            {
                writer.WritePropertyName("score"u8);
                writer.WriteNumberValue(Score.Value);
            }
            if (options.Format != "W" && ImplementationDetails != null)
            {
                writer.WritePropertyName("implementationDetails"u8);
                writer.WriteObjectValue(ImplementationDetails);
            }
            if (options.Format != "W" && ErrorDetails != null)
            {
                writer.WritePropertyName("errorDetails"u8);
                writer.WriteObjectValue(ErrorDetails);
            }
            if (options.Format != "W" && !(EstimatedImpact is ChangeTrackingList<RecommendedActionImpactRecord> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("estimatedImpact"u8);
                writer.WriteStartArray();
                foreach (var item in EstimatedImpact)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(ObservedImpact is ChangeTrackingList<RecommendedActionImpactRecord> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("observedImpact"u8);
                writer.WriteStartArray();
                foreach (var item in ObservedImpact)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(TimeSeries is ChangeTrackingList<RecommendedActionMetricInfo> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("timeSeries"u8);
                writer.WriteStartArray();
                foreach (var item in TimeSeries)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(LinkedObjects is ChangeTrackingList<string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("linkedObjects"u8);
                writer.WriteStartArray();
                foreach (var item in LinkedObjects)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(Details is ChangeTrackingDictionary<string, BinaryData> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("details"u8);
                writer.WriteStartObject();
                foreach (var item in Details)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
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

        RecommendedActionData IJsonModel<RecommendedActionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecommendedActionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecommendedActionData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecommendedActionData(document.RootElement, options);
        }

        internal static RecommendedActionData DeserializeRecommendedActionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> recommendationReason = default;
            Optional<DateTimeOffset> validSince = default;
            Optional<DateTimeOffset> lastRefresh = default;
            Optional<RecommendedActionStateInfo> state = default;
            Optional<bool> isExecutableAction = default;
            Optional<bool> isRevertableAction = default;
            Optional<bool> isArchivedAction = default;
            Optional<DateTimeOffset> executeActionStartTime = default;
            Optional<TimeSpan> executeActionDuration = default;
            Optional<DateTimeOffset> revertActionStartTime = default;
            Optional<TimeSpan> revertActionDuration = default;
            Optional<RecommendedActionInitiatedBy> executeActionInitiatedBy = default;
            Optional<DateTimeOffset> executeActionInitiatedTime = default;
            Optional<RecommendedActionInitiatedBy> revertActionInitiatedBy = default;
            Optional<DateTimeOffset> revertActionInitiatedTime = default;
            Optional<int> score = default;
            Optional<RecommendedActionImplementationInfo> implementationDetails = default;
            Optional<RecommendedActionErrorInfo> errorDetails = default;
            IReadOnlyList<RecommendedActionImpactRecord> estimatedImpact = default;
            IReadOnlyList<RecommendedActionImpactRecord> observedImpact = default;
            IReadOnlyList<RecommendedActionMetricInfo> timeSeries = default;
            IReadOnlyList<string> linkedObjects = default;
            IReadOnlyDictionary<string, BinaryData> details = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("recommendationReason"u8))
                        {
                            recommendationReason = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("validSince"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            validSince = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastRefresh"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastRefresh = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = RecommendedActionStateInfo.DeserializeRecommendedActionStateInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("isExecutableAction"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isExecutableAction = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isRevertableAction"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isRevertableAction = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isArchivedAction"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isArchivedAction = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("executeActionStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            executeActionStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("executeActionDuration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            executeActionDuration = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("revertActionStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            revertActionStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("revertActionDuration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            revertActionDuration = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("executeActionInitiatedBy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            executeActionInitiatedBy = property0.Value.GetString().ToRecommendedActionInitiatedBy();
                            continue;
                        }
                        if (property0.NameEquals("executeActionInitiatedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            executeActionInitiatedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("revertActionInitiatedBy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            revertActionInitiatedBy = property0.Value.GetString().ToRecommendedActionInitiatedBy();
                            continue;
                        }
                        if (property0.NameEquals("revertActionInitiatedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            revertActionInitiatedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("score"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            score = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("implementationDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            implementationDetails = RecommendedActionImplementationInfo.DeserializeRecommendedActionImplementationInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("errorDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            errorDetails = RecommendedActionErrorInfo.DeserializeRecommendedActionErrorInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("estimatedImpact"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RecommendedActionImpactRecord> array = new List<RecommendedActionImpactRecord>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RecommendedActionImpactRecord.DeserializeRecommendedActionImpactRecord(item, options));
                            }
                            estimatedImpact = array;
                            continue;
                        }
                        if (property0.NameEquals("observedImpact"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RecommendedActionImpactRecord> array = new List<RecommendedActionImpactRecord>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RecommendedActionImpactRecord.DeserializeRecommendedActionImpactRecord(item, options));
                            }
                            observedImpact = array;
                            continue;
                        }
                        if (property0.NameEquals("timeSeries"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RecommendedActionMetricInfo> array = new List<RecommendedActionMetricInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RecommendedActionMetricInfo.DeserializeRecommendedActionMetricInfo(item, options));
                            }
                            timeSeries = array;
                            continue;
                        }
                        if (property0.NameEquals("linkedObjects"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            linkedObjects = array;
                            continue;
                        }
                        if (property0.NameEquals("details"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            details = dictionary;
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
            return new RecommendedActionData(
                id,
                name,
                type,
                systemData.Value,
                kind.Value,
                Optional.ToNullable(location),
                recommendationReason.Value,
                Optional.ToNullable(validSince),
                Optional.ToNullable(lastRefresh),
                state.Value,
                Optional.ToNullable(isExecutableAction),
                Optional.ToNullable(isRevertableAction),
                Optional.ToNullable(isArchivedAction),
                Optional.ToNullable(executeActionStartTime),
                Optional.ToNullable(executeActionDuration),
                Optional.ToNullable(revertActionStartTime),
                Optional.ToNullable(revertActionDuration),
                Optional.ToNullable(executeActionInitiatedBy),
                Optional.ToNullable(executeActionInitiatedTime),
                Optional.ToNullable(revertActionInitiatedBy),
                Optional.ToNullable(revertActionInitiatedTime),
                Optional.ToNullable(score),
                implementationDetails.Value,
                errorDetails.Value,
                estimatedImpact ?? new ChangeTrackingList<RecommendedActionImpactRecord>(),
                observedImpact ?? new ChangeTrackingList<RecommendedActionImpactRecord>(),
                timeSeries ?? new ChangeTrackingList<RecommendedActionMetricInfo>(),
                linkedObjects ?? new ChangeTrackingList<string>(),
                details ?? new ChangeTrackingDictionary<string, BinaryData>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RecommendedActionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecommendedActionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RecommendedActionData)} does not support '{options.Format}' format.");
            }
        }

        RecommendedActionData IPersistableModel<RecommendedActionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecommendedActionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRecommendedActionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecommendedActionData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecommendedActionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
