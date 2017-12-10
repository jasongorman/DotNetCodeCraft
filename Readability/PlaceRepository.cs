using System.Collections.Generic;

namespace Readability
{
    public class PlaceRepository
    {
        private readonly Dictionary<string, Place[]> _places = new Dictionary<string, Place[]>();

        public PlaceRepository()
        {
            _places["A"] = new Place[]{new Place(), new Place() };
        }

        public Place Allocate(string row, int number, User user)
        {
            var place = _places[row][number];
            place.FlaggedFor = user;
            return place;
        }
    }
}