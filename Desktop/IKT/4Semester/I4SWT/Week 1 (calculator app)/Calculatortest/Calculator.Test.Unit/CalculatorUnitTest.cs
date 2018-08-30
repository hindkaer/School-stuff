using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        [Test]
        public void Add_Add2And4_Returns6()
        {
            var uut = new Calculator();

            Assert.That(uut.Add(2.0, 4.0),Is.EqualTo(6.0));
        }

        [Test]
        public void Add_AddMinus2And4_Returns2()
        {
            var uut = new Calculator();

            Assert.That(uut.Add(-2.0, 4.0), Is.EqualTo(2.0));
        }

        [Test]
        public void Subtract_Sub8From16_Returns8()
        {
            var uut = new Calculator();

            Assert.That(uut.Subtract(16.0, 8.0), Is.EqualTo(8.0));
        }

        [Test]
        public void Subtract_SubMinus8From16_Returns24()
        {
            var uut = new Calculator();

            Assert.That(uut.Subtract(16.0, -8.0), Is.EqualTo(24.0));
        }

        [Test]
        public void Multiply_Multiply3And6_Returns18()
        {
            var uut = new Calculator();

            Assert.That(uut.Multiply(3.0, 6.0), Is.EqualTo(18.0));
        }

        [Test]
        public void Multiply_Multiply3point5And3_Returns10point5()
        {
            var uut = new Calculator();

            Assert.That(uut.Multiply(3.5, 3.0), Is.EqualTo(10.5));
        }

        [Test]
        public void Power_PowMinus4and5_ReturnsMinus1025()
        {
            var uut = new Calculator();

            Assert.That(uut.Power(-4, 5), Is.EqualTo(-1024));
        }
    }
}
