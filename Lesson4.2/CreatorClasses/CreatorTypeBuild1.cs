using Lesson4._2.Interfaces;
using Lesson4._2.TypesBuilding;

namespace Lesson4._2.CreatorClasses
{
    internal class CreatorTypeBuild2 : Creator
    {
        protected internal CreatorTypeBuild2()
        {

        }
        public override IBuilding CreateBuild()
        {
            return new TypeBuild2();
        }
    }
}
