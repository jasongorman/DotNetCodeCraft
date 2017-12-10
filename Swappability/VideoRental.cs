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

        public VideoRental(string imdbId)
        {
            _imdbId = imdbId;
        }

        public double CalculatePrice()
        {
            double imdbRating = Imdb.FetchRating(_imdbId);
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
