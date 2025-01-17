// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The IpAddressAsset. </summary>
    public partial class IpAddressAsset : InventoryAsset
    {
        /// <summary> Initializes a new instance of <see cref="IpAddressAsset"/>. </summary>
        internal IpAddressAsset()
        {
            Asns = new ChangeTrackingList<ObservedLong>();
            Reputations = new ChangeTrackingList<ReputationDetails>();
            WebComponents = new ChangeTrackingList<WebComponent>();
            NetRanges = new ChangeTrackingList<ObservedString>();
            Headers = new ChangeTrackingList<ObservedHeader>();
            Attributes = new ChangeTrackingList<AttributeDetails>();
            Cookies = new ChangeTrackingList<CookieDetails>();
            SslCerts = new ChangeTrackingList<SslCertAsset>();
            Services = new ChangeTrackingList<AssetService>();
            IpBlocks = new ChangeTrackingList<IpBlock>();
            Sources = new ChangeTrackingList<SourceDetails>();
            Banners = new ChangeTrackingList<BannerDetails>();
            ScanMetadata = new ChangeTrackingList<ScanMetadata>();
            NsRecord = new ChangeTrackingList<ObservedBoolean>();
            MxRecord = new ChangeTrackingList<ObservedBoolean>();
            Location = new ChangeTrackingList<ObservedLocation>();
            Hosts = new ChangeTrackingList<ObservedString>();
            Nxdomain = new ChangeTrackingList<ObservedBoolean>();
            SslServerConfig = new ChangeTrackingList<SslServerConfig>();
        }

        /// <summary> Initializes a new instance of <see cref="IpAddressAsset"/>. </summary>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="ipAddress"></param>
        /// <param name="asns"></param>
        /// <param name="reputations"></param>
        /// <param name="webComponents"></param>
        /// <param name="netRanges"></param>
        /// <param name="headers"></param>
        /// <param name="attributes"></param>
        /// <param name="cookies"></param>
        /// <param name="sslCerts"></param>
        /// <param name="services"></param>
        /// <param name="ipBlocks"></param>
        /// <param name="sources"></param>
        /// <param name="firstSeen"></param>
        /// <param name="lastSeen"></param>
        /// <param name="count"></param>
        /// <param name="banners"></param>
        /// <param name="scanMetadata"></param>
        /// <param name="nsRecord"></param>
        /// <param name="mxRecord"></param>
        /// <param name="location"></param>
        /// <param name="hosts"></param>
        /// <param name="nxdomain"></param>
        /// <param name="sslServerConfig"></param>
        /// <param name="ipv4"></param>
        /// <param name="ipv6"></param>
        internal IpAddressAsset(IDictionary<string, BinaryData> serializedAdditionalRawData, string ipAddress, IReadOnlyList<ObservedLong> asns, IReadOnlyList<ReputationDetails> reputations, IReadOnlyList<WebComponent> webComponents, IReadOnlyList<ObservedString> netRanges, IReadOnlyList<ObservedHeader> headers, IReadOnlyList<AttributeDetails> attributes, IReadOnlyList<CookieDetails> cookies, IReadOnlyList<SslCertAsset> sslCerts, IReadOnlyList<AssetService> services, IReadOnlyList<IpBlock> ipBlocks, IReadOnlyList<SourceDetails> sources, DateTimeOffset? firstSeen, DateTimeOffset? lastSeen, long? count, IReadOnlyList<BannerDetails> banners, IReadOnlyList<ScanMetadata> scanMetadata, IReadOnlyList<ObservedBoolean> nsRecord, IReadOnlyList<ObservedBoolean> mxRecord, IReadOnlyList<ObservedLocation> location, IReadOnlyList<ObservedString> hosts, IReadOnlyList<ObservedBoolean> nxdomain, IReadOnlyList<SslServerConfig> sslServerConfig, bool? ipv4, bool? ipv6) : base(serializedAdditionalRawData)
        {
            IpAddress = ipAddress;
            Asns = asns;
            Reputations = reputations;
            WebComponents = webComponents;
            NetRanges = netRanges;
            Headers = headers;
            Attributes = attributes;
            Cookies = cookies;
            SslCerts = sslCerts;
            Services = services;
            IpBlocks = ipBlocks;
            Sources = sources;
            FirstSeen = firstSeen;
            LastSeen = lastSeen;
            Count = count;
            Banners = banners;
            ScanMetadata = scanMetadata;
            NsRecord = nsRecord;
            MxRecord = mxRecord;
            Location = location;
            Hosts = hosts;
            Nxdomain = nxdomain;
            SslServerConfig = sslServerConfig;
            Ipv4 = ipv4;
            Ipv6 = ipv6;
        }

        /// <summary> Gets the ip address. </summary>
        public string IpAddress { get; }
        /// <summary> Gets the asns. </summary>
        public IReadOnlyList<ObservedLong> Asns { get; }
        /// <summary> Gets the reputations. </summary>
        public IReadOnlyList<ReputationDetails> Reputations { get; }
        /// <summary> Gets the web components. </summary>
        public IReadOnlyList<WebComponent> WebComponents { get; }
        /// <summary> Gets the net ranges. </summary>
        public IReadOnlyList<ObservedString> NetRanges { get; }
        /// <summary> Gets the headers. </summary>
        public IReadOnlyList<ObservedHeader> Headers { get; }
        /// <summary> Gets the attributes. </summary>
        public IReadOnlyList<AttributeDetails> Attributes { get; }
        /// <summary> Gets the cookies. </summary>
        public IReadOnlyList<CookieDetails> Cookies { get; }
        /// <summary> Gets the ssl certs. </summary>
        public IReadOnlyList<SslCertAsset> SslCerts { get; }
        /// <summary> Gets the services. </summary>
        public IReadOnlyList<AssetService> Services { get; }
        /// <summary> Gets the ip blocks. </summary>
        public IReadOnlyList<IpBlock> IpBlocks { get; }
        /// <summary> Gets the sources. </summary>
        public IReadOnlyList<SourceDetails> Sources { get; }
        /// <summary> Gets the first seen. </summary>
        public DateTimeOffset? FirstSeen { get; }
        /// <summary> Gets the last seen. </summary>
        public DateTimeOffset? LastSeen { get; }
        /// <summary> Gets the count. </summary>
        public long? Count { get; }
        /// <summary> Gets the banners. </summary>
        public IReadOnlyList<BannerDetails> Banners { get; }
        /// <summary> Gets the scan metadata. </summary>
        public IReadOnlyList<ScanMetadata> ScanMetadata { get; }
        /// <summary> Gets the ns record. </summary>
        public IReadOnlyList<ObservedBoolean> NsRecord { get; }
        /// <summary> Gets the mx record. </summary>
        public IReadOnlyList<ObservedBoolean> MxRecord { get; }
        /// <summary> Gets the location. </summary>
        public IReadOnlyList<ObservedLocation> Location { get; }
        /// <summary> Gets the hosts. </summary>
        public IReadOnlyList<ObservedString> Hosts { get; }
        /// <summary> Gets the nxdomain. </summary>
        public IReadOnlyList<ObservedBoolean> Nxdomain { get; }
        /// <summary> Gets the ssl server config. </summary>
        public IReadOnlyList<SslServerConfig> SslServerConfig { get; }
        /// <summary> Gets the ipv 4. </summary>
        public bool? Ipv4 { get; }
        /// <summary> Gets the ipv 6. </summary>
        public bool? Ipv6 { get; }
    }
}
