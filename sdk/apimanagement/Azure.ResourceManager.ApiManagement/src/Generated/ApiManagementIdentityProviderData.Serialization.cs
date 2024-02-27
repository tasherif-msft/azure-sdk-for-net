// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ApiManagementIdentityProviderData : IUtf8JsonSerializable, IJsonModel<ApiManagementIdentityProviderData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiManagementIdentityProviderData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApiManagementIdentityProviderData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementIdentityProviderData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiManagementIdentityProviderData)} does not support '{format}' format.");
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
            if (IdentityProviderType.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(IdentityProviderType.Value.ToString());
            }
            if (SignInTenant != null)
            {
                writer.WritePropertyName("signinTenant"u8);
                writer.WriteStringValue(SignInTenant);
            }
            if (!(AllowedTenants is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("allowedTenants"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedTenants)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Authority != null)
            {
                writer.WritePropertyName("authority"u8);
                writer.WriteStringValue(Authority);
            }
            if (SignUpPolicyName != null)
            {
                writer.WritePropertyName("signupPolicyName"u8);
                writer.WriteStringValue(SignUpPolicyName);
            }
            if (SignInPolicyName != null)
            {
                writer.WritePropertyName("signinPolicyName"u8);
                writer.WriteStringValue(SignInPolicyName);
            }
            if (ProfileEditingPolicyName != null)
            {
                writer.WritePropertyName("profileEditingPolicyName"u8);
                writer.WriteStringValue(ProfileEditingPolicyName);
            }
            if (PasswordResetPolicyName != null)
            {
                writer.WritePropertyName("passwordResetPolicyName"u8);
                writer.WriteStringValue(PasswordResetPolicyName);
            }
            if (ClientId != null)
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteStringValue(ClientId);
            }
            if (ClientSecret != null)
            {
                writer.WritePropertyName("clientSecret"u8);
                writer.WriteStringValue(ClientSecret);
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

        ApiManagementIdentityProviderData IJsonModel<ApiManagementIdentityProviderData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementIdentityProviderData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiManagementIdentityProviderData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiManagementIdentityProviderData(document.RootElement, options);
        }

        internal static ApiManagementIdentityProviderData DeserializeApiManagementIdentityProviderData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<IdentityProviderType> type0 = default;
            Optional<string> signinTenant = default;
            IList<string> allowedTenants = default;
            Optional<string> authority = default;
            Optional<string> signupPolicyName = default;
            Optional<string> signinPolicyName = default;
            Optional<string> profileEditingPolicyName = default;
            Optional<string> passwordResetPolicyName = default;
            Optional<string> clientId = default;
            Optional<string> clientSecret = default;
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
                        if (property0.NameEquals("type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            type0 = new IdentityProviderType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("signinTenant"u8))
                        {
                            signinTenant = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("allowedTenants"u8))
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
                            allowedTenants = array;
                            continue;
                        }
                        if (property0.NameEquals("authority"u8))
                        {
                            authority = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("signupPolicyName"u8))
                        {
                            signupPolicyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("signinPolicyName"u8))
                        {
                            signinPolicyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("profileEditingPolicyName"u8))
                        {
                            profileEditingPolicyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("passwordResetPolicyName"u8))
                        {
                            passwordResetPolicyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clientId"u8))
                        {
                            clientId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clientSecret"u8))
                        {
                            clientSecret = property0.Value.GetString();
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
            return new ApiManagementIdentityProviderData(
                id,
                name,
                type,
                systemData.Value,
                Optional.ToNullable(type0),
                signinTenant.Value,
                allowedTenants ?? new ChangeTrackingList<string>(),
                authority.Value,
                signupPolicyName.Value,
                signinPolicyName.Value,
                profileEditingPolicyName.Value,
                passwordResetPolicyName.Value,
                clientId.Value,
                clientSecret.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApiManagementIdentityProviderData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementIdentityProviderData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApiManagementIdentityProviderData)} does not support '{options.Format}' format.");
            }
        }

        ApiManagementIdentityProviderData IPersistableModel<ApiManagementIdentityProviderData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementIdentityProviderData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApiManagementIdentityProviderData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApiManagementIdentityProviderData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApiManagementIdentityProviderData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
