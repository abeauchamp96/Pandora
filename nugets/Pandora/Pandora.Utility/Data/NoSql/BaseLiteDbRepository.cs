// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using LiteDB;

namespace Pandora.Utility.Data.NoSql
{
    public abstract class BaseLiteDbRepository<TModel> where TModel : class
    {
        protected BaseLiteDbRepository(ILiteDbDataSource dataSource)
            => this.Collection = dataSource.Database.GetCollection<TModel>();

        protected ILiteCollection<TModel> Collection { get; }
    }
}
