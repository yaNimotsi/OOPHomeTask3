using System;

namespace Lesson7._2
{
    abstract class Figure
    {
        public int Color { get; set; }
        public bool Visible { get; set; }

        public Figure()
        {
            Color = 1;
            Visible = true;
        }

        public abstract void MoveVertical(double val);
        public abstract void MoveHorizontal(double val);

        public abstract void ChangeColor(int newColor);

        public bool IsVisible()
        {
            return Visible;
        }

        public abstract double GetArea();

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Color is {Color} \r\n" +
                              $"Visible is {Visible}");
        }

        /*public override string ToString()
        {
            return new string($"Color is {Color} \r\n" +
                              $"Visible is {Visible}");
        }*/
    }
}