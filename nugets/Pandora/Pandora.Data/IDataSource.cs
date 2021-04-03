// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System.Data;

namespace Pandora.Data
{
    public interface IDataSource
    {
        IDbConnection Connection { get; }
        IDbTransaction? Transaction { get; }
    }
}
