// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.AgFoodPlatform;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AgFoodPlatform.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmAgFoodPlatformModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="AgFoodPlatform.ExtensionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="eTag"> The ETag value to implement optimistic concurrency. </param>
        /// <param name="extensionId"> Extension Id. </param>
        /// <param name="extensionCategory"> Extension category. e.g. weather/sensor/satellite. </param>
        /// <param name="installedExtensionVersion"> Installed extension version. </param>
        /// <param name="extensionAuthLink"> Extension auth link. </param>
        /// <param name="extensionApiDocsLink"> Extension api docs link. </param>
        /// <returns> A new <see cref="AgFoodPlatform.ExtensionData"/> instance for mocking. </returns>
        public static ExtensionData ExtensionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ETag? eTag = null, string extensionId = null, string extensionCategory = null, string installedExtensionVersion = null, string extensionAuthLink = null, string extensionApiDocsLink = null)
        {
            return new ExtensionData(
                id,
                name,
                resourceType,
                systemData,
                eTag,
                extensionId,
                extensionCategory,
                installedExtensionVersion,
                extensionAuthLink,
                extensionApiDocsLink,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AgFoodPlatform.FarmBeatsExtensionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="targetResourceType"> Target ResourceType of the farmBeatsExtension. </param>
        /// <param name="farmBeatsExtensionId"> FarmBeatsExtension ID. </param>
        /// <param name="farmBeatsExtensionName"> FarmBeatsExtension name. </param>
        /// <param name="farmBeatsExtensionVersion"> FarmBeatsExtension version. </param>
        /// <param name="publisherId"> Publisher ID. </param>
        /// <param name="description"> Textual description. </param>
        /// <param name="extensionCategory"> Category of the extension. e.g. weather/sensor/satellite. </param>
        /// <param name="extensionAuthLink"> FarmBeatsExtension auth link. </param>
        /// <param name="extensionApiDocsLink"> FarmBeatsExtension api docs link. </param>
        /// <param name="detailedInformation">
        /// Detailed information which shows summary of requested data.
        /// Used in descriptive get extension metadata call.
        /// Information for weather category per api included are apisSupported,
        /// customParameters, PlatformParameters and Units supported.
        /// </param>
        /// <returns> A new <see cref="AgFoodPlatform.FarmBeatsExtensionData"/> instance for mocking. </returns>
        public static FarmBeatsExtensionData FarmBeatsExtensionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string targetResourceType = null, string farmBeatsExtensionId = null, string farmBeatsExtensionName = null, string farmBeatsExtensionVersion = null, string publisherId = null, string description = null, string extensionCategory = null, string extensionAuthLink = null, string extensionApiDocsLink = null, IEnumerable<DetailedInformation> detailedInformation = null)
        {
            detailedInformation ??= new List<DetailedInformation>();

            return new FarmBeatsExtensionData(
                id,
                name,
                resourceType,
                systemData,
                targetResourceType,
                farmBeatsExtensionId,
                farmBeatsExtensionName,
                farmBeatsExtensionVersion,
                publisherId,
                description,
                extensionCategory,
                extensionAuthLink,
                extensionApiDocsLink,
                detailedInformation?.ToList(),
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DetailedInformation"/>. </summary>
        /// <param name="apiName"> ApiName available for the farmBeatsExtension. </param>
        /// <param name="customParameters"> List of customParameters. </param>
        /// <param name="platformParameters"> List of platformParameters. </param>
        /// <param name="unitsSupported"> Unit systems info for the data provider. </param>
        /// <param name="apiInputParameters"> List of apiInputParameters. </param>
        /// <returns> A new <see cref="Models.DetailedInformation"/> instance for mocking. </returns>
        public static DetailedInformation DetailedInformation(string apiName = null, IEnumerable<string> customParameters = null, IEnumerable<string> platformParameters = null, UnitSystemsInfo unitsSupported = null, IEnumerable<string> apiInputParameters = null)
        {
            customParameters ??= new List<string>();
            platformParameters ??= new List<string>();
            apiInputParameters ??= new List<string>();

            return new DetailedInformation(
                apiName,
                customParameters?.ToList(),
                platformParameters?.ToList(),
                unitsSupported,
                apiInputParameters?.ToList(),
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.UnitSystemsInfo"/>. </summary>
        /// <param name="key"> UnitSystem key sent as part of ProviderInput. </param>
        /// <param name="values"> List of unit systems supported by this data provider. </param>
        /// <returns> A new <see cref="Models.UnitSystemsInfo"/> instance for mocking. </returns>
        public static UnitSystemsInfo UnitSystemsInfo(string key = null, IEnumerable<string> values = null)
        {
            values ??= new List<string>();

            return new UnitSystemsInfo(key, values?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AgFoodPlatform.FarmBeatData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Identity for the resource. Current supported identity types: SystemAssigned. </param>
        /// <param name="instanceUri"> Uri of the FarmBeats instance. </param>
        /// <param name="provisioningState"> FarmBeats instance provisioning state. </param>
        /// <param name="sensorIntegration"> Sensor integration request model. </param>
        /// <param name="publicNetworkAccess"> Property to allow or block public traffic for an Azure FarmBeats resource. </param>
        /// <param name="privateEndpointConnections"> The Private Endpoint Connection resource. </param>
        /// <returns> A new <see cref="AgFoodPlatform.FarmBeatData"/> instance for mocking. </returns>
        public static FarmBeatData FarmBeatData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ManagedServiceIdentity identity = null, Uri instanceUri = null, ProvisioningState? provisioningState = null, SensorIntegration sensorIntegration = null, PublicNetworkAccess? publicNetworkAccess = null, AgFoodPlatformPrivateEndpointConnectionData privateEndpointConnections = null)
        {
            tags ??= new Dictionary<string, string>();

            return new FarmBeatData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                identity,
                instanceUri,
                provisioningState,
                sensorIntegration,
                publicNetworkAccess,
                privateEndpointConnections,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SensorIntegration"/>. </summary>
        /// <param name="enabled"> Sensor integration enable state. Allowed values are True, None. </param>
        /// <param name="provisioningState"> Sensor integration instance provisioning state. </param>
        /// <param name="provisioningInfoError"> Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.). </param>
        /// <returns> A new <see cref="Models.SensorIntegration"/> instance for mocking. </returns>
        public static SensorIntegration SensorIntegration(string enabled = null, ProvisioningState? provisioningState = null, ResponseError provisioningInfoError = null)
        {
            return new SensorIntegration(enabled, provisioningState, provisioningInfoError != null ? new ErrorResponse(provisioningInfoError, serializedAdditionalRawData: null) : null, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AgFoodPlatform.AgFoodPlatformPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="privateEndpointId"> The resource of private end point. </param>
        /// <param name="connectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint connection resource. </param>
        /// <returns> A new <see cref="AgFoodPlatform.AgFoodPlatformPrivateEndpointConnectionData"/> instance for mocking. </returns>
        public static AgFoodPlatformPrivateEndpointConnectionData AgFoodPlatformPrivateEndpointConnectionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ResourceIdentifier privateEndpointId = null, AgFoodPlatformPrivateLinkServiceConnectionState connectionState = null, AgFoodPlatformPrivateEndpointConnectionProvisioningState? provisioningState = null)
        {
            return new AgFoodPlatformPrivateEndpointConnectionData(
                id,
                name,
                resourceType,
                systemData,
                privateEndpointId != null ? ResourceManagerModelFactory.SubResource(privateEndpointId) : null,
                connectionState,
                provisioningState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ArmAsyncOperation"/>. </summary>
        /// <param name="status"> Status of the async operation. </param>
        /// <returns> A new <see cref="Models.ArmAsyncOperation"/> instance for mocking. </returns>
        public static ArmAsyncOperation ArmAsyncOperation(string status = null)
        {
            return new ArmAsyncOperation(status, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.CheckNameAvailabilityResponse"/>. </summary>
        /// <param name="nameAvailable"> Indicates if the resource name is available. </param>
        /// <param name="reason"> The reason why the given name is not available. </param>
        /// <param name="message"> Detailed reason why the given name is available. </param>
        /// <returns> A new <see cref="Models.CheckNameAvailabilityResponse"/> instance for mocking. </returns>
        public static CheckNameAvailabilityResponse CheckNameAvailabilityResponse(bool? nameAvailable = null, CheckNameAvailabilityReason? reason = null, string message = null)
        {
            return new CheckNameAvailabilityResponse(nameAvailable, reason, message, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AgFoodPlatform.AgFoodPlatformPrivateLinkResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupId"> The private link resource group id. </param>
        /// <param name="requiredMembers"> The private link resource required member names. </param>
        /// <param name="requiredZoneNames"> The private link resource Private link DNS zone name. </param>
        /// <returns> A new <see cref="AgFoodPlatform.AgFoodPlatformPrivateLinkResourceData"/> instance for mocking. </returns>
        public static AgFoodPlatformPrivateLinkResourceData AgFoodPlatformPrivateLinkResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string groupId = null, IEnumerable<string> requiredMembers = null, IEnumerable<string> requiredZoneNames = null)
        {
            requiredMembers ??= new List<string>();
            requiredZoneNames ??= new List<string>();

            return new AgFoodPlatformPrivateLinkResourceData(
                id,
                name,
                resourceType,
                systemData,
                groupId,
                requiredMembers?.ToList(),
                requiredZoneNames?.ToList(),
                serializedAdditionalRawData: null);
        }
    }
}
