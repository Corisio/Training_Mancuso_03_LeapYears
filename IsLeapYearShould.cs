using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SandroMancusoTraining_Project3
{
    [TestFixture]
    public class IsLeapYearShould
    {
        [Test]
        public void BeTrueIfIsDivisibleByFourHundred()
        {
            var date = new DateTime(2000, 1, 1);

            Assert.IsTrue(date.IsLeapYear());
        }

        [Test]
        public void BeFalseIfIsDivisibleByOneHundredButNotByFourHundred()
        {
            var date = new DateTime(2100, 1, 1);

            Assert.IsFalse(date.IsLeapYear());
        }

        [Test]
        public void BeTrueIfIsDivisibleByFourButNotByOneHundred()
        {
            var date = new DateTime(2016, 1, 1);

            Assert.IsTrue(date.IsLeapYear());
        }
    }
}
