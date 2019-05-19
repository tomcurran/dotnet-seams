namespace Seams.SystemSeam
{
    using System;

    public class DateTimeSeam : IDateTimeSeam
    {
        public DateTime Now => DateTime.Now;
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
