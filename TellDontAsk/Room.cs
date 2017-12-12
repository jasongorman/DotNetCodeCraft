namespace TellDontAsk
{
    public class Room
    {
        public Room(double width, double length)
        {
            Width = width;
            Length = length;
        }

        public double Width { get; private set; }
        public double Length { get; private set; }

        public double CalculateAreaOfCarpet()
        {
            return Width *Length;
        }
    }
}