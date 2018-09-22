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
        public void GetBackTimeSpanWhenTwoDateTimesArePassedIn()
        {
            var start = new DateTime(2000, 6, 14, 17, 0, 0);
            var end = new DateTime(2000, 6, 14, 17, 0, 0);
            var timespan = end - start;
            Assert.AreEqual(timespan, _hourCalculator.CalculateTime(start, end));
        }

        [Test]
        public void GetBackCorrectNumberOfHours()
        {
            var timeSpan = new TimeSpan(5, 0, 0);
            var start = new DateTime(2000, 2, 02, 17, 0, 0);
            var end = new DateTime(2000, 2, 02, 22, 0, 52);
            Assert.AreEqual(5, _hourCalculator.CalculateTime(start, end).Hours);
            Assert.AreEqual(0, _hourCalculator.CalculateTime(start, end).Seconds);
        }

        [Test]
        public void TooLongOfBabySittingThrowsException()
        {
            var start = DateTime.UtcNow;
            var end = DateTime.UtcNow;
            end = end.AddDays(42);
            Assert.Throws<ArgumentException>(() => _hourCalculator.CalculateTime(start, end));
        }

        [Test]
        public void ThrowsExceptionWhenStartTimeIsBeforeFivePm()
        {
            var today = DateTime.Today;
            var noonToday = today.AddHours(12);
            Assert.Throws<ArgumentException>(() => _hourCalculator.CalculateTime(noonToday, noonToday));
        }
    }
}
