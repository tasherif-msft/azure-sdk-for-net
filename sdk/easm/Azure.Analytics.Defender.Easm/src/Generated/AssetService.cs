// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The AssetService. </summary>
    public partial class AssetService
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

        /// <summary> Initializes a new instance of <see cref="AssetService"/>. </summary>
        internal AssetService()
        {
            WebComponents = new ChangeTrackingList<WebComponent>();
            SslCerts = new ChangeTrackingList<SslCertAsset>();
            Exceptions = new ChangeTrackingList<ObservedString>();
            Sources = new ChangeTrackingList<SourceDetails>();
            PortStates = new ChangeTrackingList<ObservedPortState>();
        }

        /// <summary> Initializes a new instance of <see cref="AssetService"/>. </summary>
        /// <param name="scheme"></param>
        /// <param name="port"></param>
        /// <param name="webComponents"></param>
        /// <param name="sslCerts"></param>
        /// <param name="exceptions"></param>
        /// <param name="sources"></param>
        /// <param name="firstSeen"></param>
        /// <param name="lastSeen"></param>
        /// <param name="count"></param>
        /// <param name="recent"></param>
        /// <param name="portStates"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AssetService(string scheme, int? port, IReadOnlyList<WebComponent> webComponents, IReadOnlyList<SslCertAsset> sslCerts, IReadOnlyList<ObservedString> exceptions, IReadOnlyList<SourceDetails> sources, DateTimeOffset? firstSeen, DateTimeOffset? lastSeen, long? count, bool? recent, IReadOnlyList<ObservedPortState> portStates, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Scheme = scheme;
            Port = port;
            WebComponents = webComponents;
            SslCerts = sslCerts;
            Exceptions = exceptions;
            Sources = sources;
            FirstSeen = firstSeen;
            LastSeen = lastSeen;
            Count = count;
            Recent = recent;
            PortStates = portStates;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the scheme. </summary>
        public string Scheme { get; }
        /// <summary> Gets the port. </summary>
        public int? Port { get; }
        /// <summary> Gets the web components. </summary>
        public IReadOnlyList<WebComponent> WebComponents { get; }
        /// <summary> Gets the ssl certs. </summary>
        public IReadOnlyList<SslCertAsset> SslCerts { get; }
        /// <summary> Gets the exceptions. </summary>
        public IReadOnlyList<ObservedString> Exceptions { get; }
        /// <summary> Gets the sources. </summary>
        public IReadOnlyList<SourceDetails> Sources { get; }
        /// <summary> Gets the first seen. </summary>
        public DateTimeOffset? FirstSeen { get; }
        /// <summary> Gets the last seen. </summary>
        public DateTimeOffset? LastSeen { get; }
        /// <summary> Gets the count. </summary>
        public long? Count { get; }
        /// <summary> Gets the recent. </summary>
        public bool? Recent { get; }
        /// <summary> Gets the port states. </summary>
        public IReadOnlyList<ObservedPortState> PortStates { get; }
    }
}
