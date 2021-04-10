// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using Pandora.Utility.Exceptions;
using System;

namespace Pandora.Utility
{
    internal sealed class UptimeRetriever<T> : IUptimeRetriever<T> where T : class
    {
        private readonly IUptime<T> uptime;
        private readonly IUptimeFormatter uptimeFormatter;

        public UptimeRetriever(IUptime<T> uptime, IUptimeFormatter uptimeFormatter)
        {
            this.uptime = uptime;
            this.uptimeFormatter = uptimeFormatter;
        }

        public string RetrieveFormattedUptime(DateTimeOffset currentTime)
        {
            if (IsCurrentTimeNotValid(currentTime))
                throw new InvalidUptimeException("Current time is not valid or less than the elapsed date");

            if (this.uptime.ElapsedDateTime == DateTimeOffset.MinValue)
                throw new InvalidUptimeException("Uptime is not valid");

            return this.uptimeFormatter.FormatUptime(currentTime, this.uptime.ElapsedDateTime);

            bool IsCurrentTimeNotValid(DateTimeOffset currentTime)
            {
                return currentTime == DateTimeOffset.MinValue ||
                    currentTime < this.uptime.ElapsedDateTime;
            }
        }
    }
}
