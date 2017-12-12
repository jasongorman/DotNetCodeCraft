using System;

namespace TellDontAsk
{
    public class CarpetQuote
    {
        private readonly Room _room;
        private readonly Carpet _carpet;

        public CarpetQuote(Room room, Carpet carpet)
        {
            _room = room;
            _carpet = carpet;
        }

        public Room Room
        {
            get { return _room; }
        }

        public double CalculateTotalPrice()
        {
            var totalCostAsDecimal = _room.CalculateAreaOfCarpet()*_carpet.PricePerSquareMetre;
            if (_carpet.IsRoundedUpToWholeSquareMetre)
                return (double)Math.Ceiling(totalCostAsDecimal);
            return (double)totalCostAsDecimal;
        }
    }
}
