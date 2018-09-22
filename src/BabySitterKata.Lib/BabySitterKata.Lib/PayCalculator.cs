using System;

namespace BabySitterKata.Lib
{
    public class PayCalculator
    {
        public int CalculatePayForNumberOfHours(TimeSpan duration)
        {
            return duration.Hours * 12;
        }
    }
}
