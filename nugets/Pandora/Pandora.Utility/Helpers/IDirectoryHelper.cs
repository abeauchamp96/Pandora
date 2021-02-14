// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System.Collections.Generic;

namespace Pandora.Utility.Helpers
{
    public interface IDirectoryHelper
    {
        void Create(string path);
        void Delete(string path);
        IEnumerable<string> EnumerateDirectories(string path);
        IEnumerable<string> EnumerateDirectories(string path, string searchPattern);
        IEnumerable<string> EnumerateFiles(string path);
        IEnumerable<string> EnumerateFiles(string path, string searchPattern);
        bool Exists(string path);
        void Move(string source, string destination);
    }
}
