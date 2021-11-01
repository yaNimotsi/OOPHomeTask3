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

        }

        protected internal  Building(double buildingHeight, int numberOfFloor, int numberApartments, int numberEntrances)
        {
            BuildingHeight = buildingHeight;
            NumberOfFloor = numberOfFloor;
            NumberApartments = numberApartments;
            NumberEntrances = numberEntrances;
            
            GenerteBuildingNumber();
        }

        private void GenerteBuildingNumber()
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

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            Building build = (Building)obj;

            return this.BuildingNumber == build.BuildingNumber;
        }


        public override int GetHashCode()
        {
            var result = 0;
            if (this.BuildingNumber != 0)
            {
                result +=BuildingNumber.GetHashCode();
            }
            if (this.BuildingHeight != 0)
            {
                result += BuildingHeight.GetHashCode();
            }
            if (this.NumberOfFloor != 0)
            {
                result += NumberOfFloor.GetHashCode();
            }
            if (this.NumberApartments != 0)
            {
                result += BuildingNumber.GetHashCode();
            }
            if (this.NumberEntrances != 0)
            {
                result += NumberEntrances.GetHashCode();
            }

            return result;
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