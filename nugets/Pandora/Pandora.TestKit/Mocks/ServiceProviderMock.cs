// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using Microsoft.Extensions.DependencyInjection;
using System;

namespace Pandora.TestKit.Mocks
{
    public sealed class ServiceProviderMock : AbstractMock<IServiceProvider>
    {
        public void GivenAService<TService>(TService service)
            => this.Mock.Setup(s => s.GetService(typeof(TService))).Returns(service);
    }
}
