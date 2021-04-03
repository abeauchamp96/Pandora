// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using Pandora.TestKit.Mocks;

namespace Pandora.TestKit
{
    public class ServiceProviderMockBuilder
    {
        private readonly ServiceProviderMock serviceProviderMock = new();
        private readonly ServiceScopeMock serviceScopeMock = new();
        private readonly ServiceScopeFactoryMock serviceScopeFactoryMock = new();

        public ServiceProviderMockBuilder AddService<TService>(TService service)
        {
            this.serviceProviderMock.GivenAService(service);
            return this;
        }

        public ServiceProviderMock BuildServiceProvider() => this.serviceProviderMock;

        public ServiceScopeFactoryMock BuildServiceScopeFactory()
        {
            this.serviceScopeMock.GivenAServiceProvider(this.serviceProviderMock.Instance);
            this.serviceScopeFactoryMock.GivenAServiceScope(this.serviceScopeMock.Instance);

            return this.serviceScopeFactoryMock;
        }
    }
}
