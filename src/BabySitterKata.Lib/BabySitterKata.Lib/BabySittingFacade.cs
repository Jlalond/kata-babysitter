using System;

namespace BabySitterKata.Lib
{
    public class BabySittingFacade
    {
        private readonly HourValidator _hourValidator;
        private readonly PayCalculator _payCalculator;

        public BabySittingFacade()
        {
            _hourValidator = new HourValidator();
            _payCalculator = new PayCalculator();
        }
        public int ValidateAndCalculateBabySittingExpense(DateTime startTime, DateTime endTime)
        {
            _hourValidator.ValidateTimesAreAcceptable(startTime, endTime);
            return _payCalculator.CalculatePayForNumberOfHours(startTime, endTime);
        }
    }
}
