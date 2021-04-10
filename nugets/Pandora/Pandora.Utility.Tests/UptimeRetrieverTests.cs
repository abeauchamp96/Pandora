// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using FluentAssertions;
using Pandora.Utility.Exceptions;
using Pandora.Utility.Mocks;
using System;
using Xunit;

namespace Pandora.Utility
{
    public class UptimeRetrieverTests
    {
        private readonly UptimeMock uptimeMock = new();
        private readonly UptimeFormatterMock uptimeFormatterMock = new();

        private readonly DateTimeOffset currentTime = new(new DateTime(2021, 08, 10));
        private readonly DateTimeOffset elapsedDatetime = new(new DateTime(2021, 08, 09));
        private readonly IUptimeRetriever<FakeUptime> retriever;

        public UptimeRetrieverTests()
        {
            this.uptimeMock.GivenAnElapsedDateTime(this.elapsedDatetime);
            this.retriever = new UptimeRetriever<FakeUptime>(this.uptimeMock.Instance, this.uptimeFormatterMock.Instance);
        }

        [Fact]
        public void RetrieveFormattedUptime_ShouldUseTheFormatter()
        {
            this.retriever.RetrieveFormattedUptime(this.currentTime);

            this.uptimeFormatterMock.FormatUptimeWasCalled(this.currentTime, this.elapsedDatetime);
        }

        [Fact]
        public void RetrieveFormattedUptime_ShouldReturnTheFormattedUptime()
        {
            const string formattedUptime = "text";

            this.uptimeFormatterMock.GivenAFormattedUptime(this.currentTime, this.elapsedDatetime, formattedUptime);

            var result = this.retriever.RetrieveFormattedUptime(this.currentTime);

            result.Should().BeEquivalentTo(formattedUptime);
        }

        [Fact]
        public void RetrieveFormattedUptime_ShouldThrowsAnInvalidUptimeException_WhenCurrentDateIsEqualToMinValue()
        {
            Action action = () => this.retriever.RetrieveFormattedUptime(DateTimeOffset.MinValue);

            action.Should()
                .ThrowExactly<InvalidUptimeException>()
                .WithMessage("Current time is not valid or less than the elapsed date");

            this.uptimeFormatterMock.FormatUptimeWasNotCalled();
        }

        [Fact]
        public void RetrieveFormattedUptime_ShouldThrowsAnInvalidUptimeException_WhenCurrentTimeIsLessThanUptime()
        {
            this.uptimeMock.GivenAnElapsedDateTime(DateTimeOffset.Now.AddDays(1));

            Action action = () => this.retriever.RetrieveFormattedUptime(DateTimeOffset.Now);

            action.Should()
                .ThrowExactly<InvalidUptimeException>()
                .WithMessage("Current time is not valid or less than the elapsed date");

            this.uptimeFormatterMock.FormatUptimeWasNotCalled();
        }

        [Fact]
        public void RetrieveFormattedUptime_ShouldThrowsAnInvalidUptimeException_WhenElapsedTimeIsEqualToMinValue()
        {
            this.uptimeMock.GivenAnElapsedDateTime(DateTimeOffset.MinValue);

            Action action = () => this.retriever.RetrieveFormattedUptime(DateTimeOffset.Now);

            action.Should()
                .ThrowExactly<InvalidUptimeException>()
                .WithMessage("Uptime is not valid");

            this.uptimeFormatterMock.FormatUptimeWasNotCalled();
        }
    }
}
