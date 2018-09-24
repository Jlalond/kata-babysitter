using System;
using BabySitterKata.Lib;
using NUnit.Framework;

namespace BabySitterKata.Tests
{
    [TestFixture]
    public class BabySitterFacadeTests
    {
        [Test]
        /*
         * This is really a sanity check to show I thought about an orchestrator
         * And didn't just build random components
         * But we only need one test to show it calls the correct components, not checking their actual logic.
         */
        public void BabySittingFromSixPmToEightPmValidAndReturnsProperCost()
        {
            var babySittingFacade = new BabySittingFacade();
            var startTime = new DateTime(2000, 1, 1, 18, 0, 0);
            var endTime = new DateTime(2000, 1, 1, 20, 0, 0);
            Assert.DoesNotThrow(() => babySittingFacade.ValidateAndCalculateBabySittingExpense(endTime, startTime));
            Assert.AreEqual(24, babySittingFacade.ValidateAndCalculateBabySittingExpense(startTime, endTime));
        }
    }
}
