namespace GoF.DesignPatterns.Visitor.Shapes
{
  public interface IShapeVisitor<out T>
  {
    T Visit(Square element);

    T Visit(Circle element);

    T Visit(Rectangle element);  
  }
}
