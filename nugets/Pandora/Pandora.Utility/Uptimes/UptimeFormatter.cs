// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using NodaTime;
using NodaTime.Extensions;
using System;
using System.Linq;

namespace Pandora.Utility.Uptimes
{
    internal sealed class UptimeFormatter : IUptimeFormatter
    {
        public string FormatUptime(DateTimeOffset currentTime, DateTimeOffset uptime)
        {
            var now = currentTime.ToOffsetDateTime();
            var then = uptime.ToOffsetDateTime();

            var period = Period.Between(then.LocalDateTime, now.LocalDateTime);

            return new[]
            {
                FormatTimeUnitOrEmpty(period.Years, nameof(period.Years)),
                FormatTimeUnitOrEmpty(period.Months, nameof(period.Months)),
                FormatTimeUnitOrEmpty(period.Days, nameof(period.Days)),
                FormatTimeUnitOrEmpty(period.Hours, nameof(period.Hours)),
                FormatTimeUnitOrEmpty(period.Minutes, nameof(period.Minutes)),
                FormatTimeUnitOrEmpty(period.Seconds, nameof(period.Seconds))
            }
            .Where(unit => !string.IsNullOrEmpty(unit))
            .Aggregate((currentFormat, nextUnit) => $"{currentFormat}, {nextUnit}");

            static string FormatTimeUnitOrEmpty(long time, string unit)
                => time != 0 ? $"{time:D2} {unit}" : string.Empty;
        }
    }
}
