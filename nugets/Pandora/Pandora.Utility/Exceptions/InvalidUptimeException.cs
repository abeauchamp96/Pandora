// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System;

namespace Pandora.Utility.Exceptions
{
    public class InvalidUptimeException : Exception
    {
        public InvalidUptimeException()
        {
        }

        public InvalidUptimeException(string message) : base(message)
        {
        }
    }
}
