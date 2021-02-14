// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Pandora.Utility.Helpers
{
    internal sealed class FileWriterHelper : IFileWriterHelper
    {
        public void WriteAllBytes(string path, byte[] bytes) => File.WriteAllBytes(path, bytes);

        public Task WriteAllBytesAsync(string path, byte[] bytes, CancellationToken cancellationToken = default)
            => File.WriteAllBytesAsync(path, bytes, cancellationToken);

        public void WriteAllLines(string path, IEnumerable<string> contents) => File.WriteAllLines(path, contents);

        public Task WriteAllLinesAsync(string path, IEnumerable<string> contents, CancellationToken cancellationToken = default)
            => File.WriteAllLinesAsync(path, contents, cancellationToken);

        public void WriteAllText(string path, string content) => File.WriteAllText(path, content);

        public Task WriteAllTextAsync(string path, string content, CancellationToken cancellationToken = default)
            => File.WriteAllTextAsync(path, content, cancellationToken);
    }
}
