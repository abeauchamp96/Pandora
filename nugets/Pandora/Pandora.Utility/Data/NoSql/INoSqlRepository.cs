// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

namespace Pandora.Utility.Data.NoSql
{
    public interface INoSqlRepository<TCollection>
    {
        TCollection Collection { get; }
    }
}
