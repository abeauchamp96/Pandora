// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using Microsoft.Extensions.Options;

namespace Pandora.TestKit.Mocks
{
    public sealed class OptionsMock<T> : AbstractMock<IOptions<T>> where T : class
    {
        public void GivenValue(T value)
            => this.Mock.SetupGet(o => o.Value).Returns(value);
    }
}
