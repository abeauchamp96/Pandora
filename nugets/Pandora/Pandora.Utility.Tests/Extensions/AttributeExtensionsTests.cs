// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using FluentAssertions;
using System;
using System.ComponentModel;
using Xunit;

namespace Pandora.Utility.Extensions
{
    public class AttributeExtensionsTests
    {
        private readonly FakeClass fakeClass;

        public AttributeExtensionsTests() => this.fakeClass = new FakeClass();

        [Fact]
        public void GetAttributeFromMethod_ShouldGetAttributeFromTheMethod()
        {
            var attribute = this.fakeClass.GetType()
                .GetAttributeFromMethod<DescriptionAttribute>(nameof(this.fakeClass.Method), Type.EmptyTypes);

            attribute.Should().BeOfType<DescriptionAttribute>();
        }

        [Fact]
        public void GetAttributeFromMethod_ShouldReturnNull_WhenDoesNotFoundMethod()
        {
            var attribute = this.fakeClass.GetType()
                .GetAttributeFromMethod<DescriptionAttribute>("BadMethod");

            attribute.Should().BeNull();
        }

        [Fact]
        public void GetAttributeFromMethod_ShouldReturnNull_WhenDoesNotFounAttribute()
        {
            var attribute = this.fakeClass.GetType()
                .GetAttributeFromMethod<FactAttribute>(nameof(this.fakeClass.Method), Type.EmptyTypes);

            attribute.Should().BeNull();
        }

        [Fact]
        public void GetAttributeFromMethod_ShouldGetAttributeFromTheMethodWithParameters()
        {
            var attribute = this.fakeClass.GetType()
                .GetAttributeFromMethod<DescriptionAttribute>(nameof(this.fakeClass.Method), typeof(int));

            attribute.Should().BeOfType<DescriptionAttribute>();
        }

        [Fact]
        public void GetAttributeFromMethod_ShouldReturnNull_WhenDoesNotFoundMethodWithParameters()
        {
            var attribute = this.fakeClass.GetType()
                .GetAttributeFromMethod<DescriptionAttribute>("BadMethod", typeof(int));

            attribute.Should().BeNull();
        }

        [Fact]
        public void GetAttributeFromMethod_ShouldReturnNull_WhenDoesNotFoundAttributeWithParameters()
        {
            var attribute = this.fakeClass.GetType()
                .GetAttributeFromMethod<FactAttribute>(nameof(this.fakeClass.Method), typeof(int));

            attribute.Should().BeNull();
        }

        [Fact]
        public void GetAttributeFromField_ShouldGetAttributeFromTheField()
        {
            var attribute = typeof(FakeEnum)
                .GetAttributeFromField<DescriptionAttribute>(nameof(FakeEnum.A));

            attribute.Should().BeOfType<DescriptionAttribute>();
        }

        [Fact]
        public void GetAttributeFromField_ShouldReturnNull_WhenDoesNotFoundField()
        {
            var attribute = typeof(FakeEnum)
                .GetAttributeFromField<DescriptionAttribute>("C");

            attribute.Should().BeNull();
        }

        [Fact]
        public void GetAttributeFromField_ShouldReturnNull_WhenDoesNotFoundAttribute()
        {
            var attribute = typeof(FakeEnum)
                .GetAttributeFromField<FactAttribute>(nameof(FakeEnum.A));

            attribute.Should().BeNull();
        }

        [Fact]
        public void GetAttributeFromProperty_ShouldGetAttributeFromTheProperty()
        {
            var attribute = this.fakeClass.GetType()
                .GetAttributeFromProperty<DescriptionAttribute>(nameof(this.fakeClass.Test));

            attribute.Should().BeOfType<DescriptionAttribute>();
        }

        [Fact]
        public void GetAttributeFromProperty_ShouldReturnNull_WhenDoesNotFoundProperty()
        {
            var attribute = this.fakeClass.GetType()
                .GetAttributeFromProperty<FactAttribute>("BadProperty");

            attribute.Should().BeNull();
        }

        [Fact]
        public void GetAttributeFromProperty_ShouldReturnNull_WhenDoesNotFoundAttribute()
        {
            var attribute = this.fakeClass.GetType()
                .GetAttributeFromProperty<FactAttribute>(nameof(this.fakeClass.Test));

            attribute.Should().BeNull();
        }
    }

    public class FakeClass
    {
        [Description]
        public int Test { get; set; }

        [Description]
        public static void Method()
        {
        }

        [Description]
        public static int Method(int a) => a;
    }

    public enum FakeEnum
    {
        [Description]
        A,
        B
    }
}
