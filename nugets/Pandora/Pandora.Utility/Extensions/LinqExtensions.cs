// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System.Collections.Generic;
using System.Linq;

namespace Pandora.Utility.Extensions
{
    public static class LinqExtensions
    {
        public static bool IsAnyOf<T>(this T value, params T[] values) => values.Contains(value);

        public static bool HasSingle<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable is ICollection<T> { Count: 1 })
                return true;

            using var enumerator = enumerable.GetEnumerator();
            return enumerator.MoveNext() && !enumerator.MoveNext();
        }

        public static IEnumerable<T> Page<T>(this IEnumerable<T> source, int skipCount, int takeCount)
            => source.Skip(skipCount).Take(takeCount);
    }
}
