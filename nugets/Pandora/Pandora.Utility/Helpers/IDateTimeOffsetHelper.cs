// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System;

namespace Pandora.Utility.Helpers
{
    public interface IDateTimeOffsetHelper
    {
        DateTimeOffset GetNowOffset();
        DateTimeOffset GetUtcNowOffset();
    }
}
