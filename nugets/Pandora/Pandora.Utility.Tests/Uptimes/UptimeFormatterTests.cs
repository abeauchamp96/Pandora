// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using FluentAssertions;
using System;
using Xunit;

namespace Pandora.Utility.Uptimes
{
    public class UptimeFormatterTests
    {
        private readonly IUptimeFormatter formatter;

        public UptimeFormatterTests()
        {
            this.formatter = new UptimeFormatter();
        }

        [Theory]
        [MemberData(nameof(GetFormattedUptimes))]
        public void FormatUptime_ShouldReturnAFormattedUptime(DateTimeOffset elapsedDatetime, string expectedFormattedUptime)
        {
            DateTimeOffset currentTime = new(new(2021, 12, 25, 11, 00, 00));

            var formattedUptime = this.formatter.FormatUptime(currentTime, elapsedDatetime);

            formattedUptime.Should().BeEquivalentTo(expectedFormattedUptime);
        }

        public static TheoryData<DateTimeOffset, string> GetFormattedUptimes() => new()
        {
            { new(new DateTime(2021, 12, 25, 10, 59, 40)), "20 Seconds" },
            { new(new DateTime(2021, 12, 25, 10, 27, 00)), "33 Minutes" },
            { new(new DateTime(2021, 12, 24, 23, 00, 00)), "12 Hours" },
            { new(new DateTime(2021, 12, 24, 06, 00, 00)), "01 Days, 05 Hours" },
            { new(new DateTime(2021, 11, 25, 06, 00, 00)), "01 Months, 05 Hours" },
            { new(new DateTime(2020, 12, 25, 06, 00, 00)), "01 Years, 05 Hours" },
            { new(new DateTime(2021, 11, 24, 06, 00, 00)), "01 Months, 01 Days, 05 Hours" },
            { new(new DateTime(2020, 11, 25, 06, 00, 00)), "01 Years, 01 Months, 05 Hours" },
            { new(new DateTime(2020, 12, 24, 06, 00, 00)), "01 Years, 01 Days, 05 Hours" },
            { new(new DateTime(2019, 10, 20, 07, 30, 00)), "02 Years, 02 Months, 05 Days, 03 Hours, 30 Minutes" },
            { new(new DateTime(2021, 11, 25, 10, 30, 00)), "01 Months, 30 Minutes" }
        };
    }
}
