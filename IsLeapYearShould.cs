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
    }
}
