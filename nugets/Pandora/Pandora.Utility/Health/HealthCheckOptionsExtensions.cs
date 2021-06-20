// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Http;
using Pandora.Utility.Health.Mappers;
using System.Net.Mime;
using System.Text.Json;

namespace Pandora.Utility.Health
{
    public static class HealthCheckOptionsExtensions
    {
        public static HealthCheckOptions UseModuleResponseWriter(this HealthCheckOptions options)
        {
            options.ResponseWriter = async (context, report) =>
            {
                var moduleReport = report.ToResource();

                context.Response.ContentType = MediaTypeNames.Application.Json;
                await context.Response.WriteAsync(JsonSerializer.Serialize(moduleReport));
            };

            return options;
        }
    }
}
