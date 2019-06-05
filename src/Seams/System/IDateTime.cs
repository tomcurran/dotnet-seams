namespace Seams.SystemSeam
{
    using System;

    public interface IDateTime
    {
        DateTime Now { get; }

        DateTime UtcNow { get; }

        DateTime Today { get; }
    }
}
