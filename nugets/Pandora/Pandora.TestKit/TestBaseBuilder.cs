// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pandora.TestKit
{
    public abstract class TestBaseBuilder<TBuilder, TItem>
        where TBuilder : TestBaseBuilder<TBuilder, TItem>
        where TItem : class
    {
        private readonly List<Func<TItem, TItem>> decorators = new();
        private Func<TItem> creator = default!;

        public static implicit operator TItem(TestBaseBuilder<TBuilder, TItem> builder)
            => builder.Build();

        public TBuilder As(Func<TItem> creator)
        {
            this.creator = creator;
            return (TBuilder)this;
        }

        public TBuilder With(Action<TItem> decorate)
        {
            this.decorators.Add((item) =>
            {
                decorate(item);
                return item;
            });

            return (TBuilder)this;
        }

        public TBuilder With(Func<TItem, TItem> decorate)
        {
            this.decorators.Add(decorate);
            return (TBuilder)this;
        }

        public TItem Build()
        {
            var item = this.decorators.Aggregate(this.creator(), (item, decorate) => decorate(item));
            this.decorators.Clear();

            return item;
        }
    }
}
