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

        public double CalculateAreaOfCarpet()
        {
            return _room.Width *_room.Length;
        }

        public double CalculateTotalPrice()
        {
            var totalCostAsDecimal = CalculateAreaOfCarpet()*_carpet.PricePerSquareMetre;
            if (_carpet.IsRoundedUpToWholeSquareMetre)
                return (double)Math.Ceiling(totalCostAsDecimal);
            return (double)totalCostAsDecimal;
        }
    }
}
