using Lesson6._2.Heal;
using Lesson6._2.Weapons;

namespace Lesson6._2.Heroes
{
    abstract class BaseHero
    {
        public string NameHero { get; set; } 
        public int AmountOfHealth { get; protected set; }
        public int CountHealth { get; set; }
        public BaseHeal Heal { get; set; }
        public BaseWeapon Weapon { get; set; }

        public BaseHero()
        {
            CountHealth = 100;
        }

        public abstract void Heat();
        public abstract void AddHealth();
    }
}
