using System;

namespace BabySitterKata.Lib
{
    public class PayCalculator
    {
        public int CalculatePayForNumberOfHours(DateTime startTime, DateTime endTime)
        {
            var midnightOfBabysittingDay = new DateTime(startTime.Year, startTime.Month, startTime.Day, 0, 0, 0);
            if(startTime > midnightOfBabysittingDay)
            {
                return (endTime - startTime).Hours * 12;
            }
            else
            {
                return (endTime - startTime).Hours * 16;
            }
        }
    }
}
