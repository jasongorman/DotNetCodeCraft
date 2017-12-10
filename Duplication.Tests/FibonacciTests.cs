using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Duplication.Tests
{
    [TestFixture]
    public class FibonacciTests
    {
        [Test]
        public void FirstNumberIsZero()
        {
            Assert.AreEqual(0, new Fibonacci().Calculate(0));
        }

        [Test]
        public void SecondNumberIsOne()
        {
            Assert.AreEqual(1, new Fibonacci().Calculate(1));
        }

        [Test]
        public void ThirdNumberIsOne()
        {
            Assert.AreEqual(1, new Fibonacci().Calculate(2));
        }

        [Test]
        public void FourthNumberIsTwo()
        {
            Assert.AreEqual(2, new Fibonacci().Calculate(3));
        }

        [Test]
        public void SixthNumberIsFive()
        {
            Assert.AreEqual(5, new Fibonacci().Calculate(5));
        }

        [Test]
        public void IndexMustBePositiveInteger()
        {
            Assert.Throws<ArgumentException>(() => new Fibonacci().Calculate(-1));
        }
    }
}
