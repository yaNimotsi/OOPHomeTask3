using System;

namespace Lesson4._2
{
    public abstract class BaseBuild
    {
        public int BuildingNumber { get; }

        public double BuildingHeight { get; set; }

        public int NumberOfFloor { get; set; }

        public int NumberApartments { get; set; }

        public int NumberEntrances { get; set; }

        protected BaseBuild()
        {
        }

        protected BaseBuild(int buildingNumber, double buildingHeight, int numberOfFloor, int numberApartments, int numberEntrances)
        {
            BuildingHeight = buildingHeight;
            NumberOfFloor = numberOfFloor;
            NumberApartments = numberApartments;
            NumberEntrances = numberEntrances;
            BuildingNumber = buildingNumber;
        }

        public abstract double GetHeightFloor();
        public abstract int GetCountApartmentInEntrance();
        public abstract int GetCountApartmentInFloor();

        public override string ToString()
        {
            return  new string($"Number building is {BuildingNumber} \r\n" +
                                    $"Building height is {BuildingHeight} \r\n" +
                                    $"Number of the floor is {NumberOfFloor} \r\n" +
                                    $"Number of Appartaments is {NumberApartments} \r\n" +
                                    $"Number of Entrances is {NumberEntrances}");
        }
    }
}
