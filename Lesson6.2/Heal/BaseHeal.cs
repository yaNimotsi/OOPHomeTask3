using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._2.Heal
{
    abstract class BaseHeal
    {
        public string NameHeal { get; set; }
        public int ValueToHeal { get; set; }

        public BaseHeal(int valueToHeal)
        {
            ValueToHeal = valueToHeal;
        }

        public abstract void DoHeal();
    }
}
