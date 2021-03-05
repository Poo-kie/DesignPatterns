using System;
using GoF.DesignPatterns.Visitor.Shapes;
using Xunit;

namespace GoF.DesignPatterns.Tests
{
    public class CalculateAreaTests
    {
        [Fact]
        public void CalculateArea_ShouldReturnExpectedArea()
        {
            ICalculateArea[] shapes = new ICalculateArea[]
            {
                new Circle(3), 
                new Rectangle(3, 5),
                new Square(6)
            };
            
            Assert.Equal(3 * 3 * Math.PI, shapes[0].CalculateArea());
            Assert.Equal(3 * 5, shapes[1].CalculateArea());
            Assert.Equal(6 * 6, shapes[2].CalculateArea());
        }
    }
}