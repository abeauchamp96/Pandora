// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System;
using FluentAssertions;
using Pandora.Utility.Extensions;
using Xunit;

namespace Pandora.Utility.Tests.Extensions
{
    public class DateTimeExtensionsTests
    {
        [Theory]
        [MemberData(nameof(GetIsBetweenValidTestData))]
        public void IsBetween_ShouldReturnTrue_WhenDateIsBetweenTwoDates(DateTime currentDate, DateTime start, DateTime end)
        {
            var result = currentDate.IsBetween(start, end);

            result.Should().BeTrue();
        }

        [Theory]
        [MemberData(nameof(GetIsBetweenInvalidTestData))]
        public void IsBetween_ShouldReturnFalse_WhenDateIsNotBetweenTwoDates(DateTime currentDate, DateTime start, DateTime end)
        {
            var result = currentDate.IsBetween(start, end);

            result.Should().BeFalse();
        }

        public static TheoryData<DateTime, DateTime, DateTime> GetIsBetweenValidTestData()
        {
            return new TheoryData<DateTime, DateTime, DateTime>
            {
                { new DateTime(2021, 12, 22), new DateTime(2021, 12, 21), new DateTime(2021, 12, 25) },
                { new DateTime(2021, 12, 25), new DateTime(2021, 12, 25), new DateTime(2021, 12, 26) },
                { new DateTime(2021, 12, 25), new DateTime(2021, 12, 24), new DateTime(2021, 12, 25) },
                { new DateTime(2021, 12, 25), new DateTime(2021, 12, 25), new DateTime(2021, 12, 25) },
                { new DateTime(2021, 12, 25), new DateTime(2021, 12, 21), new DateTime(2022, 01, 03) },
                { new DateTime(2020, 02, 29), new DateTime(2020, 02, 28), new DateTime(2020, 03, 01) }
            };
        }

        public static TheoryData<DateTime, DateTime, DateTime> GetIsBetweenInvalidTestData()
        {
            return new TheoryData<DateTime, DateTime, DateTime>
            {
                { new DateTime(2021, 12, 22), new DateTime(2021, 12, 23), new DateTime(2021, 12, 25) },
                { new DateTime(2021, 12, 25), new DateTime(2022, 01, 03), new DateTime(2021, 12, 21) },
            };
        }
    }
}
