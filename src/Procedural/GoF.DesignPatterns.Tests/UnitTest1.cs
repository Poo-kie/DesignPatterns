using System;
using GoF.DesignPatterns.Visitor.Shapes;
using Xunit;

namespace GoF.DesignPatterns.Tests
{
    public class UnitTest1
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
        
        [Fact]
        public void CalculatePerimeter_ShouldReturnExpectedPerimeter()
        {
            ICalculatePerimeter[] shapes = new ICalculatePerimeter[]
            {
                new Circle(3), 
                new Rectangle(3, 5),
                new Square(6)
            };
            
            Assert.Equal(3 * 2 * Math.PI, shapes[0].CalculatePerimeter());
            Assert.Equal(2 * (3 + 5), shapes[1].CalculatePerimeter());
            Assert.Equal(6 * 4, shapes[2].CalculatePerimeter());
        }
    }
}
