// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using Microsoft.Extensions.Diagnostics.HealthChecks;
using Pandora.Utility.Health.Resources;
using System.Linq;

namespace Pandora.Utility.Health.Mappers
{
    public static class ModuleHealthReportMapper
    {
        public static ModuleHealthReport ToResource(this HealthReport report)
        {
            var components = report.Entries
                .Select(entry => entry.Value.ToResource(entry.Key));

            return new(report.Status.ToResource(), report.TotalDuration, components);
        }
    }
}
