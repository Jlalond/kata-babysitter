using BabySitterKata.Lib;
using NUnit.Framework;
using System;

namespace BabySitterKata.Tests
{
    [TestFixture]
    public class PayCalculatorTests
    { 
        [Test]
        public void CalculateBasePayForSetNumberOfHours()
        {
            var payCalculator = new PayCalculator();
            Assert.AreEqual(48, payCalculator.CalculatePayForNumberOfHours(new TimeSpan(4, 0 , 0)));
        }
    }
}
