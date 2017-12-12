using System.Collections.Generic;

namespace Readability
{
    public class Flight
    {
        private readonly Dictionary<string, Place[]> _places = new Dictionary<string, Place[]>();

        public Flight()
        {
            _places["A"] = new Place[]{new Place(), new Place() };
        }

        public Place Allocate(string row, int number, Passenger passenger)
        {
            var place = _places[row][number];
            place.FlaggedFor = passenger;
            return place;
        }
    }
}