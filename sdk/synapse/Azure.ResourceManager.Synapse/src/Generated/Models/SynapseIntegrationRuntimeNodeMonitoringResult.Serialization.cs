// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseIntegrationRuntimeNodeMonitoringResult : IUtf8JsonSerializable, IJsonModel<SynapseIntegrationRuntimeNodeMonitoringResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseIntegrationRuntimeNodeMonitoringResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseIntegrationRuntimeNodeMonitoringResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeNodeMonitoringResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeNodeMonitoringResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && NodeName != null)
            {
                writer.WritePropertyName("nodeName"u8);
                writer.WriteStringValue(NodeName);
            }
            if (options.Format != "W" && AvailableMemoryInMB.HasValue)
            {
                writer.WritePropertyName("availableMemoryInMB"u8);
                writer.WriteNumberValue(AvailableMemoryInMB.Value);
            }
            if (options.Format != "W" && CpuUtilization.HasValue)
            {
                writer.WritePropertyName("cpuUtilization"u8);
                writer.WriteNumberValue(CpuUtilization.Value);
            }
            if (options.Format != "W" && ConcurrentJobsLimit.HasValue)
            {
                writer.WritePropertyName("concurrentJobsLimit"u8);
                writer.WriteNumberValue(ConcurrentJobsLimit.Value);
            }
            if (options.Format != "W" && ConcurrentJobsRunning.HasValue)
            {
                writer.WritePropertyName("concurrentJobsRunning"u8);
                writer.WriteNumberValue(ConcurrentJobsRunning.Value);
            }
            if (options.Format != "W" && MaxConcurrentJobs.HasValue)
            {
                writer.WritePropertyName("maxConcurrentJobs"u8);
                writer.WriteNumberValue(MaxConcurrentJobs.Value);
            }
            if (options.Format != "W" && SentBytes.HasValue)
            {
                writer.WritePropertyName("sentBytes"u8);
                writer.WriteNumberValue(SentBytes.Value);
            }
            if (options.Format != "W" && ReceivedBytes.HasValue)
            {
                writer.WritePropertyName("receivedBytes"u8);
                writer.WriteNumberValue(ReceivedBytes.Value);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        SynapseIntegrationRuntimeNodeMonitoringResult IJsonModel<SynapseIntegrationRuntimeNodeMonitoringResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeNodeMonitoringResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeNodeMonitoringResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseIntegrationRuntimeNodeMonitoringResult(document.RootElement, options);
        }

        internal static SynapseIntegrationRuntimeNodeMonitoringResult DeserializeSynapseIntegrationRuntimeNodeMonitoringResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nodeName = default;
            Optional<int> availableMemoryInMB = default;
            Optional<int> cpuUtilization = default;
            Optional<int> concurrentJobsLimit = default;
            Optional<int> concurrentJobsRunning = default;
            Optional<int> maxConcurrentJobs = default;
            Optional<float> sentBytes = default;
            Optional<float> receivedBytes = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nodeName"u8))
                {
                    nodeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("availableMemoryInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availableMemoryInMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("cpuUtilization"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpuUtilization = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("concurrentJobsLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    concurrentJobsLimit = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("concurrentJobsRunning"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    concurrentJobsRunning = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxConcurrentJobs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentJobs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sentBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sentBytes = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("receivedBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    receivedBytes = property.Value.GetSingle();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SynapseIntegrationRuntimeNodeMonitoringResult(
                nodeName.Value,
                Optional.ToNullable(availableMemoryInMB),
                Optional.ToNullable(cpuUtilization),
                Optional.ToNullable(concurrentJobsLimit),
                Optional.ToNullable(concurrentJobsRunning),
                Optional.ToNullable(maxConcurrentJobs),
                Optional.ToNullable(sentBytes),
                Optional.ToNullable(receivedBytes),
                additionalProperties);
        }

        BinaryData IPersistableModel<SynapseIntegrationRuntimeNodeMonitoringResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeNodeMonitoringResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeNodeMonitoringResult)} does not support '{options.Format}' format.");
            }
        }

        SynapseIntegrationRuntimeNodeMonitoringResult IPersistableModel<SynapseIntegrationRuntimeNodeMonitoringResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeNodeMonitoringResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseIntegrationRuntimeNodeMonitoringResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeNodeMonitoringResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseIntegrationRuntimeNodeMonitoringResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
