// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Details of the data to be used for importing data to azure. </summary>
    public partial class DataImportDetails
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataImportDetails"/>. </summary>
        /// <param name="accountDetails">
        /// Account details of the data to be transferred
        /// Please note <see cref="DataAccountDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ManagedDiskDetails"/> and <see cref="DataBoxStorageAccountDetails"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountDetails"/> is null. </exception>
        public DataImportDetails(DataAccountDetails accountDetails)
        {
            if (accountDetails == null)
            {
                throw new ArgumentNullException(nameof(accountDetails));
            }

            AccountDetails = accountDetails;
        }

        /// <summary> Initializes a new instance of <see cref="DataImportDetails"/>. </summary>
        /// <param name="accountDetails">
        /// Account details of the data to be transferred
        /// Please note <see cref="DataAccountDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ManagedDiskDetails"/> and <see cref="DataBoxStorageAccountDetails"/>.
        /// </param>
        /// <param name="logCollectionLevel"> Level of the logs to be collected. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataImportDetails(DataAccountDetails accountDetails, LogCollectionLevel? logCollectionLevel, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AccountDetails = accountDetails;
            LogCollectionLevel = logCollectionLevel;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataImportDetails"/> for deserialization. </summary>
        internal DataImportDetails()
        {
        }

        /// <summary>
        /// Account details of the data to be transferred
        /// Please note <see cref="DataAccountDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ManagedDiskDetails"/> and <see cref="DataBoxStorageAccountDetails"/>.
        /// </summary>
        public DataAccountDetails AccountDetails { get; set; }
        /// <summary> Level of the logs to be collected. </summary>
        public LogCollectionLevel? LogCollectionLevel { get; set; }
    }
}
