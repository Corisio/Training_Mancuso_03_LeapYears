using System;
using NUnit.Framework;

namespace SandroMancusoTraining_Project3
{
    [TestFixture]
    public class IsLeapYearShould
    {
        private DateTime _date;

        [Test]
        public void BeTrueIfIsDivisibleByFourHundred()
        {
            GivenYear(2000);

            ThenIsLeapYear();
        }

        [Test]
        public void BeFalseIfIsDivisibleByOneHundredButNotByFourHundred()
        {
            GivenYear(2100);

            ThenNotIsLeapYear();
        }

        [Test]
        public void BeTrueIfIsDivisibleByFourButNotByOneHundred()
        {
            GivenYear(2016);

            ThenIsLeapYear();
        }

        private void GivenYear(int year)
        {
            _date = new DateTime(year, 1, 1);
        }

        private void ThenIsLeapYear()
        {
            Assert.IsTrue(_date.IsLeapYear());
        }

        private void ThenNotIsLeapYear()
        {
            Assert.IsFalse(_date.IsLeapYear());
        }
    }
}
