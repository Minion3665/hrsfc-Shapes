using System;

namespace Shapes
{
    public class Rectangle: Shape
    {
        public double Width { get; protected set; }
        public double Height { get; protected set; }
        
        public Rectangle(double width, double height) : base(4)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double CalculateArea()
        {
            return this.Width * this.Height;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }
}