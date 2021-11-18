namespace Lesson6._2.Heroes
{
    abstract class BaseHero
    {
        public string NameHero { get; set; } 
        public int Health { get; protected set; }

        public abstract void Heat();
    }
}
