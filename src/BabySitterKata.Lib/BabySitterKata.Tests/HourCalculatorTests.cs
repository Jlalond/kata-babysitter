using BabySitterKata.Lib;
using NUnit.Framework;
using System;

namespace BabySitterKata.Tests
{
    [TestFixture]
    public class HourCalculatorTests
    {
        private HourCalculator _hourCalculator;

        [OneTimeSetUp]
        public void SetUp()
        {
            _hourCalculator = new HourCalculator();
        }

        [Test]
        public void GetBackTimeWhenPassedIn()
        {
            var timespan = new TimeSpan();
            Assert.AreEqual(timespan, _hourCalculator.CalculateTime(timespan));
        }

        [Test]
        public void GetBackCorrectNumberOfHours()
        {
            var timeSpan = new TimeSpan(5, 0, 0);
            Assert.AreEqual(5, _hourCalculator.CalculateTime(timeSpan).Hours);
            Assert.AreEqual(0, _hourCalculator.CalculateTime(timeSpan).Seconds);
        }

        [Test]
        public void TooLongOfBabySittingThrowsException()
        {
            var timeSpan = new TimeSpan(42, 0, 0);
            Assert.Throws<ArgumentException>(() => _hourCalculator.CalculateTime(timeSpan));
        }
    }
}
