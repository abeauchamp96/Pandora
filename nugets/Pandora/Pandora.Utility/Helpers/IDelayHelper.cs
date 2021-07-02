// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System;
using System.Threading.Tasks;

namespace Pandora.Utility.Helpers
{
    public interface IDelayHelper
    {
        Task DelayAsync(TimeSpan delay);
        Task DelayAsync(int milliseconds);
    }
}
