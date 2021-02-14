// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System.IO;

namespace Pandora.Utility.Helpers
{
    internal sealed class FileHelper : IFileHelper
    {
        public void Copy(string source, string destination, bool overwrite = false)
            => File.Copy(source, destination, overwrite);

        public void Create(string path) => File.Create(path);

        public void Delete(string path) => File.Delete(path);

        public void Exists(string path) => File.Exists(path);

        public void Move(string source, string destination, bool overwrite = false)
            => File.Move(source, destination, overwrite);
    }
}
