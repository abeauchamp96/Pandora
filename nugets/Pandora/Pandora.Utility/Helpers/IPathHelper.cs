// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

namespace Pandora.Utility.Helpers
{
    public interface IPathHelper
    {
        string Combine(params string[] paths);
        string? GetDirectoryName(string path);
        string? GetExtension(string path);
        string? GetFileName(string path);
        string GetFileNameWithoutExtension(string path);
        string GetFullPath(string path);
        string GetRandomFileName();
        string GetRelativePath(string relativeTo, string path);
        string GetTemporaryFile();
    }
}
