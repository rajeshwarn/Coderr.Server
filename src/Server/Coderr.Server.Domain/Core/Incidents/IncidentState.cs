﻿namespace Coderr.Server.Domain.Core.Incidents
{
    /// <summary>
    ///     Current state of an incident
    /// </summary>
    public enum IncidentState
    {
        /// <summary>
        ///     Incident have arrived but have not yet been categorized.
        /// </summary>
        New = 0,

        /// <summary>
        ///     Incident should be fixed (assigned)
        /// </summary>
        Active = 1,

        /// <summary>
        ///     Ignore all reports for this incident
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         All inbound reports will be discarded, no notifications will be sent to this incident and it's not show among
        ///         new or activate incidents
        ///     </para>
        /// </remarks>
        Ignored = 2,

        /// <summary>
        ///     Incident have been corrected.
        /// </summary>
        Closed = 3,

        /// <summary>
        /// We received a new error report on a closed incident (used in history table)
        /// </summary>
        ReOpened = 4,
    }
}