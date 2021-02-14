// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

namespace Pandora.Utility.Helpers
{
    public interface IFileHelper
    {
        void Copy(string source, string destination, bool overwrite = false);
        void Create(string path);
        void Delete(string path);
        void Exists(string path);
        void Move(string source, string destination, bool overwrite = false);
    }
}
