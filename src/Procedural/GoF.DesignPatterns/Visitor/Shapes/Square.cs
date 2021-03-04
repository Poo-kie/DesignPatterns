namespace GoF.DesignPatterns.Visitor.Shapes
{
    public class Square : ICalculateArea, ICalculatePerimeter
    {
        public Square(double side)
        {
            Side = side;
        }

        public double Side { get; }
        
        public double CalculateArea()
        {
            return Side * Side;
        }

        public double CalculatePerimeter()
        {
            return Side * 4;
        }
    }
}