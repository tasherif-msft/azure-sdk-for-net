// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The WebComponent. </summary>
    public partial class WebComponent
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

        /// <summary> Initializes a new instance of <see cref="WebComponent"/>. </summary>
        internal WebComponent()
        {
            RuleId = new ChangeTrackingList<string>();
            Cve = new ChangeTrackingList<CveDetails>();
            Ports = new ChangeTrackingList<PortDetails>();
            Sources = new ChangeTrackingList<SourceDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="WebComponent"/>. </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="version"></param>
        /// <param name="ruleId"></param>
        /// <param name="firstSeen"></param>
        /// <param name="lastSeen"></param>
        /// <param name="count"></param>
        /// <param name="cve"></param>
        /// <param name="endOfLife"></param>
        /// <param name="recent"></param>
        /// <param name="ports"></param>
        /// <param name="sources"></param>
        /// <param name="service"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WebComponent(string name, string type, string version, IReadOnlyList<string> ruleId, DateTimeOffset? firstSeen, DateTimeOffset? lastSeen, long? count, IReadOnlyList<CveDetails> cve, long? endOfLife, bool? recent, IReadOnlyList<PortDetails> ports, IReadOnlyList<SourceDetails> sources, string service, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Type = type;
            Version = version;
            RuleId = ruleId;
            FirstSeen = firstSeen;
            LastSeen = lastSeen;
            Count = count;
            Cve = cve;
            EndOfLife = endOfLife;
            Recent = recent;
            Ports = ports;
            Sources = sources;
            Service = service;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the type. </summary>
        public string Type { get; }
        /// <summary> Gets the version. </summary>
        public string Version { get; }
        /// <summary> Gets the rule id. </summary>
        public IReadOnlyList<string> RuleId { get; }
        /// <summary> Gets the first seen. </summary>
        public DateTimeOffset? FirstSeen { get; }
        /// <summary> Gets the last seen. </summary>
        public DateTimeOffset? LastSeen { get; }
        /// <summary> Gets the count. </summary>
        public long? Count { get; }
        /// <summary> Gets the cve. </summary>
        public IReadOnlyList<CveDetails> Cve { get; }
        /// <summary> Gets the end of life. </summary>
        public long? EndOfLife { get; }
        /// <summary> Gets the recent. </summary>
        public bool? Recent { get; }
        /// <summary> Gets the ports. </summary>
        public IReadOnlyList<PortDetails> Ports { get; }
        /// <summary> Gets the sources. </summary>
        public IReadOnlyList<SourceDetails> Sources { get; }
        /// <summary> Gets the service. </summary>
        public string Service { get; }
    }
}
