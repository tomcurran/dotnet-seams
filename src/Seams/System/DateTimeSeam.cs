namespace Seams.SystemSeam
{
    using System;

    public class DateTimeSeam : IDateTimeSeam
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
