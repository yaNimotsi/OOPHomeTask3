namespace Lesson6._3
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

        public virtual bool IsVisible()
        {
            return Visible;
        }

        public override string ToString()
        {
            return new string($"Color is {Color} \r\n" +
                              $"Visible is {Visible}");
        }
    }
}
