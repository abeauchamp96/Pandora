// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using Pandora.Data.Mocks;
using System.Threading.Tasks;
using Xunit;

namespace Pandora.Data.Migrations
{
    public class MigrationExecutorTests
    {
        private readonly DataSourceMock dataSourceMock = new();
        private readonly DbConnectionMock connectionMock = new();
        private readonly DbCommandMock commandMock = new();

        private readonly IMigrationExecutor migrationExecutor;

        public MigrationExecutorTests()
        {
            this.connectionMock.GivenACommand(this.commandMock.Instance);
            this.connectionMock.GivenAnOpenedConnectionState();

            this.dataSourceMock.GivenAConnection(this.connectionMock.Instance);

            this.migrationExecutor = new MigrationExecutor(this.dataSourceMock.Instance);
        }

        [Fact]
        public async Task ExecuteAsync_ShouldExecuteTheScript()
        {
            const string query = "SELECT * FROM [TABLE]";

            await this.migrationExecutor.ExecuteAsync(query);

            this.commandMock.ExecuteNonQueryAsyncWasCalled(query);
        }
    }
}
