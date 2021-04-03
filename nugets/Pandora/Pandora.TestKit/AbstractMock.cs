// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using Moq;

namespace Pandora.TestKit
{
    public abstract class AbstractMock<T> where T : class
    {
        public T Instance => this.Mock.Object;
        protected Mock<T> Mock { get; } = new Mock<T>();

        public void ResetCallCount()
            => this.Mock.Invocations.Clear();
    }
}
