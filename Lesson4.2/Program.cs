using System;

namespace Lesson4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var buildingCreator = new BuildingCreator();
            var building = buildingCreator.CreateBuild(10, 1, 1, 1);


            Console.ReadLine();
        }
    }
}
