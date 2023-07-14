// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    public partial class ToneInfo
    {
        internal static ToneInfo DeserializeToneInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int sequenceId = default;
            DtmfTone tone = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sequenceId"u8))
                {
                    sequenceId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("tone"u8))
                {
                    tone = new DtmfTone(property.Value.GetString());
                    continue;
                }
            }
            return new ToneInfo(sequenceId, tone);
        }
    }
}
