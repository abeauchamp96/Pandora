// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System.Collections.Generic;
using System.IO;

namespace Pandora.Utility.Helpers
{
    internal sealed class DirectoryHelper : IDirectoryHelper
    {
        public void Create(string path) => Directory.CreateDirectory(path);

        public void Delete(string path) => Directory.Delete(path);

        public IEnumerable<string> EnumerateDirectories(string path)
            => Directory.EnumerateDirectories(path);

        public IEnumerable<string> EnumerateDirectories(string path, string searchPattern)
            => Directory.EnumerateDirectories(path, searchPattern);

        public IEnumerable<string> EnumerateFiles(string path)
            => Directory.EnumerateFiles(path);

        public IEnumerable<string> EnumerateFiles(string path, string searchPattern)
            => Directory.EnumerateFiles(path, searchPattern);

        public bool Exists(string path) => Directory.Exists(path);

        public void Move(string source, string destination)
            => Directory.Move(source, destination);
    }
}
