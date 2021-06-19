// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using FluentAssertions;
using Xunit;

namespace Pandora.TestKit.Validators
{
    public class InstanceValidatorsTests
    {
        [Fact]
        public void IsValid_ShouldReturnTrue_WhenAllValidationsAreValid()
        {
            var validators = InstanceValidator<int>.Build()
                .WithValidation(x => x > 10)
                .WithValidation(x => x.Should().Be(12));

            var result = validators.IsValid(12);

            result.Should().BeTrue();
        }

        [Fact]
        public void IsValid_ShouldReturnFalse_WhenAtLeastOneValidationIsNotValid()
        {
            var validators = InstanceValidator<int>.Build()
                .WithValidation(x => x > 12)
                .WithValidation(x => x == 13);

            var result = validators.IsValid(14);

            result.Should().BeFalse();
        }
    }
}
