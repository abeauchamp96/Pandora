// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System.Data;

namespace Pandora.Utility.Data
{
    public abstract class BaseRepository
    {
        private readonly IDataSource dataSource;

        protected BaseRepository(IDataSource dataSource)
            => this.dataSource = dataSource;

        protected IDbConnection Connection => this.dataSource.Connection;
        protected IDbTransaction? Transaction => this.dataSource.Transaction;
    }
}
