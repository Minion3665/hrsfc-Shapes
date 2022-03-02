using System;

namespace Shapes
{
    public class Circle: Shape
    {
        public double Radius { get; protected set; }

        public Circle(double radius): base(0)
        {
            this.Radius = radius;
        }
        
        public override double CalculateArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }
}