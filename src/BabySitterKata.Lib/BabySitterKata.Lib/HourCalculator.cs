using System;

namespace BabySitterKata.Lib
{
    public class HourCalculator
    {
        private const int NumberOfHoursToAddToEarliestStartTime = 17;
        private const int MaximumBabysittingTime = 11;

        public TimeSpan CalculateTime(DateTime startTime, DateTime endTime)
        {
            var timeSpan = endTime - startTime;
            ValidateTimesAreAcceptable(startTime, endTime);
            return new TimeSpan(timeSpan.Hours, 0, 0);
        }

        private void ValidateTimesAreAcceptable(DateTime startTime, DateTime endTime)
        {
            var earliestStartTime = new DateTime(startTime.Year, startTime.Month, startTime.Day, NumberOfHoursToAddToEarliestStartTime, 0, 0);
            if (startTime < earliestStartTime)
            {
                throw new ArgumentException("StartTime cannot be before before " + earliestStartTime.ToLocalTime().ToString());
            }
            var latestEndTime = earliestStartTime.AddHours(MaximumBabysittingTime);
            if(endTime > latestEndTime)
            {
                throw new ArgumentException("EndTime cannot be after: " + latestEndTime.ToLocalTime().ToString());
            }
        }
    }
}
