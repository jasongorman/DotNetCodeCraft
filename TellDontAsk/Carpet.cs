namespace TellDontAsk
{
    public class Carpet
    {
        public Carpet(double pricePerSquareMetre, bool isRoundedUpToWholeSquareMetre)
        {
            PricePerSquareMetre = pricePerSquareMetre;
            IsRoundedUpToWholeSquareMetre = isRoundedUpToWholeSquareMetre;
        }

        public double PricePerSquareMetre { get; private set; }
        public bool IsRoundedUpToWholeSquareMetre { get; private set; }
    }
}