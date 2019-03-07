using System.Buffers;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
    public interface IAsyncBufferedWriter<T> : IBufferWriter<T>
    {
        ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default);

        ValueTask FlushAsync(CancellationToken cancellationToken = default);
    }
}
