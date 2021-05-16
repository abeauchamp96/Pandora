// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using Microsoft.Extensions.Options;
using Moq;

namespace Pandora.TestKit.Mocks
{
    public sealed class OptionsSnapshotMock<T> : AbstractMock<IOptionsSnapshot<T>> where T : class
    {
        public void GivenGet(string name, T value)
            => this.Mock.Setup(o => o.Get(name)).Returns(value);

        public void GetWasCalled(string name)
            => this.Mock.Verify(o => o.Get(name));

        public void GetWasCalled(string name, Times times)
            => this.Mock.Verify(o => o.Get(name), times);

        public void GetWasNotCalled(string name)
            => this.Mock.Verify(o => o.Get(name), Times.Never);

        public void GivenValue(T value)
            => this.Mock.SetupGet(o => o.Value).Returns(value);
    }
}
