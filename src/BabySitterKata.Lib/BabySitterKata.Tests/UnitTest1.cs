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
    }
}
