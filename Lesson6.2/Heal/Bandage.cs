using System;

namespace Lesson6._2.Heal
{
    class Bandage : BaseHeal
    {
        public Bandage(int valueToHeal) : base(valueToHeal)
        {
            NameHeal = "Повязка";
        }

        public override void DoHeal()
        {
            throw new NotImplementedException();
        }
    }
}
