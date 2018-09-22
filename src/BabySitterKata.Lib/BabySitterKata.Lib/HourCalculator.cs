using System;

namespace BabySitterKata.Lib
{
    public class HourCalculator
    {
        public TimeSpan CalculateTime(TimeSpan timeSpan)
        {
            ValidateTimeToCalculate(timeSpan);
            return new TimeSpan(timeSpan.Hours, 0, 0);
        }

        private void ValidateTimeToCalculate(TimeSpan timeSpan)
        {
            if (timeSpan.Hours > 12)
            {
                throw new ArgumentException("Cannot be longer than 12 hours, be a better parent and hangout with your kids");
            }
        }
    }
}
