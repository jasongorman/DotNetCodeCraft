using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestAssurance.Tests
{
    [TestFixture]
    public class StringSorterTests
    {
        [Test]
        public void SortsStringsIntoAscendingOrder()
        {
            CollectionAssert.IsOrdered(StringSorter.Sort(new[] {"b", "c", "a"}));
        }
    }
}
