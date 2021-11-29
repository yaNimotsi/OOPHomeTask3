using System;
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
            try
            {
                _saveBuildingInHashtable.Add(build.BuildingNumber, build);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Объект с таким ключом уже существует в таблице. {e.Message}");
                throw;
            }
        }

        public static void RemoveFromHashTable(int buildingNumber)
        {
            try
            {
                _saveBuildingInHashtable.Remove(buildingNumber);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Объекта с указанным ключом не найден. {e.Message}");
                throw;
            }
        }

        //public static List<IBuilding> GetAllBuildingFromHashTable()
        public static List<BaseBuild> GetAllBuildingFromHashTable()
        {
            var allElements = _saveBuildingInHashtable.Values;

            //return saveBuildingInHashtable.Cast<IBuilding>().ToList();
            return (from BaseBuild element in allElements let a = element select element).ToList();
        }

        public static int GenerateBuildingNumber()
        {
            return ++_buildingNumber;
        }
    }
}
