// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using Moq;
using Pandora.TestKit;
using System;

namespace Pandora.Utility.Mocks
{
    public sealed class UptimeFormatterMock : AbstractMock<IUptimeFormatter>
    {
        internal void GivenAFormattedUptime(DateTimeOffset currentTime, DateTimeOffset uptime, string formattedUptime)
            => this.Mock.Setup(u => u.FormatUptime(currentTime, uptime)).Returns(formattedUptime);

        internal void FormatUptimeWasCalled(DateTimeOffset currentTime, DateTimeOffset uptime)
            => this.Mock.Verify(u => u.FormatUptime(currentTime, uptime));

        internal void FormatUptimeWasNotCalled()
            => this.Mock.Verify(u => u.FormatUptime(It.IsAny<DateTimeOffset>(), It.IsAny<DateTimeOffset>()), Times.Never);
    }
}
