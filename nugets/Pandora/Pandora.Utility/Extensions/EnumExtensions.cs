// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System;
using System.ComponentModel;

namespace Pandora.Utility.Extensions
{
    public static class EnumExtensions
    {
        public static string? GetDescription<TEnum>(this TEnum enumValue) where TEnum : Enum
        {
            var attribute = typeof(TEnum).GetAttributeFromField<DescriptionAttribute>(enumValue.ToString());
            return attribute is not null ? attribute.Description : string.Empty;
        }

        public static TEnum? ToEnum<TEnum>(this string value, bool ignoreCase = true) where TEnum : struct, Enum
            => Enum.TryParse<TEnum>(value, ignoreCase, out var parsedValue) ? parsedValue : null;
    }
}
