using System;

namespace Lesson4._2.CreatorClasses
{
    internal class BuildingCreator : Creator
    {

        public BaseBuild CreateBuilding(double buildingHeight, int numberOfFloor, int numberApartments,
            int numberEntrances)
        {
            if (buildingHeight < 1)
            {
                throw new ArgumentException("Высота здания не может быть меньше 1!");
            }
            if (numberOfFloor < 1)
            {
                throw new ArgumentException("Количество этажей в здании не может быть меньше 1!");
            }
            if (numberApartments < 1)
            {
                throw new ArgumentException("Количество квартир в здании не может быть меньше 1!");
            }
            if (numberEntrances < 1)
            {
                throw new ArgumentException("Количество подъездов в здании не может быть меньше 1!");
            }

            var buildingNumber = Creator.GenerateBuildingNumber();
            
            return new Build(buildingNumber, buildingHeight, numberOfFloor, numberApartments, numberEntrances);
        }
    }
}
