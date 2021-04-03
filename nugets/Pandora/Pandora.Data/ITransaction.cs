// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

namespace Pandora.Data
{
    public interface ITransaction
    {
        void Begin();
        void Commit();
        void Rollback();
    }
}
