// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System.Threading.Tasks;

namespace Pandora.Data.Migrations
{
    public interface IMigrationExecutor
    {
        Task ExecuteAsync(string migrationScript);
    }
}
