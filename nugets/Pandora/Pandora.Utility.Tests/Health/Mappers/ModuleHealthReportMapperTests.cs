// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using FluentAssertions;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Pandora.Utility.Health.Mappers
{
    public class ModuleHealthReportMapperTests
    {
        [Fact]
        public void ToResource_ShouldConvertToResource()
        {
            var entry = new HealthReportEntry(HealthStatus.Healthy, "Description", TimeSpan.FromDays(1), null, null);
            var entries = new Dictionary<string, HealthReportEntry> { { "Component", entry } };
            var report = new HealthReport(entries, HealthStatus.Healthy, TimeSpan.FromDays(1));

            var resource = report.ToResource();

            resource.Status.Should().Be(report.Status);
            resource.Duration.Should().Be(report.TotalDuration);

            var component = resource.ComponentHealthReports.Single();
            component.ComponentName.Should().Be("Component");
            component.Status.Should().Be(entry.Status);
            component.Description.Should().Be(entry.Description);
            component.Error.Should().BeNull();
        }
    }
}
