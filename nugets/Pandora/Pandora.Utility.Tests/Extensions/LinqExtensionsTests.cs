// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using FluentAssertions;
using System.Linq;
using Xunit;

namespace Pandora.Utility.Extensions
{
    public class LinqExtensionsTests
    {
        [Fact]
        public void IsAnyOf_ShouldReturnTrue_WhenHavingOneElementMatchFromTheList()
        {
            var value = 3;

            var isFound = value.IsAnyOf(1, 2, 3);

            isFound.Should().BeTrue();
        }

        [Fact]
        public void IsAnyOf_ShouldReturnFalse_WhenHavingNoElementsThatMatchFromTheList()
        {
            var value = 3;

            var notFound = value.IsAnyOf(4, 5, 6);

            notFound.Should().BeFalse();
        }

        [Fact]
        public void IsAnyOf_ShouldReturnFalse_WhenListIsEmpty()
        {
            var value = 3;

            var notFound = value.IsAnyOf();

            notFound.Should().BeFalse();
        }

        [Fact]
        public void Page_ShouldSkipElementsFromACount()
        {
            var list = new[] { 1, 2, 3, 4, 5 };

            var page = list.Page(2, 5);

            page.Should().Contain(new[] { 3, 4, 5 });
        }

        [Fact]
        public void Page_ShouldTakeElementsFromACount()
        {
            var list = new[] { 1, 2, 3, 4, 5 };

            var page = list.Page(0, 3);

            page.Should().Contain(new[] { 1, 2, 3 });
        }

        [Fact]
        public void Page_ShouldDoNothing_WhenListIsEmpty()
        {
            var list = Enumerable.Empty<int>();

            var emptyPage = list.Page(2, 3);

            emptyPage.Should().BeEmpty();
        }
    }
}
