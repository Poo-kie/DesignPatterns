
namespace GoF.DesignPatterns.Visitor.Shapes
{
  public class Rectangle : ICalculateArea, ICalculatePerimeter
  {
    public Rectangle(double width, double height)
    {
      Width = width;
      Height = height;
    }

    public double Width { get; }

    public double Height { get; }
    public double CalculateArea()
    {
      return Width * Height;
    }

    public double CalculatePerimeter()
    {
      return 2 * (Width + Height);
    }
  }
}