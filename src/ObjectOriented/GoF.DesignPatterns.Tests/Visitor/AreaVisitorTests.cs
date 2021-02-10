using System;
using System.Collections.Generic;
using GoF.DesignPatterns.Visitor.Shapes;
using Xunit;

namespace GoF.DesignPatterns.Tests.Visitor
{
    public class AreaVisitorTests
    {
        [Fact]
        public void Accept_ShouldReturnAreaOfSpecifiedShape()
        {
            var shapes = new IShape[3] 
            {
              new Circle(2),
              new Square(4),
              new Rectangle(5, 6)
            };

            var areas = new double[3];

            for (var i = 0; i < 3; i++)
            {
                var visitor = new AreaVisitor();
                areas[i] = shapes[i].Accept(visitor);
            }

            Assert.Equal(Math.PI * 2 * 2, areas[0]);
            Assert.Equal(4 * 4, areas[1]);
            Assert.Equal(5 * 6, areas[2]);
        }
    }
}
