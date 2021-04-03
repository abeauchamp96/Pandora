// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using Microsoft.Extensions.DependencyInjection;
using System;

namespace Pandora.TestKit.Mocks
{
    public sealed class ServiceScopeMock : AbstractMock<IServiceScope>
    {
        public void GivenAServiceProvider(IServiceProvider serviceProvider)
            => this.Mock.SetupGet(s => s.ServiceProvider).Returns(serviceProvider);
    }
}
