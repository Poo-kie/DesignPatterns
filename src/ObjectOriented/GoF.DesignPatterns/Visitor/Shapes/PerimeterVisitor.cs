using System;

namespace GoF.DesignPatterns.Visitor.Shapes
{
  public class PerimeterVisitor : IShapeVisitor<double>
  {
    public double Visit(Square element)
    {
      return element.Side * 4;
    }

    public double Visit(Circle element)
    {
      return Math.PI * element.Radius * 2;
    }

    public double Visit(Rectangle element)
    {
      return (element.Width + element.Height) * 2;
    }
  }
}