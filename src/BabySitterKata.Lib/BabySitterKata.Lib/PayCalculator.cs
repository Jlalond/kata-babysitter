using System;

namespace BabySitterKata.Lib
{
    public class PayCalculator
    {
        public int CalculatePayForNumberOfHours(DateTime startTime, DateTime endTime)
        {
            var midnightOfBabysittingDay = CalculateCorrectTimeForMidnight(startTime, endTime);
            var total = 0;
            var temporaryTime = startTime;
            while (temporaryTime < endTime)
            {
                if(temporaryTime < midnightOfBabysittingDay)
                {
                    total += 12;
                }
                else
                {
                    total += 16;
                }
                temporaryTime = temporaryTime.AddHours(1);
            }


            return total;
        }

        private DateTime CalculateCorrectTimeForMidnight(DateTime startTime, DateTime endTime)
        {
            var midnightOfStarTime = new DateTime(startTime.Year, startTime.Month, startTime.Day);
            if(startTime > midnightOfStarTime && endTime > midnightOfStarTime)
            {
                return new DateTime(startTime.Year, startTime.Month, startTime.Day + 1);
            }

            return midnightOfStarTime;
        }
    }
}
