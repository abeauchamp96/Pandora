// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System;

namespace Pandora.Utility.Uptimes
{
    public interface IUptimeFormatter
    {
        string FormatUptime(DateTimeOffset currentTime, DateTimeOffset uptime);
    }
}
