using System;
using NUnit.Framework;

namespace SandroMancusoTraining_Project3
{
    [TestFixture]
    public class IsLeapYearShould
    {
        private DateTime _date;

        [Test]
        public void _1st_be_true_if_divisible_by_four_hundred()
        {
            GivenYear(2000);

            ThenIsLeapYear();
        }

        [Test]
        public void _2nd_be_false_if_divisible_by_one_hundred_and_does_not_break_the_first_law()
        {
            GivenYear(2100);

            ThenNotIsLeapYear();
        }

        [Test]
        public void _3rd_be_true_if_divisible_by_for_and_does_not_break_the_previous_laws()
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
