using System;

namespace Shapes
{
    public class Square: Rectangle
    {
        public Square (double width): base(width, width) {}

        public override void Draw()
        {
            Console.WriteLine("Drawing a square");
        }
    }
}