using System;

namespace GoF.DesignPatterns.Visitor.Shapes
{
    public class Circle : ICalculateArea, ICalculatePerimeter
    {
        private readonly double _radius;
        
        public Circle(double radius)
        {
            _radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }

        public double CalculatePerimeter()
        {
            return Math.PI * _radius * 2;
        }
    }
}
