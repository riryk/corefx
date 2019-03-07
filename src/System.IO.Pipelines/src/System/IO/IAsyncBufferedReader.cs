using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
    public interface IAsyncBufferedReader<T>
    {
        ValueTask<ReadResult<T>> ReadAsync(CancellationToken cancellationToken = default);

        void AdvanceTo(SequencePosition consumed, SequencePosition examined);
    }
}
