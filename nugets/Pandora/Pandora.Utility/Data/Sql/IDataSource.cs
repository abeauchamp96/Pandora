// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System.Data;

namespace Pandora.Utility.Data.Sql
{
    public interface IDataSource
    {
        IDbConnection Connection { get; }
        IDbTransaction? Transaction { get; }
    }
}
