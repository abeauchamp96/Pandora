// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System;

namespace Pandora.Utility.Extensions
{
    public static class DateTimeExtensions
    {
        public static bool IsBetween(this DateTime currentTime, DateTime startTime, DateTime endTime)
            => currentTime.Ticks >= startTime.Ticks && currentTime.Ticks <= endTime.Ticks;
    }
}
