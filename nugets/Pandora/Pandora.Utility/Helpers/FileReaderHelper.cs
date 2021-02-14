// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Pandora.Utility.Helpers
{
    internal sealed class FileReaderHelper : IFileReaderHelper
    {
        public byte[] ReadAllBytes(string path)
            => File.Exists(path) ? File.ReadAllBytes(path) : Array.Empty<byte>();

        public Task<byte[]> ReadAllBytesAsync(string path, CancellationToken cancellationToken = default)
            => File.Exists(path) ? File.ReadAllBytesAsync(path, cancellationToken) : Task.FromResult(Array.Empty<byte>());

        public string[] ReadAllLines(string path)
            => File.Exists(path) ? File.ReadAllLines(path) : Array.Empty<string>();

        public Task<string[]> ReadAllLinesAsync(string path, CancellationToken cancellationToken = default)
            => File.Exists(path) ? File.ReadAllLinesAsync(path, cancellationToken) : Task.FromResult(Array.Empty<string>());

        public string ReadAllText(string path)
            => File.Exists(path) ? File.ReadAllText(path) : string.Empty;

        public Task<string> ReadAllTextAsync(string path, CancellationToken cancellationToken = default)
            => File.Exists(path) ? File.ReadAllTextAsync(path, cancellationToken) : Task.FromResult(string.Empty);
    }
}
