// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System;

namespace Pandora.Utility.Uptimes
{
    public interface IUptime<T> where T : class
    {
        DateTimeOffset ElapsedDateTime { get; }
    }
}
