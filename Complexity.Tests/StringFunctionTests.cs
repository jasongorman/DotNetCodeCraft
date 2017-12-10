using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Complexity.Tests
{
    [TestFixture]
    public class StringFunctionTests
    {
        [Test]
        public void StringsAreReversed()
        {
            Assert.AreEqual("abcd", new StringFunctions().DeprofanedBackwardsToLowerCaseTrimmed("dcba"));
        }

        [Test]
        public void StringsAreTrimmed()
        {
            Assert.AreEqual("abcd", new StringFunctions().DeprofanedBackwardsToLowerCaseTrimmed(" dcba "));
        }

        [Test]
        public void StringsAreMadeLowerCase()
        {
            Assert.AreEqual("a", new StringFunctions().DeprofanedBackwardsToLowerCaseTrimmed("A"));
        }

        [Test]
        public void CurseWordsAreReplaced()
        {
            Assert.AreEqual("XXXX", new StringFunctions().DeprofanedBackwardsToLowerCaseTrimmed("Numpty"));
        }
    }
}
