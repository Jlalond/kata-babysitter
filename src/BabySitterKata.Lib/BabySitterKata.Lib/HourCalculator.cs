using System;

namespace BabySitterKata.Lib
{
    public class HourCalculator
    {
        public TimeSpan CalculateTime(DateTime start, DateTime end)
        {
            var timeSpan = end - start;
            ValidateTimeToCalculate(timeSpan);
            return new TimeSpan(timeSpan.Hours, 0, 0);
        }

        private void ValidateTimeToCalculate(TimeSpan timeSpan)
        {
            if (timeSpan.Hours > 12 || timeSpan.Days > 1)
            {
                throw new ArgumentException("Cannot be longer than 12 hours, be a better parent and hangout with your kids");
            }
            
        }
    }
}
