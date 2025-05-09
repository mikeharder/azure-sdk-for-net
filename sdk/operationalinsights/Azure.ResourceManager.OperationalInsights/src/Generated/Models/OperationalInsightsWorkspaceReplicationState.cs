// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> The provisioning state of the replication. </summary>
    public readonly partial struct OperationalInsightsWorkspaceReplicationState : IEquatable<OperationalInsightsWorkspaceReplicationState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsWorkspaceReplicationState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OperationalInsightsWorkspaceReplicationState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string EnableRequestedValue = "EnableRequested";
        private const string EnablingValue = "Enabling";
        private const string DisableRequestedValue = "DisableRequested";
        private const string DisablingValue = "Disabling";
        private const string RollbackRequestedValue = "RollbackRequested";
        private const string RollingBackValue = "RollingBack";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";

        /// <summary> Succeeded. </summary>
        public static OperationalInsightsWorkspaceReplicationState Succeeded { get; } = new OperationalInsightsWorkspaceReplicationState(SucceededValue);
        /// <summary> EnableRequested. </summary>
        public static OperationalInsightsWorkspaceReplicationState EnableRequested { get; } = new OperationalInsightsWorkspaceReplicationState(EnableRequestedValue);
        /// <summary> Enabling. </summary>
        public static OperationalInsightsWorkspaceReplicationState Enabling { get; } = new OperationalInsightsWorkspaceReplicationState(EnablingValue);
        /// <summary> DisableRequested. </summary>
        public static OperationalInsightsWorkspaceReplicationState DisableRequested { get; } = new OperationalInsightsWorkspaceReplicationState(DisableRequestedValue);
        /// <summary> Disabling. </summary>
        public static OperationalInsightsWorkspaceReplicationState Disabling { get; } = new OperationalInsightsWorkspaceReplicationState(DisablingValue);
        /// <summary> RollbackRequested. </summary>
        public static OperationalInsightsWorkspaceReplicationState RollbackRequested { get; } = new OperationalInsightsWorkspaceReplicationState(RollbackRequestedValue);
        /// <summary> RollingBack. </summary>
        public static OperationalInsightsWorkspaceReplicationState RollingBack { get; } = new OperationalInsightsWorkspaceReplicationState(RollingBackValue);
        /// <summary> Failed. </summary>
        public static OperationalInsightsWorkspaceReplicationState Failed { get; } = new OperationalInsightsWorkspaceReplicationState(FailedValue);
        /// <summary> Canceled. </summary>
        public static OperationalInsightsWorkspaceReplicationState Canceled { get; } = new OperationalInsightsWorkspaceReplicationState(CanceledValue);
        /// <summary> Determines if two <see cref="OperationalInsightsWorkspaceReplicationState"/> values are the same. </summary>
        public static bool operator ==(OperationalInsightsWorkspaceReplicationState left, OperationalInsightsWorkspaceReplicationState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OperationalInsightsWorkspaceReplicationState"/> values are not the same. </summary>
        public static bool operator !=(OperationalInsightsWorkspaceReplicationState left, OperationalInsightsWorkspaceReplicationState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="OperationalInsightsWorkspaceReplicationState"/>. </summary>
        public static implicit operator OperationalInsightsWorkspaceReplicationState(string value) => new OperationalInsightsWorkspaceReplicationState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OperationalInsightsWorkspaceReplicationState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OperationalInsightsWorkspaceReplicationState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
