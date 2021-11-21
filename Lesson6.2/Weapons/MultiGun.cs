using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._2.Weapons
{
    class MultiGun : BaseWeapon
    {
        public override void Heat()
        {
            Console.WriteLine("Heat from multiGun");
        }
    }
}
