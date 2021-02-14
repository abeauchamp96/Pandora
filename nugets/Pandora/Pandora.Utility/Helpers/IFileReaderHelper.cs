// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System.Threading;
using System.Threading.Tasks;

namespace Pandora.Utility.Helpers
{
    public interface IFileReaderHelper
    {
        byte[] ReadAllBytes(string path);
        Task<byte[]> ReadAllBytesAsync(string path, CancellationToken cancellationToken = default);
        string[] ReadAllLines(string path);
        Task<string[]> ReadAllLinesAsync(string path, CancellationToken cancellationToken = default);
        string ReadAllText(string path);
        Task<string> ReadAllTextAsync(string path, CancellationToken cancellationToken = default);
    }
}
