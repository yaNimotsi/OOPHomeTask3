namespace Lesson6._3
{
    abstract class Point : Figure
    {
        public double CoordinateX { get; set; }
        public double CoordinateY { get; set; }

        protected Point() : base()
        {
            CoordinateX = 0;
            CoordinateY = 0;
        }

        public override void MoveVertical(double val)
        {
            CoordinateX += val;
        }

        public override void MoveHorizontal(double val)
        {
            CoordinateY += val;
        }

        public override void ChangeColor(int newColor)
        {
            Color = newColor;
        }

        public abstract double GetArea();
    }
}
