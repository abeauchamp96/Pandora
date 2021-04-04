// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using Moq;
using Pandora.TestKit;
using System.Data.Common;
using System.Threading;

namespace Pandora.Data.Mocks
{
    internal sealed class DbCommandMock : AbstractMock<DbCommand>
    {
        internal void ExecuteNonQueryAsyncWasCalled(string query)
        {
            this.Mock.VerifySet(c => c.CommandText = query);
            this.Mock.Verify(c => c.ExecuteNonQueryAsync(It.IsNotNull<CancellationToken>()));
        }
    }
}
