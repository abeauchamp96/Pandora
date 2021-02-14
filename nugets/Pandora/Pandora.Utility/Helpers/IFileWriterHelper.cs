// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Pandora.Utility.Helpers
{
    public interface IFileWriterHelper
    {
        void WriteAllBytes(string path, byte[] bytes);
        Task WriteAllBytesAsync(string path, byte[] bytes, CancellationToken cancellationToken = default);
        void WriteAllLines(string path, IEnumerable<string> contents);
        Task WriteAllLinesAsync(string path, IEnumerable<string> contents, CancellationToken cancellationToken = default);
        void WriteAllText(string path, string content);
        Task WriteAllTextAsync(string path, string content, CancellationToken cancellationToken = default);
    }
}
