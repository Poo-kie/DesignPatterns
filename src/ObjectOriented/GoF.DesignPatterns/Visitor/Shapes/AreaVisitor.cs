using System;

namespace GoF.DesignPatterns.Visitor.Shapes
{
  public class AreaVisitor : IShapeVisitor<double>
  {
    public double Visit(Square element)
    {
      return element.Side * element.Side;
    }

    public double Visit(Circle element)
    {
      return Math.PI * element.Radius * element.Radius;
    }

    public double Visit(Rectangle element)
    {
      return element.Width * element.Height;
    }
  }
}
