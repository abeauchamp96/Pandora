// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System;

namespace Pandora.Utility.Helpers
{
    internal sealed class DateTimeHelper : IDateTimeHelper
    {
        public DateTime GetNow() => DateTime.Now;

        public DateTime GetUtcNow() => DateTime.UtcNow;
    }
}
