// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System;

namespace Pandora.Utility.Helpers
{
    internal sealed class RandomHelper : IRandomHelper
    {
        public int Generate(int min, int max)
            => new Random().Next(min, max);
    }
}
