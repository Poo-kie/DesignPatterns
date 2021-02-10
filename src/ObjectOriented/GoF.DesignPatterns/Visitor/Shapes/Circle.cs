namespace GoF.DesignPatterns.Visitor.Shapes
{
    public class Circle : IShape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; }

        public T Accept<T>(IShapeVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}
