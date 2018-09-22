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
            ValidateTimeToCalculate(timeSpan);
            return new TimeSpan(timeSpan.Hours, 0, 0);
        }

        private void ValidateTimeToCalculate(TimeSpan timeSpan)
        {
            if (timeSpan.Hours > 12 || timeSpan.Days > 2)
            {
                throw new ArgumentException("Cannot be longer than 12 hours, be a better parent and hangout with your kids");
            }
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
