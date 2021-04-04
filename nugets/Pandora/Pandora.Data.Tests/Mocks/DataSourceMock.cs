// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using Moq;
using Pandora.TestKit;
using System.Data;
using System.Data.Common;
using System.Threading;

namespace Pandora.Data.Mocks
{
    internal sealed class DataSourceMock : AbstractMock<IDataSource>
    {
        internal void GivenAConnection(IDbConnection connection)
            => this.Mock.SetupGet(d => d.Connection).Returns(connection);
    }
}
