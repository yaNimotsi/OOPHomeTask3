using Lesson4._2.Interfaces;

namespace Lesson4._2.CreatorClasses
{
    internal class BuildingCreator : Creator
    {
        public override IBuilding CreateBuild(double buildingHeight, int numberOfFloor, int numberApartments, int numberEntrances)
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

            return new Building(buildingHeight, numberOfFloor, numberApartments, numberEntrances);
        }
    }
}
