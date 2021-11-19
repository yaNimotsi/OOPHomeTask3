using System;

namespace Lesson6._3
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
            return  Math.PI * Math.Pow(Radius,2);
        }
    }
}
