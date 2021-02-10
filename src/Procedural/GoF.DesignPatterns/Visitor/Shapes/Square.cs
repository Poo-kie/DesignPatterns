namespace GoF.DesignPatterns.Visitor.Shapes
{
    public class Square
    {
        public Square(double side)
        {
            Side = side;
        }

        public double Side { get; }
    }
}