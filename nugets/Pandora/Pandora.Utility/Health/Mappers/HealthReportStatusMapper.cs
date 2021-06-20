// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using Microsoft.Extensions.Diagnostics.HealthChecks;
using Pandora.Utility.Health.Resources;

namespace Pandora.Utility.Health.Mappers
{
    public static class HealthReportStatusMapper
    {
        public static HealthReportStatus ToResource(this HealthStatus status) => status switch
        {
            HealthStatus.Unhealthy => HealthReportStatus.Unhealthy,
            HealthStatus.Degraded => HealthReportStatus.Degraded,
            HealthStatus.Healthy => HealthReportStatus.Healthy,
            _ => throw new System.NotImplementedException(),
        };
    }
}
