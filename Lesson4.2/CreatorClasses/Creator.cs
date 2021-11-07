using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lesson4._2.CreatorClasses
{
    internal abstract class Creator
    {
        private static int _buildingNumber;

        private static Hashtable _saveBuildingInHashtable = new Hashtable();

        protected Creator()
        {
        }

        //public static void AddBuildingToHashTable(IBuilding build)
        public static void AddBuildingToHashTable(BaseBuild build)
        {
            _saveBuildingInHashtable.Add(build.BuildingNumber, build);
        }

        public static void RemoveFromHashTable(int buildingNumber)
        {
            _saveBuildingInHashtable.Remove(buildingNumber);
        }

        //public static List<IBuilding> GetAllBuildingFromHashTable()
        public static List<BaseBuild> GetAllBuildingFromHashTable()
        {
            //return saveBuildingInHashtable.Cast<IBuilding>().ToList();
            return _saveBuildingInHashtable.Cast<BaseBuild>().ToList();
        }

        public static int GenerateBuildingNumber()
        {
            return ++_buildingNumber;
        }
    }
}
