using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swappability
{
    public class VideoRental
    {
        private readonly string _imdbId;
        private readonly Ratings _ratings;

        public VideoRental(string imdbId, Ratings imdb)
        {
            _imdbId = imdbId;
            _ratings = imdb;
        }

        public double CalculatePrice()
        {
            double imdbRating = _ratings.FetchRating(_imdbId);
            double price = 3.95;

            if (imdbRating >= 8.0)
            {
                price += 1.0;
            }

            if (imdbRating < 4.0)
            {
                price -= 1.0;
            }

            return price;
        }
    }
}
