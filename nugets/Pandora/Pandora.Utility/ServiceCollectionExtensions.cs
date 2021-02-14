﻿// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using Microsoft.Extensions.DependencyInjection;
using Pandora.Utility.Helpers;

namespace Pandora.Utility
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddHelpers(this IServiceCollection services)
        {
            return services
                .AddTransient<IDateTimeHelper, DateTimeHelper>()
                .AddTransient<IDateTimeOffsetHelper, DateTimeOffsetHelper>()
                .AddTransient<IDirectoryHelper, DirectoryHelper>()
                .AddTransient<IFileHelper, FileHelper>()
                .AddTransient<IFileReaderHelper, FileReaderHelper>()
                .AddTransient<IFileWriterHelper, FileWriterHelper>()
                .AddTransient<IPathHelper, PathHelper>();
        }
    }
}