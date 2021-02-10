
namespace GoF.DesignPatterns.Visitor.Shapes
{
  public class Rectangle : IShape
  {
    public Rectangle(double width, double height)
    {
      Width = width;
      Height = height;
    }

    public double Width { get; }

    public double Height { get; }

    public T Accept<T>(IShapeVisitor<T> visitor)
    {
      return visitor.Visit(this);
    }
  }
}