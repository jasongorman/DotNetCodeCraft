using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Swappability.Tests
{
    [TestFixture]
    public class VideoRentalTests
    {
        [Test]
        public void VideoRatedEightOrMoreOnImdbIsAnExtraDollar()
        {
            var videoRental = new VideoRental("tt0111161", new Imdb());
            Assert.AreEqual(4.95, videoRental.CalculatePrice());
        }

        [Test]
        public void VideoRatedLessThanFourOnImdbIsDollarOff()
        {
            var videoRental = new VideoRental("tt4458206", new Imdb());
            Assert.AreEqual(2.95, videoRental.CalculatePrice());
        }

        [Test]
        public void DefaultRentalPriceIsThreeNinetyFive()
        {
            var videoRental = new VideoRental("blah", new Imdb());
            Assert.AreEqual(3.95, videoRental.CalculatePrice());
        }
    }
}
