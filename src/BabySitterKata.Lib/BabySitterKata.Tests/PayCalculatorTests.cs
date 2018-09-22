using BabySitterKata.Lib;
using NUnit.Framework;
using System;

namespace BabySitterKata.Tests
{
    [TestFixture]
    public class PayCalculatorTests
    {
        private PayCalculator _payCalculator;
    
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _payCalculator = new PayCalculator();
        } 

        [Test]
        public void BabySittingDuringCoreHoursReturnsBaseRateMultipliedByHours()
        {
            Assert.AreEqual(24, _payCalculator.CalculatePayForNumberOfHours(new DateTime(1, 1, 1, 18, 0, 0), new DateTime(1, 1, 1, 20, 0, 0)));
        }

        [Test]
        public void BabySittingAfterMidnightReturnsMidnightRateMultipliedByHours()
        {
            Assert.AreEqual(64, _payCalculator.CalculatePayForNumberOfHours(new DateTime(1, 1, 1, 0, 0, 0, 0), new DateTime(1, 1, 1, 4, 0, 0)));
        }
    }
}