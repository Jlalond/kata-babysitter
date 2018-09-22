using System;

namespace BabySitterKata.Lib
{
    public class HourCalculator
    {
        private const int NumberOfHoursToAddToEarliestStartTime = 17;

        public TimeSpan CalculateTime(DateTime startTime, DateTime endTime)
        {
            var timeSpan = endTime - startTime;
            ValidateStartTimeIsAcceptable(startTime);
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

        private void ValidateStartTimeIsAcceptable(DateTime startTime)
        {
            var earliestStartTime = new DateTime(startTime.Year, startTime.Month, startTime.Day, NumberOfHoursToAddToEarliestStartTime, 0, 0);
            if (startTime < earliestStartTime)
            {
                throw new ArgumentException("StartTime cannot be before before " + earliestStartTime.ToLocalTime().ToString());
            }
        }
    }
}
