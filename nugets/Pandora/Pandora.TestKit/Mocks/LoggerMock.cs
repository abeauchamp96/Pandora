// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using Microsoft.Extensions.Logging;
using Moq;

namespace Pandora.TestKit.Mocks
{
    public sealed class LoggerMock<T> : AbstractMock<ILogger<T>>
    {
        public void LogInformationWasCalled(string message)
            => this.Mock.Verify(message, LogLevel.Information);

        public void LogInformationWasNotCalled(string message)
            => this.Mock.Verify(message, LogLevel.Information, Times.Never());

        public void LogDebugWasCalled(string message)
            => this.Mock.Verify(message, LogLevel.Debug);

        public void LogDebugWasNotCalled(string message)
            => this.Mock.Verify(message, LogLevel.Debug, Times.Never());

        public void LogWarningWasCalled(string message)
            => this.Mock.Verify(message, LogLevel.Warning);

        public void LogWarningWasNotCalled(string message)
            => this.Mock.Verify(message, LogLevel.Warning, Times.Never());

        public void LogErrorWasCalled(string message)
            => this.Mock.Verify(message, LogLevel.Error);

        public void LogErrorWasNotCalled(string message)
            => this.Mock.Verify(message, LogLevel.Error, Times.Never());

        public void LogTraceWasCalled(string message)
            => this.Mock.Verify(message, LogLevel.Trace);

        public void LogTraceWasNotCalled(string message)
            => this.Mock.Verify(message, LogLevel.Trace, Times.Never());

        public void LogCriticalWasCalled(string message)
            => this.Mock.Verify(message, LogLevel.Critical);

        public void LogCriticalWasNotCalled(string message)
            => this.Mock.Verify(message, LogLevel.Error, Times.Never());
    }
}
