// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> A2A remove disk(s) input. </summary>
    public partial class A2ARemoveDisksContent : RemoveDisksProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="A2ARemoveDisksContent"/>. </summary>
        public A2ARemoveDisksContent()
        {
            VmDisksUris = new ChangeTrackingList<Uri>();
            VmManagedDisksIds = new ChangeTrackingList<string>();
            InstanceType = "A2A";
        }

        /// <summary> Initializes a new instance of <see cref="A2ARemoveDisksContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="vmDisksUris"> The list of vm disk vhd URIs. </param>
        /// <param name="vmManagedDisksIds"> The list of vm managed disk Ids. </param>
        internal A2ARemoveDisksContent(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<Uri> vmDisksUris, IList<string> vmManagedDisksIds) : base(instanceType, serializedAdditionalRawData)
        {
            VmDisksUris = vmDisksUris;
            VmManagedDisksIds = vmManagedDisksIds;
            InstanceType = instanceType ?? "A2A";
        }

        /// <summary> The list of vm disk vhd URIs. </summary>
        public IList<Uri> VmDisksUris { get; }
        /// <summary> The list of vm managed disk Ids. </summary>
        public IList<string> VmManagedDisksIds { get; }
    }
}
