using System;
using Lesson4._2.CreatorClasses;

namespace Lesson4._2
{
    class Program
    {
        static void Main()
        {
            var buildingCreator = new BuildingCreator();
            
            var building = buildingCreator.CreateBuilding(10, 1, 1, 1);
            var building2 = buildingCreator.CreateBuilding(6000, 3, 3, 1);
            var building3 = buildingCreator.CreateBuilding(8000, 5, 7, 2);

            Creator.AddBuildingToHashTable(building);
            Creator.AddBuildingToHashTable(building2);
            Creator.AddBuildingToHashTable(building3);

            Console.WriteLine("Семейства находящиеся в хеш таблице");

            var allBuilding = Creator.GetAllBuildingFromHashTable();
            foreach (BaseBuild build in allBuilding)
            {
                Console.WriteLine(build.ToString());
                Console.WriteLine();
            }

            Console.WriteLine();

            Creator.RemoveFromHashTable(2);

            Console.WriteLine("Семейства в хеш таблице, после удаления объекта под номером 2");

            allBuilding = Creator.GetAllBuildingFromHashTable();
            foreach (BaseBuild build in allBuilding)
            {
                Console.WriteLine(build .ToString());
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        
    }
}
