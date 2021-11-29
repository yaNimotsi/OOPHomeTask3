using System;

namespace Lesson7._2
{
    class Circle : Point
    {
        public double Radius { get; set; }

        public Circle(double radius) : base()
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Radius is {Radius}");
        }
    }
}