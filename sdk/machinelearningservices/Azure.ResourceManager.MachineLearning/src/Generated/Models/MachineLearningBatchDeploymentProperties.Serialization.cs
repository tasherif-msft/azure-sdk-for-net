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
    public partial class MachineLearningBatchDeploymentProperties : IUtf8JsonSerializable, IJsonModel<MachineLearningBatchDeploymentProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningBatchDeploymentProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningBatchDeploymentProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningBatchDeploymentProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningBatchDeploymentProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Compute != null)
            {
                if (Compute != null)
                {
                    writer.WritePropertyName("compute"u8);
                    writer.WriteStringValue(Compute);
                }
                else
                {
                    writer.WriteNull("compute");
                }
            }
            if (DeploymentConfiguration != null)
            {
                if (DeploymentConfiguration != null)
                {
                    writer.WritePropertyName("deploymentConfiguration"u8);
                    writer.WriteObjectValue(DeploymentConfiguration);
                }
                else
                {
                    writer.WriteNull("deploymentConfiguration");
                }
            }
            if (ErrorThreshold.HasValue)
            {
                writer.WritePropertyName("errorThreshold"u8);
                writer.WriteNumberValue(ErrorThreshold.Value);
            }
            if (LoggingLevel.HasValue)
            {
                writer.WritePropertyName("loggingLevel"u8);
                writer.WriteStringValue(LoggingLevel.Value.ToString());
            }
            if (MaxConcurrencyPerInstance.HasValue)
            {
                writer.WritePropertyName("maxConcurrencyPerInstance"u8);
                writer.WriteNumberValue(MaxConcurrencyPerInstance.Value);
            }
            if (MiniBatchSize.HasValue)
            {
                writer.WritePropertyName("miniBatchSize"u8);
                writer.WriteNumberValue(MiniBatchSize.Value);
            }
            if (Model != null)
            {
                if (Model != null)
                {
                    writer.WritePropertyName("model"u8);
                    writer.WriteObjectValue(Model);
                }
                else
                {
                    writer.WriteNull("model");
                }
            }
            if (OutputAction.HasValue)
            {
                writer.WritePropertyName("outputAction"u8);
                writer.WriteStringValue(OutputAction.Value.ToString());
            }
            if (OutputFileName != null)
            {
                writer.WritePropertyName("outputFileName"u8);
                writer.WriteStringValue(OutputFileName);
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Resources != null)
            {
                if (Resources != null)
                {
                    writer.WritePropertyName("resources"u8);
                    writer.WriteObjectValue(Resources);
                }
                else
                {
                    writer.WriteNull("resources");
                }
            }
            if (RetrySettings != null)
            {
                if (RetrySettings != null)
                {
                    writer.WritePropertyName("retrySettings"u8);
                    writer.WriteObjectValue(RetrySettings);
                }
                else
                {
                    writer.WriteNull("retrySettings");
                }
            }
            if (CodeConfiguration != null)
            {
                if (CodeConfiguration != null)
                {
                    writer.WritePropertyName("codeConfiguration"u8);
                    writer.WriteObjectValue(CodeConfiguration);
                }
                else
                {
                    writer.WriteNull("codeConfiguration");
                }
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
            if (EnvironmentId != null)
            {
                if (EnvironmentId != null)
                {
                    writer.WritePropertyName("environmentId"u8);
                    writer.WriteStringValue(EnvironmentId);
                }
                else
                {
                    writer.WriteNull("environmentId");
                }
            }
            if (!(EnvironmentVariables is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                if (EnvironmentVariables != null)
                {
                    writer.WritePropertyName("environmentVariables"u8);
                    writer.WriteStartObject();
                    foreach (var item in EnvironmentVariables)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("environmentVariables");
                }
            }
            if (!(Properties is ChangeTrackingDictionary<string, string> collection0 && collection0.IsUndefined))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
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

        MachineLearningBatchDeploymentProperties IJsonModel<MachineLearningBatchDeploymentProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningBatchDeploymentProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningBatchDeploymentProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningBatchDeploymentProperties(document.RootElement, options);
        }

        internal static MachineLearningBatchDeploymentProperties DeserializeMachineLearningBatchDeploymentProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> compute = default;
            Optional<BatchDeploymentConfiguration> deploymentConfiguration = default;
            Optional<int> errorThreshold = default;
            Optional<MachineLearningBatchLoggingLevel> loggingLevel = default;
            Optional<int> maxConcurrencyPerInstance = default;
            Optional<long> miniBatchSize = default;
            Optional<MachineLearningAssetReferenceBase> model = default;
            Optional<MachineLearningBatchOutputAction> outputAction = default;
            Optional<string> outputFileName = default;
            Optional<MachineLearningDeploymentProvisioningState> provisioningState = default;
            Optional<MachineLearningDeploymentResourceConfiguration> resources = default;
            Optional<MachineLearningBatchRetrySettings> retrySettings = default;
            Optional<MachineLearningCodeConfiguration> codeConfiguration = default;
            Optional<string> description = default;
            Optional<string> environmentId = default;
            IDictionary<string, string> environmentVariables = default;
            IDictionary<string, string> properties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("compute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        compute = null;
                        continue;
                    }
                    compute = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deploymentConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        deploymentConfiguration = null;
                        continue;
                    }
                    deploymentConfiguration = BatchDeploymentConfiguration.DeserializeBatchDeploymentConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("errorThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("loggingLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loggingLevel = new MachineLearningBatchLoggingLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("maxConcurrencyPerInstance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrencyPerInstance = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("miniBatchSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    miniBatchSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        model = null;
                        continue;
                    }
                    model = MachineLearningAssetReferenceBase.DeserializeMachineLearningAssetReferenceBase(property.Value, options);
                    continue;
                }
                if (property.NameEquals("outputAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outputAction = new MachineLearningBatchOutputAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("outputFileName"u8))
                {
                    outputFileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new MachineLearningDeploymentProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resources = null;
                        continue;
                    }
                    resources = MachineLearningDeploymentResourceConfiguration.DeserializeMachineLearningDeploymentResourceConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("retrySettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        retrySettings = null;
                        continue;
                    }
                    retrySettings = MachineLearningBatchRetrySettings.DeserializeMachineLearningBatchRetrySettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("codeConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        codeConfiguration = null;
                        continue;
                    }
                    codeConfiguration = MachineLearningCodeConfiguration.DeserializeMachineLearningCodeConfiguration(property.Value, options);
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
                if (property.NameEquals("environmentId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        environmentId = null;
                        continue;
                    }
                    environmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("environmentVariables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        environmentVariables = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    environmentVariables = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningBatchDeploymentProperties(
                codeConfiguration.Value,
                description.Value,
                environmentId.Value,
                environmentVariables ?? new ChangeTrackingDictionary<string, string>(),
                properties ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
                compute.Value,
                deploymentConfiguration.Value,
                Optional.ToNullable(errorThreshold),
                Optional.ToNullable(loggingLevel),
                Optional.ToNullable(maxConcurrencyPerInstance),
                Optional.ToNullable(miniBatchSize),
                model.Value,
                Optional.ToNullable(outputAction),
                outputFileName.Value,
                Optional.ToNullable(provisioningState),
                resources.Value,
                retrySettings.Value);
        }

        BinaryData IPersistableModel<MachineLearningBatchDeploymentProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningBatchDeploymentProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningBatchDeploymentProperties)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningBatchDeploymentProperties IPersistableModel<MachineLearningBatchDeploymentProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningBatchDeploymentProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningBatchDeploymentProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningBatchDeploymentProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningBatchDeploymentProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
