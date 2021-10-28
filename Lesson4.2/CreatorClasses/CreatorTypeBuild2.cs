using Lesson4._2.Interfaces;
using Lesson4._2.TypesBuilding;

namespace Lesson4._2.CreatorClasses
{
    internal class CreatorTypeBuild1 : Creator
    {
        protected internal CreatorTypeBuild1()
        {

        }
        public override IBuilding CreateBuild()
        {
            return new TypeBuild1();
        }
    }
}
