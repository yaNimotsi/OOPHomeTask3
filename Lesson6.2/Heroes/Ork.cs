using Lesson6._2.Heal;
using Lesson6._2.Weapons;

namespace Lesson6._2.Heroes
{
    class Ork :BaseHero
    {
        public Ork() : base()
        {
            NameHero = "Остроухий";
            AmountOfHealth = 3;
            Heal = new Bandage(15);
            Weapon = new Sword();
        }

        public override void Heat()
        {
            Weapon.Heat();
        }

        public override void AddHealth()
        {
            Heal.DoHeal();
        }
    }
}
