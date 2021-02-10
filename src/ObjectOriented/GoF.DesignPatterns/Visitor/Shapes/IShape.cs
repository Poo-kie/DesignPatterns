namespace GoF.DesignPatterns.Visitor.Shapes
{
  public interface IShape 
  {
    T Accept<T>(IShapeVisitor<T> visitor);
  }
}
