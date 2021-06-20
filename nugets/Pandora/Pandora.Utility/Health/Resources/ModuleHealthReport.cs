// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System;
using System.Collections.Generic;

namespace Pandora.Utility.Health.Resources
{
    public record ModuleHealthReport(HealthReportStatus Status, TimeSpan Duration, IEnumerable<ComponentHealthReport> ComponentHealthReports);
}
