namespace Seams.SystemSeam
{
    using System;

    public class DateTimeSeam : IDateTime
    {
        public DateTime Now => DateTime.Now;
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
