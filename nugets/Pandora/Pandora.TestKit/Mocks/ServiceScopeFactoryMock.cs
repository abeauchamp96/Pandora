// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using Microsoft.Extensions.DependencyInjection;

namespace Pandora.TestKit.Mocks
{
    public sealed class ServiceScopeFactoryMock : AbstractMock<IServiceScopeFactory>
    {
        public void GivenAServiceScope(IServiceScope serviceScope)
            => this.Mock.Setup(m => m.CreateScope()).Returns(serviceScope);
    }
}
