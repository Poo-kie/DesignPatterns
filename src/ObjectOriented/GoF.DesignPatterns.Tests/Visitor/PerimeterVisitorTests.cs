using System;
using System.Collections.Generic;
using GoF.DesignPatterns.Visitor.Shapes;
using Xunit;

namespace GoF.DesignPatterns.Tests.Visitor
{
    public class PerimeterVisitorTests
    {
        [Fact]
        public void Accept_ShouldReturnPerimeterOfSpecifiedShape()
        {
            var shapes = new IShape[3] 
            {
              new Circle(2),
              new Square(4),
              new Rectangle(5, 6)
            };

            var perimeters = new double[3];

            for (var i = 0; i < 3; i++)
            {
                var visitor = new PerimeterVisitor();
                perimeters[i] = shapes[i].Accept(visitor);
            }

            Assert.Equal(Math.PI * 2 * 2, perimeters[0]);
            Assert.Equal(4 * 4, perimeters[1]);
            Assert.Equal(5 * 2 + 6 * 2, perimeters[2]);
        }
    }
}


