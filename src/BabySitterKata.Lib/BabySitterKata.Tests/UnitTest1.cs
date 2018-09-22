using BabySitterKata.Lib;
using NUnit.Framework;
using System;

namespace BabySitterKata.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void GetBackTimeWhenPassedIn()
        {
            var timespan = new TimeSpan();
            var hourCalculator = new HourCalculator();
            Assert.AreEqual(timespan, hourCalculator.CalculateTime(timespan));
        }

        [Test]
        public void GetBackCorrectNumberOfHours()
        {
            var timeSpan = new TimeSpan(5, 0, 0);
            var hourCalculator = new HourCalculator();
            Assert.AreEqual(5, hourCalculator.CalculateTime(timeSpan).Hours);
            Assert.AreEqual(0, hourCalculator.CalculateTime(timeSpan).Seconds);
        }
    }
}
