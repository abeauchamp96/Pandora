// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using Pandora.TestKit;
using System.Data;

namespace Pandora.Data.Mocks
{
    internal sealed class DbConnectionMock : AbstractMock<IDbConnection>
    {
        internal void GivenACommand(IDbCommand command)
            => this.Mock.Setup(c => c.CreateCommand()).Returns(command);

        internal void GivenAnOpenedConnectionState()
            => this.GivenAConnectionState(ConnectionState.Open);

        internal void GivenAConnectionState(ConnectionState connectionState)
            => this.Mock.SetupGet(c => c.State).Returns(connectionState);
    }
}
