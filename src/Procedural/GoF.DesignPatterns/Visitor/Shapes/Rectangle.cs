
namespace GoF.DesignPatterns.Visitor.Shapes
{
  public class Rectangle
  {
    public Rectangle(double width, double height)
    {
      Width = width;
      Height = height;
    }

    public double Width { get; }

    public double Height { get; }
  }
}