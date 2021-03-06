﻿using NUnit.Framework;

namespace TellDontAsk.Tests
{
    [TestFixture]
    public class CarpetQuoteTests
    {
        [Test]
        public void RoomFourBySixMetresRequiresTwentyFourSquareMetersOfCarpet()
        {
            Assert.AreEqual(24, CalculateAreaOfCarpet(4, 6), 0);
        }

        [Test]
        public void RoomSixBySixMetresRequiresTwentyFourSquareMetersOfCarpet()
        {
            Assert.AreEqual(36, CalculateAreaOfCarpet(6, 6), 0);
        }


        [Test]
        public void OneSquareMetreOfCarpetCostingNinePerMetreCostsTotalNine()
        {
            Assert.AreEqual(9, CreateCarpetQuoteForRoom(new Carpet(9, true), 1, 1).CalculateTotalPrice(), 0);
        }

        [Test]
        public void FourSquareMetresOfCarpetCostingNinePerMetreCostsTotalThirtySix()
        {
            Assert.AreEqual(36, CreateCarpetQuoteForRoom(new Carpet(9, true), 2, 2).CalculateTotalPrice(), 0);
        }

        [Test]
        public void TwoPointTwoFiveSquareMetresOfCarpetCostingOnePerSquareMetreAndSoldByWholeSquareMetreCostsThree()
        {
            Assert.AreEqual(3, CreateCarpetQuoteForRoom(new Carpet(1, true), 1.5, 1.5).CalculateTotalPrice(), 0);
        }

        [Test]
        public void
            TwoPointTwoFiveSquareMetresOfCarpetCostingOnePerSquareMetreAndSoldByPartSquareMetreCostsTwoPointTwoFive()
        {
            Assert.AreEqual(2.25, CreateCarpetQuoteForRoom(new Carpet(1, false), 1.5, 1.5).CalculateTotalPrice(), 0);
        }

        private double CalculateAreaOfCarpet(double roomWidth, double roomLength)
        {
            return CreateCarpetQuoteForRoom(null, roomWidth, roomLength).CalculateAreaOfCarpet();
        }

        private CarpetQuote CreateCarpetQuoteForRoom(Carpet carpet, double width, double length)
        {
            var room = new Room(width, length);
            var carpetQuote = new CarpetQuote(room, carpet);
            return carpetQuote;
        }
    }
}
