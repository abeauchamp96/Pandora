// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System.IO;

namespace Pandora.Utility.Helpers
{
    internal sealed class PathHelper : IPathHelper
    {
        public string Combine(params string[] paths) => Path.Combine(paths);

        public string? GetDirectoryName(string path) => Path.GetDirectoryName(path);

        public string? GetExtension(string path) => Path.GetExtension(path);

        public string? GetFileName(string path) => Path.GetFileName(path);

        public string GetFileNameWithoutExtension(string path)
            => !string.IsNullOrEmpty(path) ? Path.GetFileNameWithoutExtension(path) : string.Empty;

        public string GetFullPath(string path) => Path.GetFullPath(path);

        public string GetRandomFileName() => Path.GetRandomFileName();

        public string GetRelativePath(string relativeTo, string path)
            => Path.GetRelativePath(relativeTo, path);

        public string GetTemporaryFile() => Path.GetTempFileName();
    }
}
