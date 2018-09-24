using System;

namespace BabySitterKata.Lib
{
    public class PayCalculator
    {
        public int CalculatePayForNumberOfHours(DateTime startTime, DateTime endTime)
        {
            var midnightOfBabysittingDay = CalculateCorrectTimeForMidnight(startTime, endTime);
            var bedTime = BuildBedTimeDateTime(midnightOfBabysittingDay, startTime);
            var total = 0;
            var temporaryTime = startTime;
            while (temporaryTime < endTime)
            {
                if(temporaryTime < midnightOfBabysittingDay && midnightOfBabysittingDay < bedTime)
                {
                    total += 12;
                }
                else if (temporaryTime < midnightOfBabysittingDay && midnightOfBabysittingDay > bedTime)
                {
                    total += 8;
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
            var midnightOfStartTime = new DateTime(startTime.Year, startTime.Month, startTime.Day);
            if(startTime > midnightOfStartTime && endTime > midnightOfStartTime)
            {
                return new DateTime(startTime.Year, startTime.Month, startTime.Day + 1);
            }

            return midnightOfStartTime;
        }

        private static DateTime BuildBedTimeDateTime(DateTime midnightToUse, DateTime startTime)
        {
            // I texted my mom, and she said bedtime is 10.
            if (midnightToUse.Day > startTime.Day)
            {
                return new DateTime(midnightToUse.Year, midnightToUse.Month, startTime.Day, 22, 0, 0);
            }
            return new DateTime(midnightToUse.Year, midnightToUse.Month, midnightToUse.Day, 22, 0, 0);
        }
    }
}
