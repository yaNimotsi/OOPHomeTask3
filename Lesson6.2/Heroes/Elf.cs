using Lesson6._2.Heal;
using Lesson6._2.Weapons;

namespace Lesson6._2.Heroes
{
    class Elf: BaseHero
    {
        public Elf():base()
        {
            NameHero = "Остроухий";
            AmountOfHealth = 3;
            Heal = new FirstAidKit(30);
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
