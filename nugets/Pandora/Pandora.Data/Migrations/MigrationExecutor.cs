// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using Dapper;
using System.Threading.Tasks;

namespace Pandora.Data.Migrations
{
    internal sealed class MigrationExecutor : IMigrationExecutor
    {
        private readonly IDataSource dataSource;

        public MigrationExecutor(IDataSource dataSource) => this.dataSource = dataSource;

        public Task ExecuteAsync(string migrationScript)
            => this.dataSource.Connection.ExecuteAsync(migrationScript);
    }
}
