namespace GoF.DesignPatterns.Visitor.Shapes
{
    public class Square : IShape
    {
        public Square(double side)
        {
            Side = side;
        }

        public double Side { get; }

        public T Accept<T>(IShapeVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}