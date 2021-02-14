// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System;

namespace Pandora.Utility.Helpers
{
    internal sealed class DateTimeOffsetHelper : IDateTimeOffsetHelper
    {
        public DateTimeOffset GetNowOffset() => DateTimeOffset.Now;
        public DateTimeOffset GetUtcNowOffset() => DateTimeOffset.UtcNow;
    }
}
