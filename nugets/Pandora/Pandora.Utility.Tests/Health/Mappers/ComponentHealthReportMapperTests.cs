// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using FluentAssertions;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using Xunit;

namespace Pandora.Utility.Health.Mappers
{
    public class ComponentHealthReportMapperTests
    {
        [Fact]
        public void ToResource_ShouldConvertToResource()
        {
            var entry = new HealthReportEntry(HealthStatus.Healthy, "Description", TimeSpan.FromDays(1), new Exception("Exception"), null);

            var resource = entry.ToResource("Component");

            resource.ComponentName.Should().Be("Component");
            resource.Description.Should().Be(entry.Description);
            resource.Error.Should().Be(entry.Exception!.Message);
            resource.Status.Should().Be(entry.Status);
        }
    }
}
