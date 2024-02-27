// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AcsEmailDeliveryReportReceivedEventDataConverter))]
    public partial class AcsEmailDeliveryReportReceivedEventData
    {
        internal static AcsEmailDeliveryReportReceivedEventData DeserializeAcsEmailDeliveryReportReceivedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> sender = default;
            Optional<string> recipient = default;
            Optional<string> messageId = default;
            Optional<AcsEmailDeliveryReportStatus> status = default;
            Optional<AcsEmailDeliveryReportStatusDetails> deliveryStatusDetails = default;
            Optional<DateTimeOffset> deliveryAttemptTimeStamp = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sender"u8))
                {
                    sender = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recipient"u8))
                {
                    recipient = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("messageId"u8))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new AcsEmailDeliveryReportStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deliveryStatusDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deliveryStatusDetails = AcsEmailDeliveryReportStatusDetails.DeserializeAcsEmailDeliveryReportStatusDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("deliveryAttemptTimeStamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deliveryAttemptTimeStamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new AcsEmailDeliveryReportReceivedEventData(
                sender.Value,
                recipient.Value,
                messageId.Value,
                Optional.ToNullable(status),
                deliveryStatusDetails.Value,
                Optional.ToNullable(deliveryAttemptTimeStamp));
        }

        internal partial class AcsEmailDeliveryReportReceivedEventDataConverter : JsonConverter<AcsEmailDeliveryReportReceivedEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsEmailDeliveryReportReceivedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override AcsEmailDeliveryReportReceivedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsEmailDeliveryReportReceivedEventData(document.RootElement);
            }
        }
    }
}
