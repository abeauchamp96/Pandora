// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using FluentAssertions;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Pandora.Utility.Health.Resources;
using Xunit;

namespace Pandora.Utility.Health.Mappers
{
    public class HealthReportStatusMapperTests
    {
        [Theory]
        [InlineData(HealthStatus.Unhealthy, HealthReportStatus.Unhealthy)]
        [InlineData(HealthStatus.Degraded, HealthReportStatus.Degraded)]
        [InlineData(HealthStatus.Healthy, HealthReportStatus.Healthy)]
        public void ToResource_ShouldConvertToResource(HealthStatus healthStatus, HealthReportStatus healthReportStatus)
        {
            var resource = healthStatus.ToResource();

            resource.Should().Be(healthReportStatus);
        }
    }
}
