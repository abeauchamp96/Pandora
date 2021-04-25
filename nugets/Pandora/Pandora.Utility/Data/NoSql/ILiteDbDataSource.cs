// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using LiteDB;

namespace Pandora.Utility.Data.NoSql
{
    public interface ILiteDbDataSource
    {
        ILiteDatabase Database { get; }
    }
}
