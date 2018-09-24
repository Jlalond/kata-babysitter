using BabySitterKata.Lib;
using NUnit.Framework;
using System;

namespace BabySitterKata.Tests
{
    [TestFixture]
    public class HourValidatorTests
    {
        private HourValidator _hourCalculator;

        [OneTimeSetUp]
        public void SetUp()
        {
            _hourCalculator = new HourValidator();
        }

        [Test]
        public void GetBackTimeSpanWhenTwoDateTimesArePassedIn()
        {
            var startTime = new DateTime(2000, 6, 14, 17, 0, 0);
            var endTime = new DateTime(2000, 6, 14, 17, 0, 0);
            Assert.DoesNotThrow(() => _hourCalculator.ValidateTimesAreAcceptable(startTime, endTime));
        }

        [Test]
        public void GetBackCorrectNumberOfHours()
        {
            var startTime = new DateTime(2000, 2, 02, 17, 0, 0);
            var endTime = new DateTime(2000, 2, 02, 22, 0, 52);
            Assert.DoesNotThrow(() => _hourCalculator.ValidateTimesAreAcceptable(startTime, endTime));
        }

        [Test]
        public void ThrowsExceptionWhenStartTimeIsBeforeFivePm()
        {
            var startTime = new DateTime(2000, 1, 5, 18, 0, 0);
            var fourteenHoursAfterStart = new DateTime(2000, 1, 6, 8, 0, 0);
            Assert.Throws<ArgumentException>(() => _hourCalculator.ValidateTimesAreAcceptable(startTime, fourteenHoursAfterStart));
        }

        [Test]
        public void ThrowsExceptionWhenEndTimeIsAfterFourAm()
        {
            var startTime = new DateTime(2000, 1, 2, 23, 0, 0, 0);
            var endTime = new DateTime(2000, 1, 3, 5, 0, 0, 0);
            Assert.Throws<ArgumentException>(() => _hourCalculator.ValidateTimesAreAcceptable(startTime, endTime));
        }
    }
}
