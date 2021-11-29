using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._3
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
    }
}
