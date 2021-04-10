// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System;

namespace Pandora.Utility
{
    public interface IUptimeRetriever<TUptime> where TUptime : class, IUptime<TUptime>
    {
        string RetrieveFormattedUptime(DateTimeOffset currentTime);
    }
}
