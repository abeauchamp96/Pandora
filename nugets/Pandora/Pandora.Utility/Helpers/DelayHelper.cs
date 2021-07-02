// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System;
using System.Threading.Tasks;

namespace Pandora.Utility.Helpers
{
    internal sealed class DelayHelper : IDelayHelper
    {
        public Task DelayAsync(TimeSpan delay) => Task.Delay(delay);

        public Task DelayAsync(int milliseconds) => Task.Delay(milliseconds);
    }
}
