// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using Microsoft.Extensions.Diagnostics.HealthChecks;
using Pandora.Utility.Health.Resources;

namespace Pandora.Utility.Health.Mappers
{
    public static class ComponentHealthReportMapper
    {
        public static ComponentHealthReport ToResource(this HealthReportEntry entry, string componentName)
            => new(componentName, entry.Description, entry.Status.ToResource(), entry.Exception?.Message);
    }
}
