// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System;

namespace Pandora.Utility
{
    public interface IUptimeRetriever<T> where T : class
    {
        string RetrieveFormattedUptime(DateTimeOffset currentTime);
    }
}
