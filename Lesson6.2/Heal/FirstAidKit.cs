using System;

namespace Lesson6._2.Heal
{
    class FirstAidKit: BaseHeal
    {
        public FirstAidKit(int valueToHeal):base(valueToHeal)
        {
            NameHeal = "Аптечка";
        }
        public override void DoHeal()
        {
            Console.WriteLine("Работает метод лечения класса FirstAidKit");
        }
    }
}
