using System.Buffers;

namespace System.IO
{
    public readonly struct ReadResult<T>
    {
        public ReadResult(in ReadOnlySequence<T> buffer, bool isCompleted)
        {
            Buffer = buffer;
            IsCompleted = isCompleted;
        }

        public ReadOnlySequence<T> Buffer { get; }
        public bool IsCompleted { get; }
    }
}
