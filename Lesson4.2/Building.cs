using System;
using Lesson4._2.Interfaces;

namespace Lesson4._2
{
    internal class Building : IBuilding
    {
        private static int _buildingNumber;


        public int BuildingNumber => _buildingNumber;
        
        public double BuildingHeight { get; set; }

        public int NumberOfFloor { get; set; }

        public int NumberApartments { get; set; }

        public int NumberEntrances { get; set; }

        private Building()
        {
            GenerateBuildingNumber();
        }

        public Building(double buildingHeight, int numberOfFloor, int numberApartments, int numberEntrances) : this()
        {
            if (buildingHeight <= 0)
            {
                throw new ArgumentException("Высота должна быть больше нуля!");
            }
            if (numberOfFloor <= 0)
            {
                throw new ArgumentException("Количество этажей должно быть больше нуля!");
            }
            if (numberApartments <= 0)
            {
                throw new ArgumentException("Количество квартир должно быть больше нуля!");
            }
            if (numberEntrances <= 0)
            {
                throw new ArgumentException("Количество подьездов должно быть больше нуля!");
            }

            BuildingHeight = buildingHeight;
            NumberOfFloor = numberOfFloor;
            NumberApartments = numberApartments;
            NumberEntrances = numberEntrances;
        }

        private void GenerateBuildingNumber()
        {
            _buildingNumber++;
        }

        /// <summary>
        /// Return the height of the floor
        /// </summary>
        /// <returns></returns>
        public double GetHeightFloor()
        {
            if (BuildingHeight > 0 && NumberOfFloor > 0)
            {
                return BuildingHeight / NumberOfFloor;
            }
            
            return 0;
            
        }

        /// <summary>
        /// Return number apartments in entrance
        /// </summary>
        /// <returns></returns>
        public int GetCountApartmentInEntrance()
        {
            if (NumberApartments > 0 && NumberEntrances > 0)
            {
                return NumberApartments / NumberEntrances;
            }
                
            return 0;
        }

        /// <summary>
        /// Rreturn count apartment in floor
        /// </summary>
        /// <returns></returns>
        public int GetCountApartmentInFloor()
        {
            var apartmentInEntrance = GetCountApartmentInEntrance();

            if (apartmentInEntrance > 0)
            {
                return apartmentInEntrance / NumberOfFloor;
            }

            return 0;
        }
    }
}
/*
 * 2. * Для реализованного класса создать новый класс Creator,
 * который будет являться фабрикой объектов класса здания.
 * Для этого изменить модификатор доступа к конструкторам класса,
 * в новый созданный класс добавить перегруженные фабричные методы CreateBuild
 * для создания объектов класса здания. В классе Creator все методы сделать статическими,
 * конструктор класса сделать закрытым. Для хранения объектов класса здания в классе
 * Creator использовать хеш-таблицу. Предусмотреть возможность удаления объекта здания
 * по его уникальному номеру из хеш-таблицы.
 * Создать тестовый пример, работающий с созданными классами.
 * */