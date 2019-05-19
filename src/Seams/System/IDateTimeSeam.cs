namespace Seams.SystemSeam
{
    using System;

    public interface IDateTimeSeam
    {
        DateTime Now { get; }
        DateTime UtcNow { get; }
    }
}
