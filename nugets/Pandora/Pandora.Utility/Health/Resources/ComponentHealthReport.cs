// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

namespace Pandora.Utility.Health.Resources
{
    public record ComponentHealthReport(string ComponentName, string? Description, HealthReportStatus Status, string? Error);
}
