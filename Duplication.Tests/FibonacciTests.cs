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
        [TestCase(0)]
        [TestCase(1)]
        public void FirstTwoAreSameAsIndex(int index)
        {
            Assert.AreEqual(index, new Fibonacci().Calculate(index));
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
