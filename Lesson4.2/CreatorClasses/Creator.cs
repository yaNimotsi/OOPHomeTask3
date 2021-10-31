using System.Collections;
using Lesson4._2.Interfaces;

namespace Lesson4._2.CreatorClasses
{
    internal abstract class Creator
    {
        public static Hashtable createdBuildingHashtable = new Hashtable();

        protected Creator()
        {
            var building = CreateBuild();
        }

        private static void AddBuildingToHashTable(IBuilding building)
        {
            createdBuildingHashtable.Add(building.BuildingNumber, building);
        }

        public abstract IBuilding CreateBuild();
    }
}
