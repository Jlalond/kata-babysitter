using System;

namespace BabySitterKata.Lib
{
    public class HourCalculator
    {
        public TimeSpan CalculateTime(TimeSpan timeSpan)
        {
            return new TimeSpan(timeSpan.Hours, 0, 0);
        }
    }
}
