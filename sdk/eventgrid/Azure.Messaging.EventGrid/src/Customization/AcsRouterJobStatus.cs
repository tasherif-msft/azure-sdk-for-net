// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Messaging.EventGrid.Models
{
    /// <summary> Router Job Received Job Status. </summary>
    public readonly partial struct AcsRouterJobStatus : IEquatable<AcsRouterJobStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AcsRouterJobStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AcsRouterJobStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingClassificationValue = "PendingClassification";
        private const string QueuedValue = "Queued";
        private const string AssignedValue = "Assigned";
        private const string CompletedValue = "Completed";
        private const string ClosedValue = "Closed";
        private const string CancelledValue = "Cancelled";
        private const string ClassificationFailedValue = "ClassificationFailed";
        private const string CreatedValue = "Created";
        private const string PendingScheduleValue = "PendingSchedule";
        private const string ScheduledValue = "Scheduled";
        private const string ScheduleFailedValue = "ScheduleFailed";
        private const string WaitingForActivationValue = "WaitingForActivation";

        /// <summary> PendingClassification. </summary>
        public static AcsRouterJobStatus PendingClassification { get; } = new AcsRouterJobStatus(PendingClassificationValue);
        /// <summary> Queued. </summary>
        public static AcsRouterJobStatus Queued { get; } = new AcsRouterJobStatus(QueuedValue);
        /// <summary> Assigned. </summary>
        public static AcsRouterJobStatus Assigned { get; } = new AcsRouterJobStatus(AssignedValue);
        /// <summary> Completed. </summary>
        public static AcsRouterJobStatus Completed { get; } = new AcsRouterJobStatus(CompletedValue);
        /// <summary> Closed. </summary>
        public static AcsRouterJobStatus Closed { get; } = new AcsRouterJobStatus(ClosedValue);
        /// <summary> Cancelled. </summary>
        public static AcsRouterJobStatus Cancelled { get; } = new AcsRouterJobStatus(CancelledValue);
        /// <summary> ClassificationFailed. </summary>
        public static AcsRouterJobStatus ClassificationFailed { get; } = new AcsRouterJobStatus(ClassificationFailedValue);
        /// <summary> Created. </summary>
        public static AcsRouterJobStatus Created { get; } = new AcsRouterJobStatus(CreatedValue);
        /// <summary> PendingSchedule. </summary>
        public static AcsRouterJobStatus PendingSchedule { get; } = new AcsRouterJobStatus(PendingScheduleValue);
        /// <summary> Scheduled. </summary>
        public static AcsRouterJobStatus Scheduled { get; } = new AcsRouterJobStatus(ScheduledValue);
        /// <summary> ScheduleFailed. </summary>
        public static AcsRouterJobStatus ScheduleFailed { get; } = new AcsRouterJobStatus(ScheduleFailedValue);
        /// <summary> WaitingForActivation. </summary>
        public static AcsRouterJobStatus WaitingForActivation { get; } = new AcsRouterJobStatus(WaitingForActivationValue);
        /// <summary> Determines if two <see cref="AcsRouterJobStatus"/> values are the same. </summary>
        public static bool operator ==(AcsRouterJobStatus left, AcsRouterJobStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AcsRouterJobStatus"/> values are not the same. </summary>
        public static bool operator !=(AcsRouterJobStatus left, AcsRouterJobStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AcsRouterJobStatus"/>. </summary>
        public static implicit operator AcsRouterJobStatus(string value) => new AcsRouterJobStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AcsRouterJobStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AcsRouterJobStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
