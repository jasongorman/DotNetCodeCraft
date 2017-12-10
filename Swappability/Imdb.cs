namespace Swappability
{
    public class Imdb
    {
        public static double FetchRating(string imdbId)
        {
            // faked response from real IMDB API
            if (imdbId == "tt0111161")
                return 9.2;
            if (imdbId == "tt4458206")
                return 1.6;
            else return 6.0;
        }
    }
}