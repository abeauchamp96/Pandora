// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using Pandora.TestKit;
using System;

namespace Pandora.Utility.Mocks
{
    public sealed class UptimeMock : AbstractMock<IUptime<UptimeMock>>
    {
        internal void GivenAnElapsedDateTime(DateTimeOffset elapsedDateTime)
            => this.Mock.SetupGet(u => u.ElapsedDateTime).Returns(elapsedDateTime);
    }
}
