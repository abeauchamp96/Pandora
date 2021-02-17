// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using FluentAssertions;
using System.ComponentModel;
using Xunit;

namespace Pandora.Utility.Extensions
{
    public class EnumExtensionsTests
    {
        [Fact]
        public void ToEnum_ShouldConvertStringValueToEnum()
        {
            var value = "EnumValue1".ToEnum<AnotherEnum>();

            value.Should().Be(AnotherEnum.EnumValue1);
        }

        [Fact]
        public void ToEnum_ShouldConvertStringValueToEnum_WhenIgnoreCaseIsTrue()
        {
            var value = "enumvalue1".ToEnum<AnotherEnum>();

            value.Should().Be(AnotherEnum.EnumValue1);
        }

        [Fact]
        public void ToEnum_ShouldReturnNull_WhenDoesNotIgnoreCase()
        {
            var value = "enumvalue1".ToEnum<AnotherEnum>(false);

            value.Should().BeNull();
        }

        [Fact]
        public void ToEnum_ShouldReturnNull_WhenValueDoesExistInEnum()
        {
            var value = "enumvalue5".ToEnum<AnotherEnum>();

            value.Should().BeNull();
        }

        [Fact]
        public void GetDescription_ShouldReturnTheDescription()
        {
            var description = AnotherEnum.EnumValue1.GetDescription();

            description.Should().Be("enum value");
        }

        [Fact]
        public void GetDescription_ShouldReturnNull_WhenDoesNotHaveTheField()
        {
            var invalidValue = (AnotherEnum)999;

            var description = invalidValue.GetDescription();

            description.Should().BeNullOrEmpty();
        }

        [Fact]
        public void GetDescription_ShouldReturnNull_WhenDoesNotHaveDescriptionAttribute()
        {
            var description = AnotherEnum.EnumValue2.GetDescription();

            description.Should().BeNullOrEmpty();
        }
    }

    public enum AnotherEnum
    {
        [Description("enum value")]
        EnumValue1,
        EnumValue2,
        EnumValue3
    }
}
