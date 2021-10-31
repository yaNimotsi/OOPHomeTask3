using Lesson4._2.Interfaces;

namespace Lesson4._2.CreatorClasses
{
    internal class BuildingCreator : Creator
    {
        public override IBuilding CreateBuild()
        {
            return new Building();
        }
    }
}
