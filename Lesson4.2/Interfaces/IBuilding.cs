namespace Lesson4._2.Interfaces
{
    internal interface IBuilding
    {
        int BuildingNumber { get; }
        double BuildingHeight { get; set; }

        int NumberOfFloor { get; set; }

        int NumberApartments { get; set; }

        int NumberEntrances { get; set; }

        double GetHeightFloor();
        int GetCountApartmentInEntrance();
        int GetCountApartmentInFloor();
    }
}
