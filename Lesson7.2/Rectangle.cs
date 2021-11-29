using System;

namespace Lesson7._2
{
    class Rectangle : Point
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height) : base()
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Width is {Width}\r\n" +
                              $"Height is {Height}");
        }
    }
}