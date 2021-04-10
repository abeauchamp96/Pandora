// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using Pandora.TestKit;
using System;

namespace Pandora.Utility.Mocks
{
    public sealed class UptimeMock : AbstractMock<IUptime<FakeUptime>>
    {
        internal void GivenAnElapsedDateTime(DateTimeOffset elapsedDateTime)
            => this.Mock.SetupGet(u => u.ElapsedDateTime).Returns(elapsedDateTime);
    }

    public sealed record FakeUptime(DateTimeOffset ElapsedDateTime) : IUptime<FakeUptime>;
}
