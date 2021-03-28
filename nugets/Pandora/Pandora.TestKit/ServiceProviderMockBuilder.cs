// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;

namespace Pandora.TestKit
{
    public class ServiceProviderMockBuilder
    {
        private readonly Mock<IServiceProvider> serviceProviderMock = new();

        public ServiceProviderMockBuilder AddService<TService>(TService service)
        {
            this.serviceProviderMock.Setup(s => s.GetService(typeof(TService))).Returns(service);
            return this;
        }

        public Mock<IServiceProvider> BuildServiceProvider() => this.serviceProviderMock;

        public Mock<IServiceScopeFactory> BuildServiceScopeFactory()
        {
            Mock<IServiceScope> serviceScopeMock = new();
            serviceScopeMock.SetupGet(s => s.ServiceProvider).Returns(this.serviceProviderMock.Object);

            Mock<IServiceScopeFactory> serviceScopeFactoryMock = new();
            serviceScopeFactoryMock.Setup(s => s.CreateScope()).Returns(serviceScopeMock.Object);

            return serviceScopeFactoryMock;
        }
    }
}
